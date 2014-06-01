/*
 * class Resistor
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Resistor {
	public static void Main(string [] args) {
		int[] resistors = new int[5];
		int i, j;

		for(i=0;i<5;i++) {
			Console.WriteLine("{0}. resistor", (i+1));
			resistors[i] = Int32.Parse(Console.ReadLine());
		}

		for(i=0;i<5;i++) {
			for(j=i+1;j<5;j++) {
				Console.WriteLine("R1 {0}\nR2 {1}\nResult: {2}", 
					resistors[i], resistors[j], (resistors[i]+resistors[j]));
			}
		}

	}  
}