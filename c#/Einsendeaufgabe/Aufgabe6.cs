/*
 * class Aufgabe6
 * @author majewski
 *
 * Description:
 * Heron-Verfahren
 */
using System;

public class Aufgabe6 {
	public static void Main(string [] args) {
		int a, ii;
		// oldX speichert den Wert des letzten X. Beim Start wird der Wert 10 gesetzt
		double x, oldX = 10;

		Console.WriteLine("Startwert = 10");
		for(a = 1; a <= 10; a++) {
			for(ii = 1; ii <= 5; ii++) {
				x = (oldX + (a/oldX)) / 2;
				Console.WriteLine("a("+a+") - x" + ii + " = "+x);
				oldX = x;
			}
			oldX = 10;
		}
	}  
}