/*
 * class Matrix
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Matrix {
	public static void Main(string [] args) {
		int [,] matrix = new int[3,3];

		matrix[0,0] = 11; matrix[0,1] = 12; matrix[0,2] = 13;

		matrix[1,0] = 21; matrix[1,1] = 22; matrix[1,2] = 23;

		matrix[2,0] = 31; matrix[2,1] = 32; matrix[2,2] = 33;

		Console.WriteLine("{0} {1} {2} \n{3} {4} {5} \n{6} {7} {8}",
			matrix[0,0], matrix[0,1], matrix[0,2], 
			matrix[1,0], matrix[1,1], matrix[1,2],
			matrix[2,0], matrix[2,1], matrix[2,2]);

		for(int i=0;i<2;i++) {
			for(int j=1;j<3;j++) {
				int hilf = matrix[i,j]; // 12
				matrix[i,j] = matrix[j,i];
				matrix[j,i] = hilf;
			}
		}

		Console.WriteLine("\n\n\n{0} {1} {2} \n{3} {4} {5} \n{6} {7} {8}",
			matrix[0,0], matrix[0,1], matrix[0,2], 
			matrix[1,0], matrix[1,1], matrix[1,2],
			matrix[2,0], matrix[2,1], matrix[2,2]);
	}  
}	