function nowTimeToStr() {
    var d = new Date();
    var t = d;
    var _d = new Array();
    _d = d.toLocaleDateString().split("/");

    // 获取年份
    var y = _d[2];

    //获取月份
    var mon = _d[0];
    if (mon.length == 1) {
        mon = "0" + mon;
    }

    // 获取日
    var d = _d[1];
    if (d.length == 1) {
        d = "0" + d;
    }

    var _t = new Array();
    _t = t.toLocaleTimeString().split(":");

    // 获取小时
    var h = _t[0];
    if (h.length == 1) {
        h = "0" + h;
    }

    // 获取分钟
    var min = _t[1];
    if (min.length == 1) {
        min = "0" + min
    }

    // 获取秒
    var se = _t[2].split(" ");
    var s = se[0];
    if (s == 1) {
        s = "0" + s;
    }

    return y + mon + d + h + min + s;
}

function getCurrentFormatTime() {
    var curDate = new Date();
    var nowDate = curDate.getFullYear() + "-" +
                  (curDate.getMonth() + 1) + "-" +
                  curDate.getDate();
    return nowDate;
}