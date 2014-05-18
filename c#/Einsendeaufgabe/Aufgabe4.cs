/*
 * class Aufgabe4
 * @author majewski
 *
 * Description:
 * Beweis des Problem von Collatz
 * für ein x mit 0 < x < 100
 */
using System;

public class Aufgabe4 {
	public static void Main(string [] args) {
		int x = 22, i = 1;

		while(x != 1) {
			if(x%2 == 0) {
				x = x/2;
			}
			else {
				x = (3*x)+1;
			}
			Console.WriteLine(i+". Durchlauf "+x);
			i++;
		}
	}  
}