using System;

public class ICALC {
	public static void Main(string [] args) {
		int result;
		if(args[1] == "+") {
			result = Int32.Parse(args[0]) + Int32.Parse(args[1]);
		}

		if(args[1] == "-") {
			result = Int32.Parse(args[0]) - Int32.Parse(args[1]);
		}

		if(args[1] == "*") {
			result = Int32.Parse(args[0]) * Int32.Parse(args[1]);
		}

		if(args[1] == "/") {
			result = Int32.Parse(args[0]) / Int32.Parse(args[1]);
		}

		Console.WriteLine(
			"Result: " + (result) +  "\n"
		);
	}
}