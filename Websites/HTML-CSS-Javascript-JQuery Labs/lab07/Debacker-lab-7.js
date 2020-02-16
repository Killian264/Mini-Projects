
clearFunction = () =>{
    document.getElementById("error-message").innerHTML = "*";
    document.getElementById("degrees-entered").value = "";
    document.getElementById("degrees-entered").focus();
    document.getElementById("degrees-computed").value = "";
}

changeToFahrenheit = () =>{
    document.getElementById("degrees-top-label").innerHTML = "Enter Celsius degrees:";
    document.getElementById("degrees-bottom-label").innerHTML = "Fahrenheit equivalent:";
    clearFunction();
}
changeToCelsius = () =>{
    document.getElementById("degrees-top-label").innerHTML = "Enter Fahrenheit degrees:";
    document.getElementById("degrees-bottom-label").innerHTML = "Celsius equivalent:";
    clearFunction();
}
computeTemperature = () =>{
    let fahrenheit;
    let celsius;
    document.getElementById("degrees-computed").value = "";

    if(document.getElementById("to-celsius").checked){
        fahrenheit = parseFloat(document.getElementById("degrees-entered").value);
        if(isNaN(fahrenheit)){
            document.getElementById("error-message").innerHTML = "Please enter a number";
            document.getElementById("degrees-entered").focus();
        }
        else{
            document.getElementById("error-message").value = "*";
            celsius = (fahrenheit - 32) * 5/9;
            document.getElementById("degrees-computed").value = celsius;
        }
    }
    else{
        celsius = parseFloat(document.getElementById("degrees-entered").value);
        if(isNaN(celsius)){
            document.getElementById("error-message").innerHTML = "Please enter a number";
            document.getElementById("degrees-entered").focus();
        }
        else{
            document.getElementById("error-message").value = "*";
            fahrenheit = celsius * 9/5 + 32;
            document.getElementById("degrees-computed").value = fahrenheit;
        }
    }
    
}



onLoad = () =>{
    document.getElementById("degrees-entered").focus();
    document.getElementById("to-celsius").addEventListener("click", changeToCelsius);
    document.getElementById("to-fahrenheit").addEventListener("click", changeToFahrenheit);
    document.getElementById("clear-entries").addEventListener("click", clearFunction);
    document.getElementById("convert").addEventListener("click", computeTemperature)
}

window.onload = onLoad();
