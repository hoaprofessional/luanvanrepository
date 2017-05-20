

var contentExpands = [];

function onExpand(expand,item) {
    
}

function onPrepareExpand(expand, item) {
    
}

function headerExpandClick(contentExpand,key) {
    onPrepareExpand(false, contentExpand);
    if (contentExpand.css('display') !== 'none') {
        contentExpand.animate({
            height: 0
        },  contentExpands[key], function () {
            contentExpand.css('display', 'none');
            onExpand(false, contentExpand);
        });
    } else {
        onPrepareExpand(true, contentExpand);
        contentExpand.css('display', 'block');
        contentExpand.animate({
            height: contentExpands[key]
        },  contentExpands[key] ,function() {
            onExpand(true, contentExpand);
        });
    }
}

$.each($('.title-item'),
    function(key, val) {
        var parent = $(val).parent();
        var contentExpand = $($(parent).find('.content-expand')[0]);
        contentExpands[key] = (contentExpand.outerHeight());
        $(val).click(function (e) {
            e.preventDefault();
            headerExpandClick(contentExpand,key);
        });   
    });

function isExpand(item) {
    return item.find('.content-expand').css('display') !== 'none';
}

function setExpand(item, expand) {
    if (expand) {
        if (!isExpand(item)) {
            $(item.find('.title-item')[0]).click();
        }
    } else {
        if (isExpand(item)) {
            $(item.find('.title-item')[0]).click();
        }
    }

}
