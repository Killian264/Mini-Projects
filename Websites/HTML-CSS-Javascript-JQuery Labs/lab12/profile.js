"use strict";
$(document).ready(function () {
    $("#save").click(function () {
        $("span").text("");   // clear any previous error messages
        var isValid = true;   // initialize isValid flag
        var datePattern = /^(?:(?:0?[13578]|1[02])|(?:0?[469]|11)(?!\/31)|(?:0?2)(?:(?!\/3[01]|\/29\/(?:(?:0[^48]|[13579][^26]|[2468][^048])00|(?:\d{2}(?:0[^48]|[13579][^26]|[2468][^048]))))))\/(?:0?[1-9]|[12][0-9]|3[01])\/(?:0?19|20)\d{2}$/;
        var email = $("#email-address").val();
        var phone = $("#phone-number").val();
        var zip = $("#zip-code").val();
        var dateOfBirth = $("#date-of-birth").val();

        if (email === "" || !email.match(/^[\w\.\-]+@[\w\.\-]+\.[a-zA-Z]+$/)) {
            isValid = false;
            $("#email-address").next().text("Please enter a valid email address.");
        }
        if (phone === "" || !phone.match(/^\d{3}-\d{3}-\d{4}$/)) {
            isValid = false;
            $("#phone-number").next().text(
                "Please enter a phone number in 999-999-9999 format.");
        }
        if (zip === "" || !zip.match(/^\d{5}(-\d{4})?$/)) {
            isValid = false;
            $("#zip-code").next().text("Please enter a valid zip code.");
        }
        if (dateOfBirth === "" || !dateOfBirth.match(datePattern)) {
            isValid = false;
            $("#date-of-birth").next().text("Please enter a valid date in MM/DD/YYYY format.");
        }

        if (isValid) {
            // code that saves profile info goes here
            // This is the array
            let profile = [];
            // this takes the values in the addresses and adds it to the array it works more like a map here than an array
            profile["email-address"] = $("#email-address").val();
            profile["phone-number"] = $("#phone-number").val();
            profile["zip-code"] = $("#zip-code").val();
            profile["date-of-birth"] = $("#date-of-birth").val();
            // sessionstorage init
            sessionStorage.profile = "";
            // a for loop to grab the information in the array and move it into the session storage
            for(let i in profile){
                sessionStorage.profile += i + "=" + profile[i] + "|";
            }
            // go to profile page
            location.href = "profile.html";

        }
        $("#email-address").focus();
    });
    // set focus on initial load
    $("#email-address").focus();
});