/*
 * class Aufgabe1
 * @author majewski
 *
 * Description:
 *
 * Hinweis: Die eingegebene Zahl muss unter 4000 sein
 */
using System;

public class Aufgabe1 {
	public static void Main(string [] args) {
		int input, zahl, count, i = 0, v = 0, x = 0, l = 0, c = 0, d = 0, m = 0;
		string roem = "";

		do {
			Console.WriteLine("Geben Sie eine Zahl < 4000 ein: ");
			input = Int32.Parse(Console.ReadLine());
		} while(input > 4000 || input < 0);

		zahl = input;

		// M abfragen und Anzahl von M in Endergebnis schreiben
		if( (zahl / 1000) > 0 && zahl >= 1000) {
			m = zahl / 1000;
			zahl = zahl - (m*1000);
			for(count=0;count<m;count++) {
				roem += "M";
			}
		}

		// 900 = CM
		if( (zahl < 1000) && zahl >= 900 ) {
			zahl = zahl - 900;
			roem += "CM";
		}

		// D abfragen und Anzahl von D in Endergebnis schreiben
		if( (zahl / 500) > 0 && zahl >= 500){ 
			d = zahl / 500;
			zahl = zahl - (d*500);
			for(count=0;count<d;count++) {
				roem += "D";
			}
		}

		// C abfragen und Anzahl von C in Endergebnis schreiben
		if( (zahl / 100) > 0 && zahl >= 100){ 
			c = zahl / 100;
			zahl = zahl - (c*100);
			if(c == 4) {
				roem += "CD";
			}
			else {
				for(count=0;count<c;count++) {
					roem += "C";
				}
			}
		}

		// 90 = XC
		if( (zahl < 100) && (zahl >= 90) && (zahl / 90) >= 0 ) {
			zahl = zahl - 90;
			roem += "XC";
		}

		// L abfragen und Anzahl von L in Endergebnis schreiben
		if( (zahl / 50) > 0 && zahl >= 50){ 
			l = zahl / 50;
			zahl = zahl - (l*50);
			for(count=0;count<l;count++) {
				roem += "L";
			}
		}

		// X abfragen und Anzahl von X in Endergebnis schreiben
		if( (zahl / 10) > 0 && zahl >= 10){ 
			x = zahl / 10;
			zahl = zahl - (x*10);
			if(x == 4) {
				roem += "XL";
			}
			else {
				for(count=0;count<x;count++) {
					roem += "X";
				}
			}
		}

		// 9 = IX
		if( (zahl < 10) && (zahl >= 9) ) {
			zahl = zahl - 9;
			roem += "IX";
		}

		// V abfragen und Anzahl von V in Endergebnis schreiben
		if( (zahl / 5) > 0 && zahl >= 5){ 
			v = zahl / 5;
			zahl = zahl - (v*5);
			for(count=0;count<v;count++) {
				roem += "V";
			}
		}

		// I abfragen und Anzahl von I in Endergebnis schreiben
		if( (zahl / 1) >= 0){ 
			i = zahl / 1;
			zahl = zahl - (i*1);
			if(i == 4) {
				roem += "IV";
			}
			else {
				for(count=0;count<i;count++) {
					roem += "I";
				}
			}
		}

		Console.Write("\nErgebnis {0} -> {1}", input, roem);
		Console.WriteLine("\n");
	}  
}