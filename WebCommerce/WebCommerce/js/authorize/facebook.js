
function getFacebookTokenId() {
    return fbTokenId;
}

onRegisterSuccess = function () {
    login(getForeignToken(), $('#autologin').parent().hasClass('checked'), getFacebookTokenId());
}

function onLoginSuccess() {
    window.location.href = redirectUrl;
}


function jsonObjectFromUrl(url, sucessCallBack) {
    $.ajax({
        url: url,
        type: 'get',
        cache: false,
        success: sucessCallBack
    });
};

function getFacebookData(idToken, query, sucessCallBack) {
    // var url = ["https://graph.facebook.com/", query, "?access_token=", idToken].join('');
    var url = ["https://graph.facebook.com/v2.9/me?access_token=",
        idToken,
        "&debug=all&fields=name%2Cemail&format=json&method=get&pretty=0&suppress_http_code=1"].join('');
    jsonObjectFromUrl(url, sucessCallBack);
}

function getUrl(infos, idToken) {
    return ["https://graph.facebook.com/v2.9/me?access_token=",
    idToken,
        "&debug=all&fields=",
        infos.join('%2C'),
        "&format=json&method=get&pretty=0&suppress_http_code=1"].join('');
}

function findUser(foreignToken, facebookTokenId, successCallback, failedCallback) {
    var data = ["__RequestVerificationToken=",
            foreignToken,
            "&FacebookTokenId=",
            facebookTokenId].join('');

    $.ajax({
        url: "/RegisterFacebookAccount/FindUser",
        type: "POST",
        data: data,
        dataType: "json",
        success: successCallback,
        failed: failedCallback
    });
}

function register(foreignToken, facebookTokenId, content, successCallback, failedCallback) {

    $.post("/RegisterFacebookAccount/ComitAvatar",
        {
            avatar: content.image,
            filename: $('#avatar').attr('name') + ".png"
        });

    var data = ["__RequestVerificationToken=",
            foreignToken,
            "&FacebookTokenId=",
            facebookTokenId,
            "&Email=",
        content.email,
            "&Name=",
        content.name,
            "&Avatar=",
        $('#avatar').attr('name') + ".png"
    ].join('');

    $.ajax({
        url: "/RegisterFacebookAccount/Register",
        type: "POST",
        data: data,
        dataType: "json",
        success: function (data) {
            if (data.result == "success") {
                onRegisterSuccess();
                if (successCallback != null)
                    successCallback(data);
            }
            else {
                if (data.errorVal == 1)
                    login(getForeignToken(), $('#autologin').parent().hasClass('checked'), getFacebookTokenId());
                if (failedCallback != null)
                    failedCallback(data);
            }
        },
        failed: failedCallback
    });
}

function login(foreignToken, rememberMe, facebookTokenId, successCallback, failedCallback) {
    var data = ["__RequestVerificationToken=",
            foreignToken,
            "&FacebookTokenId=",
            facebookTokenId,
            "&RememberMe=",
            rememberMe
    ].join('');

    $.ajax({
        url: "/RegisterFacebookAccount/Login",
        type: "POST",
        data: data,
        dataType: "json",
        success: function (data) {
            if (data.result == "success") {
                onLoginSuccess();
                if (successCallback != null) {
                    success(data);
                }
            }
        },
        failed: failedCallback
    });
}

function getForeignToken() {
    return $('#anti-foreign-token').find('input').val();
}




function onDataFacebookLoaded(data) {
    //TODO add data load complete here
    $('#txtName').val(data.name);
    $('#txtEmail').val(data.email);
    $('#avatar').attr('src', data.picture.data.url );
    $('#avatar').attr('name', data.id);
    $('#buttonRegister').empty();
    $('#buttonRegister').append("Register");
    $('#buttonRegister').prop("disabled", false);
}

function getDataFromFacebookTokenId() {
    var idToken = getFacebookTokenId();
    var foreignToken = getForeignToken();
    //st1. find user using facebook token id
    findUser(foreignToken, idToken, function (data) {
        //if contain user
        if (data.result == "success") {
            //login existing user
            login(foreignToken, true, idToken);
        }
        else {
            //if user not register. get infomation from facebook to register
            //init url to get info facebook
            var url = getUrl(["id", "name", "picture", "email"], idToken);
            //get data json from url
            jsonObjectFromUrl(url, function (data) {
                onDataFacebookLoaded(data);
            });
        }
    });

}

function loading() {
    $('#buttonRegister').empty();
    $('#buttonRegister').append("Waiting data...<i class='fa-spin fa fa-spinner fa-lg'>");
    $('#buttonRegister').prop("disabled", true);
}

$(document).ready(function () {
    loading();
    getDataFromFacebookTokenId();
});


$('#buttonRegister').click(function (e) {
    var idToken = getFacebookTokenId();
    var content = {
        name: $('#txtName').val(), email: $('#txtEmail').val(),
        image : $('#avatar').attr('src')
    };
    register(getForeignToken(), idToken, content);
});


