/*
 * class Term
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Term {
	public static void Main(string [] args) {
		double x = 1.75, y = 0.75, z = 5.0, a = 0;

		a = (x+y-z) / (2*x + y*y - x*y*z);

		Console.WriteLine("Result: {0:0.#} ", a);
	}  
}