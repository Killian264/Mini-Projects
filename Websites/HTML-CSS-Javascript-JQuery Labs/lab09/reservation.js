$(document).ready(function() {
	var datePattern = /^(?:(?:0?[13578]|1[02])|(?:0?[469]|11)(?!\/31)|(?:0?2)(?:(?!\/3[01]|\/29\/(?:(?:0[^48]|[13579][^26]|[2468][^048])00|(?:\d{2}(?:0[^48]|[13579][^26]|[2468][^048]))))))\/(?:0?[1-9]|[12][0-9]|3[01])\/(?:0?19|20)\d{2}$/;
	var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
	var phonePattern = /^(1\s|1)?((\(\d{3}\))|\d{3})(\-|\s)?(\d{3})(\-|\s)?(\d{4})$/;


	// submit handler you could use a click handler on the submit button as well
	$("#reservation-form").submit((e) => {
		// these trim the values of each of the input
		// I could make variables instead of using $ everytime
		$("#arrival-date").val($("#arrival-date").val().trim())
		$("#nights").val($("#nights").val().trim())
		$("#name").val($("#name").val().trim())
		$("#email").val($("#email").val().trim())
		$("#phone").val($("#phone").val().trim())

		// each of the tests will add 1 to this if they pass and its checked at the end to ensure that it equals 5
		let check = 0;
		// reminder to myself to fix issue isNaN(date) works
		let date = Date.parse($("#arrival-date").val())
		// date checks
		if(!$("#arrival-date").val()){
			$("#arrival-date").next().text("The arrival date is required.");
		}
		// Using the pattern to test the input
		else if(!datePattern.test($("#arrival-date").val())){
			$("#arrival-date").next().text("Must be a valid mm/dd/yyyy date. 1234");
		}
		else if(date < Date.now()){
			$("#arrival-date").next().text("Arrival date must be a future date");
		}
		// all of the elses here add to check and clear error
		else{
			$("#arrival-date").next().text("");
			check++
		}
		// night checks
		if(!$("#nights").val()){
			$("#nights").next().text("This field is required.");
		}
		else if(isNaN($("#nights").val())){
			$("#nights").next().text("Must be a numeric");
		}
		else{
			$("#nights").next().text("");
			check++
		}
		// name checks
		if(!$("#name").val()){
			$("#name").next().text("This field is required.");
		}
		else{
			$("#name").next().text("");
			check++
		}
		// email checks
		if(!$("#email").val()){
			$("#email").next().text("This field is required.");
		}
		else if(!emailPattern.test($("#email").val())){
			$("#email").next().text("Must be a valid email address.");
		}
		else{
			$("#email").next().text("");
			check++
		}
		if(!$("#phone").val()){
			$("#phone").next().text("This field is required.");
		}
		else if(!phonePattern.test($("#phone").val())){
			$("#phone").next().text("Must be in the format 999-999-9999.");
		}
		else{
			$("#phone").next().text("");
			check++
		}
		// prevent default could be moved up to the top and I could use submit but I would have to change the id of the submit button as it causes issues with submit
		if(check !== 5){
			e.preventDefault();
		}
	})


});