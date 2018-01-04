
    $(document).ready(function () {
        $("#divFileUpload").mouseenter(function () {
            imageStatusOnHover();
        }).mouseleave(function () {
            imageStatusOffHover();
        });

    });

function imageStatusOnHover() {
    if ($("#file1").val() != "") {
        var fileURL = $("#file1").val().replace(/\\/g, "\\\\");
        showImagemTooltip(fileURL);
    }
}

function imageStatusOffHover() {
    $('#divImageTooltip').hide();
}

function showImagemTooltip(file) {
    $('#divImageTooltip').css({
        "backgroundImage": "url(" + file + ")",
        "background-repeat": "no-repeat",
        "background-size": "contain",
        "background-position": "center",
        "background-color": "white"
    });

    $('#divImageTooltip').show();
    $("#divFileUpload").mousemove(function (event) {
        $('#divImageTooltip').css({ 'top': event.pageY, 'left': event.pageX });
    });
}


