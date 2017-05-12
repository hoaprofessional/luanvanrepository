

function jsonObjectFromUrl(url, sucessCallBack) {
    $.ajax({
        url: url,
        type: 'get',
        cache: false,
        success: sucessCallBack
    });
};

function postFacebookData(idToken, facebookData, sucessCallBack) {
    $.post('api/FacebookInfo/SaveInfo', { IdToken: idToken, FacebookData: facebookData.data })
    .done(sucessCallBack);
}

function getFacebookData(idToken, query, sucessCallBack) {
    var url = ["https://graph.facebook.com/", query, "?access_token=", idToken].join('');
    jsonObjectFromUrl(url, sucessCallBack);
}

function demoPostToServer(idToken, query) {
    successCallBack = function (data) {
        postFacebookData(idToken, data);
    }
    getFacebookData(idToken, query, successCallBack);
   
}

