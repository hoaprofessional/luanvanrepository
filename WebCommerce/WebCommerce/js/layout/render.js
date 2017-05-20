
function renderMenu(url, parentElement) {
    $.getJSON(url, function (menus) {
        var index = 0;
        var contents = [];
        $.each(menus, function (key, menu) {
            if (menu.Childs == null) {
                contents[index++] = ['<li><a class="web-menu" href="',
                menu.Content.MenuUrl,
                '">',
                menu.Display,
                '</a></li>'].join('');
            }
            else {
                contents[index++] = ['<li class="dropdown">',
               '<a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">',
               menu.Display,
               '&nbsp;<b class="caret"></b></a>',
               '<span class="dropdown-arrow"></span>',
               '<ul class="dropdown-menu">',
                ].join('');
                $.each(menu.Childs, function (key, menuChild) {
                    contents[index++] = ['<li><a href="#"><i class="fa ',
                   menuChild.Content.FaSymbol,
                   '"></i>',
                   menuChild.Display,
                   '</a></li>'
                    ].join('');
                });
                contents[index++] = ['</ul>',
               '</li>',
                ].join('');
            }
        });
        parentElement.append(contents.join(''));
    });
}