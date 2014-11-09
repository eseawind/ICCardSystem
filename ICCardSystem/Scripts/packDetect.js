function packDetect(box) {
    var identLength = box.length;
    // 从第一块表开始检测
    // 判断表型和箱子类型是否相同
    // 判断表有无重复
    var m1, m2, m3, m4;
    $('#FMeterCode1').keyup(function (event) {
        // 表一判空
        if (event.keyCode == 13) {
            m1 = $('#FMeterCode1').val();
            if (m1 == '') {
                $('#FMeterCode1').focus().select();
            } else {
                // 判断表型
                if (m1.substring(0, identLength-1) == box.substring(1, identLength)) {
                    $('#FMeterCode2').focus().select();
                } else {
                    $('#FMeterCode1').val("");
                    $('#FMeterCode1').focus().select();
                }
            }
        }
    });

    $('#FMeterCode2').keyup(function (event) {
        // 表二判空
        if (event.keyCode == 13) {
            m2 = $('#FMeterCode2').val();
            if (m2 == '') {
                $('#FMeterCode2').focus().select();
            } else {
                // 判断表型
                if (m2.substring(0, identLength-1) == box.substring(1, identLength)) {
                    $('#FMeterCode3').focus().select();
                } else {
                    $('#FMeterCode2').val("");
                    $('#FMeterCode2').focus().select();
                }
                // 判断是否重复
                if (m2 == m1) {
                    $('#FMeterCode2').val("");
                    $('#FMeterCode2').focus().select();
                }
            }
        }
    });

    $('#FMeterCode3').keyup(function (event) {
        // 表三判空
        if (event.keyCode == 13) {
            m3 = $('#FMeterCode3').val();
            if (m3 == '') {
                $('#FMeterCode3').focus().select();
            } else {
                // 判断表型
                if (m3.substring(0, identLength - 1) == box.substring(1, identLength)) {
                    $('#FMeterCode4').focus().select();
                } else {
                    $('#FMeterCode3').val("");
                    $('#FMeterCode3').focus().select();
                }
                // 判断是否重复
                if (m3 == m1 || m3 == m2) {
                    $('#FMeterCode3').val("");
                    $('#FMeterCode3').focus().select();
                }
            }
        }
    });
       
    $('#FMeterCode4').keyup(function (event) {
        // 表四判空
        if (event.keyCode == 13) {
            m4 = $('#FMeterCode4').val();
            if (m4 == '') {
                $('#FMeterCode4').focus().select();
            } else {
                // 判断是否重复
                if (m4 == m1 || m4 == m2 || m4 == m3) {
                    $('#FMeterCode4').val("");
                    $('#FMeterCode4').focus().select();
                }

                // 判断表型
                if (m4.substring(0, identLength - 1) == box.substring(1, identLength)) {
                    $('#submitBtn').trigger("click");
                } else {
                    $('#FMeterCode4').val("");
                    $('#FMeterCode4').focus().select();
                }
            }
        }
    });
}