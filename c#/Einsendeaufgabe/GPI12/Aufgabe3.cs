/*
 * class Caesar
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Caesar {
	private char[] alphabet = {
		'a', 'b', 'c', 'd', 'e', 'f', 'g', 
		'h', 'i', 'j', 'k', 'l', 'm', 'n', 
		'o', 'p', 'q', 'r', 's', 't', 'u', 
		'v', 'w', 'x', 'y', 'z'
	};

	public string verschluesseln(string wort, int key) {
		int i, index;
		char[] zeichen = wort.ToCharArray(),
		verschluesselt = new char[wort.Length];

		for(i=0;i<zeichen.Length;i++) {
			index = Array.IndexOf(this.alphabet, Char.ToLower(zeichen[i]));
			if(index + key <= 24) {
				verschluesselt[i] = this.alphabet[index + key];
			}
			else {
				verschluesselt[i] = this.alphabet[(index + key) - 25];	
			}

			if(Char.IsUpper(zeichen[i]) == true) {
				verschluesselt[i] = Char.ToUpper(verschluesselt[i]);
			}
		}

		return new string(verschluesselt);
	}
	
	public string entschluesseln(string wort, int key) {
		int i, index;
		char[] zeichen = wort.ToCharArray(),
		entschluesselt = new char[wort.Length];

		for(i=0;i<zeichen.Length;i++) {
			index = Array.IndexOf( this.alphabet, Char.ToLower(zeichen[i]) );

			if(index - key >= 0) {
				entschluesselt[i] = this.alphabet[index - key];
			}
			else {
				// Index geht ins negative, also von 25 abziehen, aber vorher dafür sorgen,
				// dass der zweite Term positiv (* -1) ist, sonst wird -- = +
				entschluesselt[i] = this.alphabet[25 - ((index - key)* -1)];	
			}

			if(Char.IsUpper(zeichen[i]) == true) {
				entschluesselt[i] = Char.ToUpper(entschluesselt[i]);
			}
		}

		return new string(entschluesselt);
	}

	public static void Main(string [] args) {
		string wort, verschluesselt, entschluesselt;
		int key;

		Console.WriteLine("Eingabe Wort: ");
		wort = Console.ReadLine();

		Console.WriteLine("Eingabe Schlüssel: ");
		key = Int32.Parse(Console.ReadLine());

		Caesar c = new Caesar();

		verschluesselt = c.verschluesseln(wort, key);
		Console.WriteLine("\n\nVerschlüsselt: {0} ({1}) -> {2}", wort, key, verschluesselt);

		entschluesselt = c.entschluesseln(verschluesselt, key);
		Console.WriteLine("Entschlüsselt: {0} ({1}) -> {2}\n", verschluesselt, key, entschluesselt);

		if(entschluesselt == wort ) {
			Console.WriteLine("\nDie Verschlüsselung / Entschlüsselung funktioniert!\n");
		}
	}  
}