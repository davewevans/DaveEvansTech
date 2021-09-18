
export function renderHoneyBookForm(h, b, s, n, i, p, e, t) {
    window._HB_ = window._HB_ || {};
    window._HB_.pid = i;;;;
    t = document.createElement(s);
    t.type = "text/javascript";
    t.async = !0;
    t.src = n;
    e = document.getElementsByTagName(s)[0];
    e.parentNode.insertBefore(t, e);

    //alert(n);
}


//(function (h, b, s, n, i, p, e, t) {
//    h._HB_ = h._HB_ || {}; h._HB_.pid = i;;;;
//    t = b.createElement(s); t.type = "text/javascript"; t.async = !0; t.src = n;
//    e = b.getElementsByTagName(s)[0]; e.parentNode.insertBefore(t, e);
//})
// (window, document, "script", "https://widget.honeybook.com/assets_users_production/websiteplacements/placement-controller.min.js", "605f1c504cb9c92effa9f023");