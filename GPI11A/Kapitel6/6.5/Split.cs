/*
 * class Split
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Split {
	public static void Main(string [] args) {
		int number = 42, first, second;

		first = number / 10;
		second = number % 10;

		Console.WriteLine("First: " + first + " Second: " + second);

	}  
}