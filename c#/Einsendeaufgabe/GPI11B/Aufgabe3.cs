/*
 * class Aufgabe3
 * @author majewski
 *
 * Description:
 * Ändern der Programmstruktur mit switch
 */
using System;

public class Aufgabe3 {
	public static void Main(string [] args) {
		int zahl;
		bool schleifeLaueft = true;

		while(schleifeLaueft) {
			Console.WriteLine("Bitte wählen Sie (1,2,3"
				+ " oder 9 für Ende): ");

			zahl = Int32.Parse(Console.ReadLine());
			switch(zahl) {
				case 1:	Console.WriteLine("Die Zahl ist 1");
					break;
				case 2: Console.WriteLine("Die Zahl ist 2");
					break;
				case 3: Console.WriteLine("Die Zahl ist 3");
					break;
				case 9: schleifeLaueft = false;
					break;
				default:
				  Console.WriteLine("Falsche Eingabe! Bitte wiederholen!");
				  break;
			}
		}
		Console.WriteLine("Programm-Ende.");
	}  
}