var Member = []
//fetch member from database
function LoadMember(element) {
    if (Member.length == 0) {
        //ajax function for fetch data
        $.ajax({
            type: "GET",
            url: '/home/getSpeaker',
            success: function (data) {
                Member = data;
                //render member
                renderMember(element);
            }
        })
    }
    else {
        //render member to the element
        renderMember(element);
    }
}

function renderMember(element) {
    
    var $ele = $(element);
        $ele.empty();
    $ele.append($('<option/>').val('0').text('select'));
    $.each(Member, function (i, val) {
        $ele.append($('<option/>').val(val.memberID).text(val.MemberFirstName));
    })
}

$(document).ready(function () {
    // Add button click event
    $('#add').click(function () {
        //validation and add speakers
        var isAllValid = true)
