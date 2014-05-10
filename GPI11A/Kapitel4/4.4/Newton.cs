using System;

public class Newton {
	public static void Main(string [] args) {
		const double N = 0.101972;
		int newton, kp;

		Console.WriteLine("Input N: ");		
		newton = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Input KP: ");
		kp = Int32.Parse(Console.ReadLine());

		Console.WriteLine(
			"KP: " + (newton * N) +  "\n" +
			"N: " + (kp / N) +  "\n"
		);
	}
}