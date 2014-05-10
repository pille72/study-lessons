using System;

public class Newton {
	public static void Main(string [] args) {
		const double N = 0.101972;
		int newton, kp;

		Console.WriteLine("Eingabe N: ");		
		newton = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Eingabe KP: ");
		kp = Int32.Parse(Console.ReadLine());

		Console.WriteLine(
			"KP: " + (newton * N) +  "\n" +
			"N: " + (kp / N) +  "\n"
		);
	}
}