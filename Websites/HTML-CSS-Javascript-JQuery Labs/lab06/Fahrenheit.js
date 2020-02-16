
// arrow function
convertFunc = () => {
    let fahrenheit;
    do{
        fahrenheit = prompt("Enter Fahrenheit temperature:");
        if(isNaN(fahrenheit) || fahrenheit > 212 || fahrenheit < -100){
            alert("You entered: " + fahrenheit + "\nPlease enter a number in the range of -100 to 212.")
        }
        else{
            let celsius = (parseFloat(fahrenheit) - 32) * 5/9;
            // the extra concatenation between the html elements is not needed I just have it for readability
            document.body.innerHTML = "<h1>Fahrenheit converted to Celsius</h1>" + "<p>Temperature in Fahrenheit: " + fahrenheit + "</p>" + "<p>Temperature in Celsius: "+ celsius + "</p>";
        }
    }
    while(isNaN(fahrenheit) || fahrenheit > 212 || fahrenheit < -100)
}

convertFunc();