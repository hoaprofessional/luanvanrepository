function onLoadDataFacebookComplete(tokenId) {
    // Add code on load data complete here
    var redirectUrl = window.location.href;
    window.location.href = "/RegisterFacebookAccount?facebookTokenId=" + tokenId + "&redirectUrl=" + redirectUrl;
}

$('#logout').click(function (e) {
    e.preventDefault();
    $.post('RegisterFacebookAccount/LogOff');
    location.reload();
});

$('#buttonRegister').click(function (e) {
    e.preventDefault();
    fb_login();
});

window.fbAsyncInit = function () {
    FB.init({
        appId: '653888671482762',
        cookie: false,  // enable cookies to allow the server to access 
        // the session
        xfbml: true,  // parse social plugins on this page
        version: 'v2.0' // use version 2.0
    });
};

// Load the SDK asynchronously
(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

function fb_login() {
    FB.login(function (response) {
        if (response.authResponse) {
            //   console.log('Welcome!  Fetching your information.... ');
            //console.log(response); // dump complete info
            access_token = response.authResponse.accessToken; //get access token
            onLoadDataFacebookComplete(access_token)
        } else {
            //user hit cancel button
            //  console.log('User cancelled login or did not fully authorize.');

        }
    }, {
        scope: 'email'
    });
}