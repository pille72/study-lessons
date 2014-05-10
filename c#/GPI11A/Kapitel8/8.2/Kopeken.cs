/*
 * class Kopeken
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Kopeken {
	public static void Main(string [] args) {
		int v, s, z;
		Console.WriteLine("Result: \n");
		for(v=0;v<18; v+=4) {
			for(s=0;s<18; s+=6) {
				for(z=0;z<18; z+=10) {
					if(v+s+z == 18) {
						Console.WriteLine("4s: {0}, 6s {1}, 10s {2}", v/4, s/6, z/10);
					}
				}
			}
		}
	}  					
}