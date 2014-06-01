/*
 * class TenArray
 * @author majewski
 *
 * Description:
 * Reads ten numbers, prints them backwards to screen
 */
using System;

public class TenArray {
	public static void Main(string [] args) {
		int[] myArray = new int[10];
		int i;
		for(i=0;i<10;i++) {
			Console.WriteLine((i+1)+". Number: ");
			myArray[i] = Int32.Parse(Console.ReadLine());
		}

		for(i=9;i>=0;i--) {
			Console.WriteLine( (i+1) + ". Number {0,3}", myArray[i]);
		}
	}  
}