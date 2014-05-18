using System;

public class ICALC {
	public static void Main(string [] args) {
		int ergebnis;
		if(args[1] == "+") {
			ergebnis = Int32.Parse(args[0]) + Int32.Parse(args[1]);
		}

		if(args[1] == "-") {
			ergebnis = Int32.Parse(args[0]) - Int32.Parse(args[1]);
		}

		if(args[1] == "*") {
			ergebnis = Int32.Parse(args[0]) * Int32.Parse(args[1]);
		}

		if(args[1] == "/") {
			ergebnis = Int32.Parse(args[0]) / Int32.Parse(args[1]);
		}

		Console.WriteLine(
			"Ergebnis: " + (ergebnis) +  "\n"
		);
	}
}