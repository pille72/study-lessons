/*
 * class FormatNumbers
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class FormatNumbers {
	public static void Main(string [] args) {
		double num1 = Double.Parse(args[0]), num2 = Double.Parse(args[1]), pro;

		pro = num1 * num2;

		Console.WriteLine(
			"3: {0,9:0.###} \n" +
			"6: {0,9:0.######} \n" +
			"12: {0,9:0.############} \n",
			pro
		);
	}  
}