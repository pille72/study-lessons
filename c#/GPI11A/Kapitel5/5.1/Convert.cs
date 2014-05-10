using System;

public class Convert {
	public static void Main(string [] args) {
		int number;

		Console.WriteLine("Input Number: ");		
		number = 123456789;//Int32.Parse(Console.ReadLine());

		Console.WriteLine(
			"Bin: " + Convert.ToString(number, 2) + "\n" +
			"Hex: " + Convert.ToString(number, 16) + "\n" +
			"Oktal: "+ Convert.ToString(number, 8) + "\n"
		);
	}
}