using System;

public class Circle {
	public static void Main(string [] args) {
		int radius = Int32.Parse(Console.ReadLine());

		Console.WriteLine(
			"Perimeter: " + (2*Math.PI*radius) +  "\n" +
			"Acreage: " + (Math.PI * (radius*radius) ) + "\n" 
		);
	}
}