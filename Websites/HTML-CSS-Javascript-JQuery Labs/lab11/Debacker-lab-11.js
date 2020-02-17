"use strict";

// regex expressions
const phoneNumberPattern = /\(\d{3}\)\d{3}[-]\d{4}/
const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.+-]+\.edu$/
const zipCodePattern = /\d{5}[-]\d{4}/
const datePattern = /^(?:(?:0?[13578]|1[02])|(?:0?[469]|11)(?!\/31)|(?:0?2)(?:(?!\/3[01]|\/29\/(?:(?:0[^48]|[13579][^26]|[2468][^048])00|(?:\d{2}(?:0[^48]|[13579][^26]|[2468][^048]))))))\/(?:0?[1-9]|[12][0-9]|3[01])\/(?:0?19|20)\d{2}$/;

$(document).ready(function(){

    // these are the input boxes
    const email = $("#email-address")
    const phone = $("#phone-number")
    const zip = $("#zip-code")
    const dateofbirth = $("#date-of-birth")
    // validate button
    const validate = $("#validate")
    const result = $("#results")

    email.focus()
    // click event
    validate.click(() => {
        //grabs all span elements in body and sets their text to empty
        $('body').find("span").text("")
        // clear result info
        result.text("")
        // is valid 
        let valid = true
        // test email with regex 
        if(!emailPattern.test(email.val())){
            // sets next element's (the span) text
            email.next().text("Please enter a valid email address that ends in .edu.")
            valid = false
        }
        if(!phoneNumberPattern.test(phone.val())){
            phone.next().text("Please enter a phone number in the (999)999-9999 format.")
            valid = false
        }

        if(!zipCodePattern.test(zip.val())){
            zip.next().text("Please enter a valid zip code in the 99999-9999 format.")
            valid = false
        }

        if(!datePattern.test(dateofbirth.val())){
            dateofbirth.next().text("Please enter a valid date in the MM/DD/YYYY format.")
            valid = false
        }

        // checks the date compared to now to see if its before today you could subtract a day from now if you dont want to include todays date
        else if(Date.parse(dateofbirth.val()) > Date.now()){
            dateofbirth.next().text("Please enter a date that was in the past.")
            valid = false
        }
        
        // if valid display message
        if(valid){
            result.text("All fields contain valid entries.")
        }
        email.focus()
    })
})