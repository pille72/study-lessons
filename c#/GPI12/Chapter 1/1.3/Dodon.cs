/*
 * class Dodon
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Dodon {
	public static void Main(string [] args) {
		bool[] doors = new bool[101];
		int i, j;

		for(i=1;i<101;i++) {
			doors[i] = true;
		}

		for(i=2;i<101;i++) {
			for(j=i;j<101;j=j+i) {
				if(doors[j] == true) {
					doors[j] = false;
				}
				else {
					doors[j] = true;
				}
			}
		}		

		for(i=1;i<101;i++) {
			if(doors[i] == true) {
				Console.WriteLine(i+". Tür: offen");
			}
		}
	}  
}