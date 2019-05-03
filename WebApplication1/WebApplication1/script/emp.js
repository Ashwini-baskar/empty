//event

$(function() {
    $("btnsubmit"). click(function(){
        var jsondata=JSON.stringify({
            'name':$("#txtname").val(),
            'email':$("#txtemail").val(),
        });
        $.ajax({
            type: "POST",
            url: "sample.asmx/GetPersonData",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function (xhr, status, error) {
                //alert the error if needed
                $("#result").html("Sorry there is an error: " + xhr.responseText);
            },
            success: function (responseData) {
                //show the response data from webservice. Note: the d represent the object property data passed by webservice. It can an object of properties or just single property
                $("#result").html(responseData.d);
            }
        });
    });
});


        