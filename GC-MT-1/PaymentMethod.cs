using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class PaymentMethod
    {
        public static void Cash(double price)
        {
            double payment = 0;
            do
            {
                try
                {

                    payment = double.Parse(Console.ReadLine());
                    if (payment > price)
                    {

                        Console.WriteLine($"Here is your change of {payment - price:c}");

                    }
                    else if(payment == price)
                    {

                        Console.WriteLine("Thank you for your patronage");

                    }
                    else
                    {

                        Console.WriteLine($"Your payment was not enough, you're short {price - payment:c}");

                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");

                }


            } while (true);


        }

        public static void Credit()
        { }

        public static void Check()
        { }



    }

}
