/*
 * class Fibonacci
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Fibonacci {
	public static void Main(string [] args) {
		double a1 = 1, a2 = 1, a, sum = 2;
		int i;
		for(i=0; i<40; i++) {
			if(i < 2) {
				Console.WriteLine((i+1) + ". Number: 1");
			}
			else {
				a = a1 + a2;
				Console.WriteLine((i+1) + ". Number: " + a);
				//Console.WriteLine("a1: {0,5} a2: {1, 5} \n", a1, a2);
				a1 = a2;
				a2 = a;				

				sum += a;
			}
		}

		Console.WriteLine("Sum: " + sum);
		Console.WriteLine("AVG: " + sum/i );
	}  
}