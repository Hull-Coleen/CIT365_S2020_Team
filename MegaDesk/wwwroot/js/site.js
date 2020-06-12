// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $("input:radio[name=test]").change(function () {
        var value = $(this).val();
        if (value == 1) {
            document.getElementById("myImg").src = "/images/Rosewood.jpg";
        }
        else if (value == 2) {
            document.getElementById("myImg").src = "/images/laminate.jpg";
        }
        else if (value == "3") {
            document.getElementById("myImg").src = "/images/oak.jpg";

        }
        else if (value == '4') {
            document.getElementById("myImg").src = "/images/pinejpg.jpg";
        }
        else if (value == "5") {
            document.getElementById("myImg").src = "/images/venner.jpg";

        }
    });
});
function update() {
    var size = 0;
    var ship = 0;
    var cost = document.getElementsByName("DeskQuote.Cost")[0];
    var drawer = document.getElementsByName("DeskQuote.DrawerNumber")[0].value;
    var material = document.getElementsByName("DeskQuote.Material")[0].value;
    var width = document.getElementsByName("DeskQuote.Width")[0].value;
    var depth = document.getElementsByName("DeskQuote.Depth")[0].value;
    var shipping = document.getElementsByName("DeskQuote.Shipping")[0].value;
    if (shipping == "7") {
        if (width * depth > 2000)
            ship = 40;
        else if (width * depth <= 2000 && width * depth >= 1000)
            ship = 35;
        else
            ship = 30;
    }
    else if (shipping == "5") {
        if (width * depth > 2000)
            ship = 60;
        else if (width * depth <= 2000 && width * depth >= 1000)
            ship = 50;
        else
            ship = 40;
    }
    else if (shipping == "3") {
        if (width * depth > 2000)
            ship = 80;
        else if (width * depth <= 2000 && width * depth >= 1000)
            ship = 70;
        else
            ship = 60;
    }
    else
        ship = 0;

    if ((width * depth) > 1000) {
        size = width * depth - 1000;
    }
    else
        size = 0;
    var materialCost = 0;
    if (material == "Pine") {
        document.getElementById("myImg").src = "/images/pinejpg.jpg";
        materialCost = 50;
    }
    else if (material == "Laminate") {
        document.getElementById("myImg").src = "/images/laminate.jpg";
        materialCost = 100;
    }
    else if (material == "Veneer") {
        document.getElementById("myImg").src = "/images/venner.jpg";
        materialCost = 125;
    }
    else if (material == "Oak") {
        document.getElementById("myImg").src = "/images/oak.jpg";
        materialCost = 200;
    }
    else if (material == "Rosewood") {
        document.getElementById("myImg").src = "/images/Rosewood.jpg";
        materialCost = 300;
    }
    cost.value = 200 + size + (drawer * 50) + materialCost + ship;

}

$(document).ready(function () {
    $('input[name$="DeskQuote.Width"]').change(function () {

        update();
    });
});
$(document).ready(function () {
    $('input[name$="DeskQuote.Depth"]').change(function () {

        update();
    });
});
$(document).ready(function () {

    $("#material").change(function () {

        update();
    });
});
$(document).ready(function () {
    $("#drawer").change(function () {

        update();
    });
});
$(document).ready(function () {
    $("#ship").change(function () {

        update();
    });
});
