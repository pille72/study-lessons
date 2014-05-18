/*
 * class Aufgabe1
 * @author philip majewski
 *
 * Description:
 * Berechnet die Summe der natürlichen Zahlen
 * im bereich n1 bis n2 (n1 > n2)
 *
 * Dabei werden die Zahlen n1 und n2 vom 
 * User über die Console eingegeben
 */
using System;

public class Aufgabe1 {
	public static void Main(string [] args) {
		int n1, n2, help, i, sum;
		
		// Wiederhole Eingabe, solange n1 < 1
		do {
			Console.WriteLine("Eingabe Zahl 1 (n1): ");
			n1 = Int32.Parse(Console.ReadLine());
		} while(n1 < 1);

		// Wiederhole Eingabe, solange n2 < 1
		do {
			Console.WriteLine("Eingabe Zahl 2 (n2): ");
			n2 = Int32.Parse(Console.ReadLine());
		} while(n2 < 1);
		
		// Tausche n1 und n2, wenn n1 > als n2
		if(n1 > n2) {
			help = n2;
			n2 = n1;
			n1 = help;
			Console.WriteLine("\nTausche n1 mit n2 da n1 > n2");
		}

		Console.WriteLine("\nBerechne die Summe im Bereich {0} bis {1} auf vier verschiedene Arten: ", n1, n2);

		// for-Schleife

		// summe zurücksetzen
		sum = 0;

		for(i=n1; i<n2+1; i++) {
			sum += i; 
		}

		Console.WriteLine("Summe der for-Schleife: " + sum);

		// do-Schleife
		
		// zähler zurücksetzen
		i = n1;

		// summe zurücksetzen
		sum = 0;

		do {
			sum += i;
			i++;
		} while(i < n2 + 1);

		Console.WriteLine("Summe der do-Schleife: " + sum);

		// do while-Schleife		

		// zähler zurücksetzen
		i = n1;

		// summe zurücksetzen
		sum = n1;

		while(i < n2) {
			i++;
			sum += i;
		}

		Console.WriteLine("Summe der while-Schleife: " + sum);
		
		// ohne Schleife

		sum = ( n2 * (n2+1) / 2 ) - ( n1 * ( n1-1 ) / 2  )  ;

		Console.WriteLine("Summe ohne Schleife: " + sum);
	}  
}