// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    $(document).ready(function () {
        $(".AddSpeaker").click(function () {

            alert("in function");
            var txt2 = $("<input></input>").text("add Speaker "); 
            $("#speaker").after(txt2); 
        });
    });



