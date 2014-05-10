using System;

public class ICALC {
	public static void Main(string [] args) {
		int ergebnis = 0;
		if(args[1] == "+") {
			ergebnis = Int32.Parse(args[0]) + Int32.Parse(args[2]);
		}

		if(args[1] == "-") {
			ergebnis = Int32.Parse(args[0]) - Int32.Parse(args[2]);
		}

		if(args[1] == "*") {
			ergebnis = Int32.Parse(args[0]) * Int32.Parse(args[2]);
		}

		if(args[1] == "/") {
			ergebnis = Int32.Parse(args[0]) / Int32.Parse(args[2]);
		}

		Console.WriteLine(
			"Ergebnis: " + (ergebnis) +  "\n"
		);
	}
}