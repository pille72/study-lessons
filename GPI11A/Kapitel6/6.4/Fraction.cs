/*
 * class Fraction
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Fraction {
	public static void Main(string [] args) {
		double x = 2, y = 5, a;

		a = (x + 1/ ( x + 1 / ( x + 1 / (x + 1 / y ) ) ) );

		Console.WriteLine("Result: {0,4:F}", a);
	}  
}