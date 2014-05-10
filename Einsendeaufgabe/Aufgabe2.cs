/*
 * class Aufgabe2
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Aufgabe2 {
	public static void Main(string [] args) {
		long z, sum;
		int i;
		// Zeichenkette von der Tastatur lesen
		string zeichenkette = Console.ReadLine();

		// Teilaufgabe a, eingegebene Zeichenkette ausgeben
		Console.WriteLine("Eingegebene Zeichenkette: {0,6}", zeichenkette);

		// Teilaufgabe b, zeichenkette zu long casten und ausgeben
		z = Int64.Parse(zeichenkette);
		Console.WriteLine("Zeichenkette als typ long: {0,6}", z);

		// Teilaufgabe c, zeichenkette als Quersumme berechnen
		
		sum = 0;
		// Zeichenkette Schrittweise zerlegen und addieren
		for(i=0; i<zeichenkette.Length; i++) {
			sum += Int64.Parse(zeichenkette.Substring(i, 1));
		}

		Console.WriteLine("Quersumme {0} : {1,5}", zeichenkette, sum);
	}  
}