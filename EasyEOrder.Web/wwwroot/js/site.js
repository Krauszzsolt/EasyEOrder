// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code

function initialize() {
    var latlng = new google.maps.LatLng(47.28, 19.03);
    var myOptions = {
        zoom: 12,
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
}

//$(document).ready(function () {
//    toastr.options = {
//        positionClass: 'toast-bottom-center'
//    };
//    $('#addCart').click(function () {
//        $.ajax({
//            url: '@Url.Action("AddCart", "Food")',
//            type: 'POST',
//            data: { id: '@Model.Id' },
//            success: function (data) {

//                toastr.success('Sikeres megrendelés').position;

//            },
//            error: function () {
//                alert("error");
//            }
//        })
//    }
//    );
//});