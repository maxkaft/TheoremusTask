// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#body")
        .append($("<button>CLICKME</button>").click(GetAjax))

});



function GetAjax() {
    $.ajax({
        method: "GET",
        url: "https://localhost:44337/api/stations"
    }).then(function (data) {
        console.log(data);
        console.log("success");
        }).catch(function (e) {
            console.log(e);
        })
}
