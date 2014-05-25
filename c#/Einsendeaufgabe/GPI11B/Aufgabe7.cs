/*
 * class Aufgabe7
 * @author majewski
 *
 * Description:
 * Ostern nach Gauß
 */
using System;

public class Aufgabe7 {
	public static void Main(string [] args) {
		int jahr, k, m, s, a, d, r, og, sz, oe, osterSonntag;

		Console.WriteLine("Bitte geben Sie ein Jahr an: ");
		jahr = Int32.Parse(Console.ReadLine());

		k = jahr / 100;
		m = 15 + ( ( ( 3 * k ) + 3 ) / 4 ) - ( ( 8 * k + 13 ) / 25 );
		s = 2 - ( ( ( 3 * k ) + 3 ) / 4 );
		a = jahr % 19;
		d = ( ( 19 * a ) + m ) % 30;
		r = ( d / 29 ) + ( ( d / 28 ) - ( d / 29 ) ) * ( a / 11 );
		og = 21 + d - r;
		sz = 7 - ( ( ( jahr + ( jahr / 4 ) + s) ) % 7);
		oe = 7 - ( ( og - sz ) % 7 );

		osterSonntag = og + oe;

		if(osterSonntag > 31) {
			osterSonntag -= 31;
			Console.WriteLine("Ostern "+jahr+" ist am: "+osterSonntag+". April");
		}
		else {
			Console.WriteLine("Ostern "+jahr+" ist am: "+osterSonntag+". März");
		}
	}  
}