/*
 * class RandomCount
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class RandomCount {
	public static void Main(string [] args) {
		int[] numbers = new int[1000];
		int even = 0, odd = 0, zero = 0;
		Random myObject = new Random();

		for(int i=0;i<1000;i++){
			numbers[i] = myObject.Next(0,100);
			if(numbers[i] == 0) {
				zero++;
			}
			else if(numbers[i] % 2 == 0) {
				even++;
			}
			else {
				odd++;
			}

			//Console.WriteLine("{0} - {1}", i, numbers[i]);
		}

		Console.WriteLine("odd: {0}, even: {1}, zero: {2} ", odd, even, zero);
	}  
}