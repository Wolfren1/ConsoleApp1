using System;

namespace Bacon
{
    class Program
    {
        static void Main(string[] args)
        {
            int productID;
            int quantity;
            int i = 0;
            double price;
            double total;
            double discount; 
            double totalWithDiscount;


           
                Console.WriteLine("Enter the product ID:");
                productID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the quantity of the product:");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of the product:");
                price = Convert.ToDouble(Console.ReadLine());
               
            
            if (quantity >= 10 && quantity <= 25)
            {
                discount = 0.1 * quantity;
                total = price * quantity;
                totalWithDiscount = total - discount;
            }
            else if (quantity >= 25 && quantity <= 50)
            {
                discount = 0.25 * quantity;
                total = price * quantity;
                totalWithDiscount = total - discount;
            }
            else if (quantity >= 50)
            {
                discount = 0.5 * quantity;
                total = price * quantity;
                totalWithDiscount = total - discount;
            }
            else
            {
                total = price * quantity;
            }

            Console.WriteLine("The total is "+total+".");
            Console.WriteLine("The total with discount is" + totalWithDiscount + ".");



        }

       
    }
}
