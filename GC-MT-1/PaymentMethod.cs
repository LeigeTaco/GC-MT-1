﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class PaymentMethod
    {
        //taking and Validating cash payments
        public static void Cash(double price)
        {
            double payment = 0;
            do
            {
                Console.WriteLine("Enter your payment amount:");
                try
                {

                    payment = double.Parse(Console.ReadLine());
                    if (payment > price)
                    {

                        Console.WriteLine($"Here is your change of {payment - price:c}");
                        return;

                    }
                    else if (payment == price)
                    {

                        Console.WriteLine("Thank you for your patronage");
                        return;

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
        //taking and validating credit payments
        public static void Credit()
        {
            Console.WriteLine("Input your credit card number:");
            string credCard = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)

                    break;
                else if (key.Key == ConsoleKey.Backspace && credCard.Length > 0)
                {
                    credCard = credCard.Substring(0, credCard.Length - 1);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(' ');
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }

                else
                {
                    credCard += key.KeyChar;
                    Console.Write("*");
                }
            }
                Console.WriteLine();
            

                //Console.WriteLine("Input your credit card number:");
                string cvv = "";
                int cvvLength = 0;



                bool whileBreak = false;
                do
                {
                    try
                    {

                        credCard = credCard.Trim(' ');
                        if (Regex.IsMatch(credCard, @"^4[0-9]{12}(?:[0-9]{3})?$"))
                        {

                            Console.WriteLine("You have entered a Visa Card");
                            cvvLength = 3;
                            whileBreak = true;

                        }
                        else if (Regex.IsMatch(credCard, @"^3[47][0-9]{13}$"))
                        {

                            Console.WriteLine("You have entered an American Express");
                            cvvLength = 4;
                            whileBreak = true;

                        }
                        else if (Regex.IsMatch(credCard, @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$"))
                        {

                            Console.WriteLine("You have entered a Diners Club Card");
                            cvvLength = 3;
                            whileBreak = true;

                        }
                        else if (Regex.IsMatch(credCard, @"^6(?:011|5[0-9]{2})[0-9]{12}$"))
                        {

                            Console.WriteLine("You have entered a Discover Card");
                            cvvLength = 3;
                            whileBreak = true;

                        }
                        else if (Regex.IsMatch(credCard, @"^(?:2131|1800|35\d{3})\d{11}$"))
                        {

                            Console.WriteLine("You have entered a JBC card");
                            cvvLength = 3;
                            whileBreak = true;

                        }
                        else if (Regex.IsMatch(credCard, @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$"))
                        {
                            Console.WriteLine("You have entered a MasterCard");
                            cvvLength = 3;
                            whileBreak = true;
                        }


                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                while (!whileBreak);

                whileBreak = false;
                //Console.WriteLine("Please enter your CVV:");
                Console.WriteLine("Input your CVV number:");
                string cvvNum = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)

                    break;
                else if (key.Key == ConsoleKey.Backspace && credCard.Length > 0)
                {
                    credCard = credCard.Substring(0, credCard.Length - 1);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(' ');
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }

                else
                {
                    cvvNum += key.KeyChar;
                    Console.Write("*");
                }
            }
            Console.WriteLine();
                do
                {


                    try
                    {
                        // string cvvNum = Console.ReadLine();
                        if (cvvNum.Length != cvvLength)
                        {
                            Console.WriteLine("Please re-enter your CVV:");
                        }

                        if (cvvLength == 3)
                        {
                            if (Regex.IsMatch(cvvNum, @"^(\d{3})$"))
                            {
                                whileBreak = true;
                            }
                            else
                            {
                                Console.WriteLine("Please re-enter a 3 digit CVV:");
                            cvvNum = Console.ReadLine();
                            }

                        }

                        else if (cvvLength == 4)
                        {
                            if (Regex.IsMatch(cvvNum, @"^(\d{4})$"))
                            {
                                whileBreak = true;
                            }
                            else
                            {

                                Console.WriteLine("Please re-enter a 4 digit CVV:");
                            cvvNum = Console.ReadLine();
                            }
                        }


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }


                }
                while (!whileBreak);

                whileBreak = false;
                Console.WriteLine("Please enter your expiration date(mm/yy):");
                string expDate = "";
                do
                {
                    try
                    {
                        expDate = Console.ReadLine();
                        if (Regex.IsMatch(expDate, @"^[01][0-9]/[0-9]{2}$"))
                        {
                            whileBreak = true;
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }

                } while (!whileBreak);
            
            Console.WriteLine("Thank you for your payment, Have a nice day!!!");



            }
            //taking and validating check payments
            public static void Check()
            {
                //when asking for the check number i think it is only 4 numbers.
                Console.WriteLine("Please enter your check number:");
                do
                {
                    try
                    {
                        string checkNum = Console.ReadLine();
                        if (Regex.IsMatch(checkNum, @"^\d{4}$"))
                        {
                            Console.WriteLine("Payment Processing:");
                            return;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }

                } while (true);





            }

        }


    
}
