/*
 * class SwitchNumbers
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class SwitchNumbers {
	public static void Main(string [] args) {
		double number1 = Double.Parse(Console.ReadLine()), number2 = Double.Parse(Console.ReadLine()), min, max;

			if(number1 > number2) {
				min = number2;
				max = number1;
			} else {
				min = number1;
				max = number2;
			}

		if(min != 0) {
			Console.WriteLine("Result: " + (max/min));
		}
		else {
			Console.WriteLine("Can't do division by zero!");
		}
	}  
}