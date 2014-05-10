/*
 * class Multiply
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Multiply {
	public static void Main(string [] args) {
		int number = Int32.Parse(Console.ReadLine()), res1, res2, res3, res4;

		res1 = number * 4;
		res2 = number + number + number + number;
		res3 = number << 2;
		res4 = number + number;
		res4 += res4;

		Console.WriteLine("Results {0}, {1}, {2}, {3} ", res1, res2, res3, res4);
	}  
}