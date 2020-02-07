//package edu.dsu.CIS340;
import java.text.DecimalFormat;

import java.math.BigDecimal;
import java.util.Scanner;

public class Payments {

    // format for decimals print
    private static DecimalFormat df = new DecimalFormat("0.00");

    public static void main(String[] args) {
        double loanAmount, annualInterestRate, vehiclePrice, salesTax;
        int months = 0;

        Scanner input = new Scanner(System.in);

        // read in all information needed
        System.out.println("Please enter the following numbers. Do not add any other characters.");
        System.out.println("Loan Amount: ");
        loanAmount = input.nextDouble();
        System.out.println("Interest Rate");
        annualInterestRate = input.nextDouble();
        System.out.println("Months");
        months = input.nextInt();

        // Bonus information
        System.out.println("Total Sales Price of Vehicle: ");
        vehiclePrice = input.nextDouble();
        System.out.println("Sales Tax Percentage: ");
        salesTax = input.nextDouble();

        // interest rate
        double interestRateFixed = annualInterestRate / 100;
        // numerator of calculations -- this wont change
        double numerator = loanAmount * (interestRateFixed/12);
        // variables used below
        double output, denominator;
        // info print
        System.out.println("Loan amount: " + df.format(loanAmount) + " with interest rate: " + annualInterestRate + " %.");
        // make denominator for this number of months
        denominator = Math.pow((1+(interestRateFixed/12)), -(months/2));
        denominator = 1-denominator;
        // divide to get output
        output = numerator/denominator;
        // output print
        System.out.println("Expact a payment of: $" + df.format(output) + " for " + months/2 + " months.");

        // same as above
        denominator = Math.pow((1+(interestRateFixed/12)), -months);
        denominator = 1-denominator;
        output = numerator/denominator;
        System.out.println("Expact a payment of: $" + df.format(output) + " for " + months + " months.");

        // same as above
        denominator = Math.pow((1+(interestRateFixed/12)), -(months*2));
        denominator = 1-denominator;
        output = numerator/denominator;
        System.out.println("Expact a payment of: $" + df.format(output) + " for " + months*2 + " months.");

        // do second one again with months entered to get total tax amount
        denominator = Math.pow((1+(interestRateFixed/12)), -months);
        denominator = 1-denominator;
        output = numerator/denominator * months;
        // get salex tax and vehicle cost information for print
        double vehicleSalesTax = vehiclePrice * (salesTax/100);
        double totalVehicleCost = vehicleSalesTax + output - loanAmount + vehiclePrice;
        System.out.println("Total price of car including sales tax and loan tax: " + df.format(totalVehicleCost));

    }
}
