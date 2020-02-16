$(document).ready(function(){
    // clear entries button event handler
    $("#clear-entries").click(() => {
        // resets error msg to *
        $("#error-message").html("*");
        // grabs all input type text and clears them
        $('#conversion-form input[type="text"]').val('');
        //focuses on degrees-entered
        $("#degrees-entered").focus();
    })
    $("#to-fahrenheit").click(() =>{
        // changes label text
        $("#degrees-top-label").html("Enter Celsius degrees:");
        $("#degrees-bottom-label").html("Fahrenheit equivalent:");
        // triggers clear button event handler
        $("#clear-entries").trigger("click");
    })
    $("#to-celsius").click(() =>{
        // changes label text
        $("#degrees-top-label").html("Enter Fahrenheit degrees:");
        $("#degrees-bottom-label").html("Celsius equivalent:");
        // triggers clear button event handler
        $("#clear-entries").trigger("click");
    })
    $("#convert").click(function () {
        if(isNaN($("#degrees-entered").val())){
            // display error msg
            $("#error-message").html("Entry must be numeric");
            // clear value in case previous is present
            $("#degrees-computed").val("");
        } else if($("#degrees-entered").val() === ""){
            // display error msg
            $("#error-message").html("The field cannot be empty");
            // clear value in case previous is present
            $("#degrees-computed").val("");
        }else{
            // variables 
            let fahrenheit;
            let celsius;
            var radioButton = $(":checked").val();
            if(radioButton === "convert-to-celsius"){
                // get value
                fahrenheit = $("#degrees-entered").val();
                // convert value
                celsius = (fahrenheit - 32) * 5/9;
                // display fixed to 2 decimal place
                $("#degrees-computed").val(celsius.toFixed(2));

            }else if(radioButton === "convert-to-fahrenheit"){
                // get value
                celsius = $("#degrees-entered").val();
                // convert value
                fahrenheit = celsius * 9/5 + 32;
                // display fixed to 2 decimal place
                $("#degrees-computed").val(fahrenheit.toFixed(2));
            }
            // clear error message
            $("#error-message").html("");
        }
        // focus sends focus to top text box and allows continual typing without deleting
        $("#degrees-entered").focus();
        // this allows you to type and delete old text with ease
        $("#degrees-entered").select();
    })
        // double click event handle triggers clear entries event handler
        $("#degrees-entered").dblclick(function() {
            $("#clear-entries").trigger("click")
        });
        // focus on text box 
        $("#degrees-entered").focus();
})