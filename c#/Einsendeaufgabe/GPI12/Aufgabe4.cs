/*
 * class StatCalc
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class StatCalc {
	public double max(double[] werte) {
		int max = 0;
		for(int i=1; i<werte.Length;i++) {
			if(werte[max] < werte[i]) {
				max = i;
			}
		}

		return werte[max];
	}

	public double min(double[] werte) {
		int min = 0;
		for(int i=1; i<werte.Length;i++) {
			if(werte[min] > werte[i]) {
				min = i;
			}
		}

		return werte[min];
	}

	public double[] enter() {
		int anzahl = 0;
		double[] werte;

		Console.WriteLine("Anzahl der Werte: ");
		anzahl = Int32.Parse(Console.ReadLine());
		werte = new double[anzahl];
		for(int i=0; i<anzahl;i++) {
			Console.WriteLine("Eingabe {0}. Wert: ", (i+1) );
			werte[i] = Double.Parse(Console.ReadLine());
		}

		return werte;
	}

	public int anzahl(double[] werte) {
		return werte.Length;
	}

	public double arithmetischesMittel(double[] werte) {
		int n = this.anzahl(werte);
		double sum = 0;
		for(int i=0; i<n; i++) {
			sum += werte[i];
		}

		return sum/n;
	}

	public double standardAbweichung(double[] werte) {
		int n = this.anzahl(werte);
		double mittelWert = this.arithmetischesMittel(werte);
		double sum = 0;
		for(int i=0; i<n; i++) {
			sum += (werte[i] - mittelWert) * (werte[i] - mittelWert);
		}

		return Math.Sqrt(sum/n);
	}

	public static void Main(string [] args) {
		StatCalc stc = new StatCalc();
		double[] werte = stc.enter();

		Console.WriteLine("\nAusgabe: ");
		Console.WriteLine("Max: {0}", stc.max(werte));
		Console.WriteLine("Min: {0}", stc.min(werte));

		Console.WriteLine("Arithmetisches Mittel: {0}", stc.arithmetischesMittel(werte));
		Console.WriteLine("Standard Abweichung: {0}", stc.standardAbweichung(werte));

	}  
}