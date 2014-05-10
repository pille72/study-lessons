using System;

public class Calc {
	public static void Main(string [] args) {
		double a = 1.2345, b = 5.678;
		Console.WriteLine(
			"Summe: " + (a+b) +  "\n" +
			"Differenz: " + (a-b) + "\n" +
			"Produkt: " + (a*b) + "\n" +
			"Quotient: " + (a/b) + "\n"
		);
	}
}