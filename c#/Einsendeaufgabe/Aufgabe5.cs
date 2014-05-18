/*
 * class Aufgabe5
 * @author majewski
 *
 * Description:
 * Ausgabe des Tierkreiszeichen durch Eingabe von
 * Tag, Monat
 */
using System;

public class Aufgabe5 {
	public static void Main(string [] args) {
		int tag, monat;
		string zeichen;

		Console.WriteLine("Bitte Tag eingeben: ");
		
		tag = Int32.Parse(Console.ReadLine());
		
		Console.WriteLine("Bitte Monat eingeben: ");
		
		monat = Int32.Parse(Console.ReadLine());

		if( (monat == 12 && tag >= 23) || (monat == 1 && tag <= 19) ) {
			zeichen = "Steinbock";
		} else if ((monat == 1 && tag >= 20) || (monat == 2 && tag <= 19)) {
			zeichen = "Wassermann";
		} else if ((monat == 2 && tag >= 20) || (monat == 3 && tag <= 20)) {
			zeichen = "Fische";
		} else if ((monat == 3 && tag >= 21) || (monat == 4 && tag <= 19)) {
			zeichen = "Widder";
		} else if ((monat == 4 && tag >= 20) || (monat == 5 && tag <= 20)) {
			zeichen = "Stier";
		} else if ((monat == 5 && tag >= 21) || (monat == 6 && tag <= 20)) {
			zeichen = "Zwilling";
		} else if ((monat == 6 && tag >= 21) || (monat == 7 && tag <= 21)) {
			zeichen = "Krebs";
		} else if ((monat == 7 && tag >= 22) || (monat == 8 && tag <= 22)) {
			zeichen = "Löwe";
		} else if ((monat == 8 && tag >= 23) || (monat == 9 && tag <= 22)) {
			zeichen = "Jungfrau";
		} else if ((monat == 9 && tag >= 23) || (monat == 10 && tag <= 22)) {
			zeichen = "Waage";
		} else if ((monat == 10 && tag >= 23) || (monat == 11 && tag <= 21)) {
			zeichen = "Skorpion";
		} else if ((monat == 11 && tag >= 22) || (monat == 12 && tag <= 22)) {
			zeichen = "Schütze";
		} else {
			zeichen = "Fehler";
		}

		Console.WriteLine("Ermitteltes Zeichen: " + zeichen);
	}  
}