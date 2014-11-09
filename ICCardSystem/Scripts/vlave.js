function setFProductSelect(data) {
    $('#FProduct').empty();
    var isRight = $('#FIsRight option:selected').val();
    var isIndustry = $('#FIsIndustry option:selected').val();
    if (isRight == '0' && isIndustry == '1') {
        // 工业左表
        for (var i in data) {
            if (data[i].FIsIndustry && !data[i].FIsRight) {
                var op = "<option value=" + "'" + data[i].FValveName + "'>" + data[i].FValveName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else if (isRight == '0' && isIndustry == '0') {
        // 民用左表
        for (var i in data) {
            if (!data[i].FIsIndustry && !data[i].FIsRight) {
                var op = "<option value=" + "'" + data[i].FValveName + "'>" + data[i].FValveName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else if (isRight == '1' && isIndustry == '1') {
        // 工业右表
        for (var i in data) {
            if (data[i].FIsIndustry && data[i].FIsRight) {
                var op = "<option value=" + "'" + data[i].FValveName + "'>" + data[i].FValveName + "</option>";
                $('#FProduct').append(op);
            }
        }
    } else {
        // 民用右表
        for (var i in data) {
            if (!data[i].FIsIndustry && data[i].FIsRight) {
                var op = "<option value=" + "'" + data[i].FValveName + "'>" + data[i].FValveName + "</option>";
                $('#FProduct').append(op);
            }
        }
    }
}