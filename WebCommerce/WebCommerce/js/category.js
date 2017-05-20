
$('.category-row').each(function(key, data) {
    $(data).click(function(e) {
        e.preventDefault();
        window.location.href = "/Topic?catId=" + $($(data).find('.cat-id')[0]).text();
    });
});

$($('.featured-topic')[0]).css('height', $($('.content-info')[0]).outerHeight() + 'px');
var featureHeight = $($('.content-info')[0]).outerHeight() - $('#feature-header-fixed').outerHeight();
$('#feature-header-scroll').css('height', featureHeight + 'px');

