using System;

public class Factorial {
	public static void Main(string [] args) {
		int factorial = 1;

		for(int i=2;i<11;i++) {
			factorial = factorial * i;
		}

		Console.WriteLine(
			"Fakultät 10: " + factorial
		);
	}
}