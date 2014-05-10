/*
 * class Calc
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Calc {
	public static void Main(string [] args) {
		double x = 1.5, y = 2.5, result;

		result = ((x*x) + (y*y));
		result *= result;

		Console.WriteLine("Result: " + result);
	}  
}