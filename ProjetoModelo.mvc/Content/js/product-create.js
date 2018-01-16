
function submitUpload() {


    //$('#barProgress').show();

    var fotoFile = $("#file");



    $.ajax({
        type: "POST",
        url: '/UploadFile/Process',
        data: JSON.stringify({
            foto: fotoFile
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: true,
        success: function (data) {

            if (data.st == 'OK') {
                showMessage(data.st, data.msg, divMsg, btnSend)
            }
            else {
                showMessage('ERRO', data.msg, divMsg, btnSend)
            }
        },
        failure: function (data) {
            showMessage('ERRO', data.msg, divMsg, btnSend)
        },
        error: function (data) {
            showMessagen('ERRO', data.msg, divMsg, btnSend)
        }
    });

    // O retorno é para o evento do click do form, que, caso receba true, enviará o fomulário novamente.
    // Por isso deve ser false.
    return false;
};

function showMessage(status, msg, divMsg, btnSend) {
    var alertClass = "";
    if (msg == undefined) {
        msg = "Opss... Ocorreu um erro! Verifique sua conexão com a Internet e tente novamente.";
    }
    if (status == "OK") {
        alertClass = "alert-success";
    }
    else {
        alertClass = "alert-warning";
    }

    divMsg.html('<div id="divMensagem" class="alert ' + alertClass + '" role="alert"><p class="pull-left"><strong>Status</strong></p><button class="close" data-dismiss="alert"></button><br /><div class="clearfix"></div>' + msg + '</br></div>');

    btnSend.removeAttr('disabled');
    $('#divMensagem').delay(6000).fadeOut();

};

