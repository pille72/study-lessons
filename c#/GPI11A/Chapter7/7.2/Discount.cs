/*
 * class Discount
 * @author majewski
 *
 * Description:
 *
 */
using System;

public class Discount {
	public static void Main(string [] args) {
		double price = Double.Parse(Console.ReadLine()), discountAmount;
		int discount = 0;

		if(price < 500) {
			discount = 0;
		} else if(price < 2000) {
			discount = 2;
		} else if(price < 5000) {
			discount = 5;
		}
		else {
			discount = 10;
		}

		discountAmount = (price * discount) / 100;
		Console.WriteLine("Discount: {0:F3}", discountAmount);
	}  
}