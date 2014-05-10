using System;

public class Milage {
	public static void Main(string [] args) {
		double kilometer, gas, milage;

		kilometer = Int32.Parse(Console.ReadLine());
		gas = Int32.Parse(Console.ReadLine());

		milage = (100 * gas) / kilometer;
		Console.WriteLine(
			"Verbrauch: " + milage
		);
	}
}