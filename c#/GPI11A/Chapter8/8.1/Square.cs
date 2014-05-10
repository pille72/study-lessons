/*
 * class Square
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Square {
	public static void Main(string [] args) {
		int number = 1, help = number * number;

		while(help < 200) {
			Console.WriteLine("Square number: " + help);
			number++;
			help = number * number;
		}
	}  
}