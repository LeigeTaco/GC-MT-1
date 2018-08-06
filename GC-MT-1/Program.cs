using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace GC_MT_1
{

    class Program
    {
        static void GetPayment(double total)
        {
            //asks for payment typs 
            Console.WriteLine("Please enter your payment type(Cash, Check, or Credit):");
            string payChoice = Console.ReadLine();
           bool  whileBreak = false;
            //do while loop that validates payment type
            do
            {
                if (Regex.IsMatch(payChoice.ToLower(), @"^cash|check|credit$"))
                {
                    whileBreak = true;
                }
                else
                {
                    Console.WriteLine("Please enter one of the valid payment types:");
                    payChoice = Console.ReadLine();
                }

            } while (!whileBreak);

            //once payment type is validated, calls the class
            if (payChoice.ToLower() == "cash")
            {
                PaymentMethod.Cash(total);
            }
            else if (payChoice.ToLower() == "credit")
            {
                PaymentMethod.Credit();
            }
            else if (payChoice.ToLower() == "Check")
            {
                PaymentMethod.Check();
            }
        }

        static string[][] ArrayBuilder1(StreamReader menu)
        {

            List<string> tempList = new List<string>();

            string fileData = "";
            string nextLine = menu.ReadLine();
            do
            {

                fileData += nextLine + "\n";
                tempList.Add(nextLine);
                nextLine = menu.ReadLine();

            } while (nextLine != null);


            List<string[]> temp = new List<string[]>();

            foreach (string item in tempList)
            {

                string[] info = item.Split(',');
                temp.Add(info);

            }

            return temp.ToArray();

        }

        static Product[] ArrayBuilder2(string[][] toProduct)
        {

            List<Product> output = new List<Product>();

            foreach (string[] prod in toProduct)
            {

                //if (prod[1].ToLower() == "appetizer")
                //{

                //    output.Add(new Appetizer(prod));

                //}
                //else if (prod[1].ToLower() == "dessert")
                //{

                //    output.Add(new Dessert(prod));

                //}
                //else if (prod[1].ToLower() == "drink")
                //{

                //    output.Add(new Drink(prod));

                //}
                //else if (prod[1].ToLower() == "entree")
                //{

                //    output.Add(new Entree(prod));

                //}
                //else
                //{

                    //Console.WriteLine($"{prod[0]} Category Unclear, defaulting to Product");
                    output.Add(new Product(prod));

                //}

            }

            return output.ToArray();

        }

        public static int OrderQuantity()
        {

            int userCount = 0;

            do
            {

                Console.WriteLine("How many would you like?");

                try
                {
                    userCount = int.Parse(Console.ReadLine());
                    if (Regex.IsMatch(userCount.ToString(), @"^([1-9]|1[0-2])$"))
                    {
                        return userCount;
                    }
                    else
                    {
                        Console.WriteLine("Please input a valid number:");
                        userCount = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }


            } while (true);

        }

        public static int[] OrderList(Product[] menu)
        {

            int[] receipt = new int[menu.Length];

            for (int i = 0; i < menu.Length; i++)
            {
                receipt[i] = 0;
            }

            bool whileBreak = false;

            byte menuNum = 1;
            foreach (Product f in menu)
            {

                Console.WriteLine($"{menuNum} {f.ToString()}");
                menuNum++;

            }

            do
            {
                string temp = "";
                Console.WriteLine("What would you like to order?:");
                int userChoice = 0;
                int userCount = 0;
                temp = Console.ReadLine();
                bool innerBreak = false;

                do
                {
                    if (Regex.IsMatch(temp, @"[a-zA-Z\s]"))
                    {

                        //do
                        //{

                            for (int i = 0; i < menu.Length; i++)
                            {

                                if (temp.ToLower() == menu[i].FoodName.ToLower())
                                {

                                    userChoice = i + 1;

                                }

                            }
                            if (userChoice > 0)
                            {

                                userCount = OrderQuantity();
                                //innerBreak = true;

                            }
                            else
                            {

                                Console.WriteLine("Entry was not recognized.");
                            temp = Console.ReadLine();

                            }

                        //} while (!innerBreak);

                    }
                    else if (Regex.IsMatch(temp, @"\d"))
                    {

                        try
                        {

                            userChoice = int.Parse(temp);
                            if (userChoice <= menu.Length)
                            {

                                userCount = OrderQuantity();

                            }
                            else
                            {
                                Console.WriteLine("Entry was not recognized.");
                                temp = Console.ReadLine();
                            }


                        }
                        catch (Exception)
                        {

                            

                        }

                    }
                    else
                    {

                        Console.WriteLine("Entry was invalid, try again.");
                        temp = Console.ReadLine();

                    }

                    Console.WriteLine("Would you like to continue ordering?");

                } while (!innerBreak);
                

                #region outtahere
                /*
                try
                {
                    temp = Console.ReadLine();
                    userChoice= int.Parse(temp);
                    userCount = 0;
                    if (Regex.IsMatch(userChoice.ToString(), @"^([1-9]|1[0-2])$"))
                    {

                        userCount = OrderQuantity();

                    }
                    

                }
                catch (FormatException)
                {
                                        
                }
                catch(Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");

                }*/
                #endregion
                


                receipt[userChoice - 1] += userCount;

                Console.WriteLine("Would you like to order another item(Y/N)");
                string yesOrNo = Console.ReadLine();
                if (Regex.IsMatch(yesOrNo, @"^Y|y|yes|Yes$"))
                {

                }
                else if (Regex.IsMatch(yesOrNo, @"^N|n|no|No$"))
                {
                    whileBreak = true;
                }

            } while (!whileBreak);

            return receipt;

        }

        static void PrintReceipt(int[] receipt, Product[] menu)
        {

            double subTotal = 0;
            for (int i = 0; i < receipt.Length; i++)
            {

                if (receipt[i] > 0)
                {

                    Console.WriteLine($"{receipt[i]} {menu[i].FoodName} {receipt[i] * menu[i].FoodPrice:c}");
                    subTotal += receipt[i] * menu[i].FoodPrice;

                }

            }
            Console.WriteLine($"Subtotal: {subTotal:c}");
            Console.WriteLine($"Total: {subTotal * 1.06:c}");

        }

        static void Main(string[] args)
        {

            StreamReader menu = new StreamReader("../../Menu.txt");
            string RESTAURANTNAME = menu.ReadLine();
            Product[] MENU = ArrayBuilder2(ArrayBuilder1(menu));

            double price = 0;
            int[] receipt = OrderList(MENU);
            for (int i = 0; i < MENU.Length; i++)
            {
                price += receipt[i] * MENU[i].FoodPrice;
            }

            PrintReceipt(receipt, MENU);
            PaymentMethod.Cash(price * 1.06);
            
        }

    }

}