/*
 * class Radio
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Radio {
	// Aufgabe b: 
	// eingeschaltet als boolean, da es nur die Zustände eingeschaltet/ausgeschaltet gibt
	// lautstärke als int, da hier fließkommazahlen kein Sinn machen und die meisten
	// radios einen wert in % (zw. 0-100) vorgeben
	private bool eingeschaltet = false;
	

	// Aufgabe d:
	// Hier ist unbedingt `private` zu verwenden, da nur ein Wert zwischen 0-100 erlaubt ist.
	// Eine falsche eingabe von außen z.B. 101.5 würde den Wertebereich des Datentyps `short`
	// übersteigen und einen Fehler verursachen. Die Funktionen `leiser` und `lauter`
	// haben demnach eine Fehlerüberprüfung eingebaut, die überprüft, dass der Wertebereich
	// nicht überschritten wird
	private int lautstaerke = 0;
	private double frequenz = 0.0;

	public Radio() {}

	public Radio(double frequenz) {
		this.frequenz = frequenz;
	}

	// Aufgabe c I:
	public void lauter() {
		this.lautstaerke += (this.lautstaerke+10 <= 100) ? 10 : 0;
	}

	// Aufgabe c I:
	public void leiser() {
		this.lautstaerke -= (this.lautstaerke-10 >= 0) ? 10 : 0;
	}

	// Aufgabe c II:
	// Ich nehme an hier soll der Wert von `eingeschaltet` verändert werden
	// ansonsten hätte ich hier den Namen `istAn()` vermutet!!!
	public void an() {
		this.eingeschaltet = true;
		Console.WriteLine("Radio ist eingeschaltet (an)");
	}

	// Aufgabe c II:
	// Ich nehme an hier soll der Wert von `eingeschaltet` verändert werden
	// ansonsten hätte ich hier den Namen `istAus()` vermutet!!!
	public void aus() {
		this.eingeschaltet = false;
		Console.WriteLine("Radio ist ausgeschaltet (aus)");
	}

	// Aufgabe c III:
	public void waehleSender(double frequenz) {
		this.frequenz = frequenz;
	}

	// Aufgabe c III:
	public string ausgabe() {
		string status = (this.eingeschaltet == true) ? "an" : "aus";
		return "Radio "+status+": Freq: "+this.frequenz.ToString()+", Laut: "+this.lautstaerke.ToString();
	}

	public static void Main(string [] args) {
		// kleiner Test
		Radio radio1 = new Radio();
		radio1.an();
		Console.WriteLine(radio1.ausgabe() + "\n");
		radio1.lauter();
		radio1.lauter();
		radio1.lauter();
		Console.WriteLine(radio1.ausgabe() + "\n");
		radio1.leiser();
		Console.WriteLine(radio1.ausgabe() + "\n");
		radio1.waehleSender(117.5);
		Console.WriteLine(radio1.ausgabe() + "\n");

		Radio radio2 = new Radio(114.5);
		radio2.an();
		Console.WriteLine(radio2.ausgabe() + "\n");
	}  
}