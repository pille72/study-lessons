/*
 * class MergeArray
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class MergeArray {
	public static void Main(string [] args) {
		int[] IA = {1,3,7,31,45,86}, IB = {2,5,6,17,39,72}, IC = new int[12];
		int i;


		for(i=0;i<6; i++) {
			if(IA[i] < IB[i]) {
				IC[2*i] = IA[i];
				IC[2*i+1] = IB[i];
			}
			else {
				IC[2*i] = IB[i];
				IC[2*i+1] = IA[i];	
			}
		}

		Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
			IC[0], IC[1], IC[2], IC[3], IC[4], IC[5], IC[6], IC[7], IC[8], IC[9], IC[10], IC[11]);
	}  
}