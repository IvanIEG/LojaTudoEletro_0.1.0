
$(document).ready(function () {
    $("#btnSend").click(function () {
        console.log("Here");
        consultaCep();
    });
});


function consultaCep() {

    $.ajax({
        url: '/Sales/CorreiosCalc',
        type: "GET",
        contentType: "Application/json",
        data: { cep: $("#txtCep").val() },
        succes: function (result) {

        },


    });

};

