function setFProductSelect(data) {
    $('#FProduct').empty();
    var isOut = $('#FIsOut option:selected').val();
    var isIndustry = $('#FIsIndustry option:selected').val();
    if (isOut == '0' && isIndustry == '1') {
        // 内销工业表
        for (var i in data) {
            if (data[i].FIsIndustry && !data[i].FIsOut) {
                var op = "<option value=" + "'" + data[i].FMeterName + "'>" + data[i].FMeterName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else if (isOut == '0' && isIndustry == '0') {
        // 内销民用表
        for (var i in data) {
            if (!data[i].FIsIndustry && !data[i].FIsOut) {
                var op = "<option value=" + "'" + data[i].FMeterName + "'>" + data[i].FMeterName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else if (isOut == '1' && isIndustry == '1') {
        // 外销工业表
        for (var i in data) {
            if (data[i].FIsIndustry && data[i].FIsOut) {
                var op = "<option value=" + "'" + data[i].FMeterName + "'>" + data[i].FMeterName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else {
        // 外销民用表
        for (var i in data) {
            if (!data[i].FIsIndustry && data[i].FIsOut) {
                var op = "<option value=" + "'" + data[i].FMeterName + "'>" + data[i].FMeterName + "</option>";
                $('#FProduct').append(op);
            }
        }
    }
}