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

            Dictionary<string, int> guide = new Dictionary<string, int>();
            for (int i = 0; i < menu.Length; i++)
            {

                guide.Add(menu[i].FoodName, i + 1);

            }

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
                Console.WriteLine("Input a menu item by number:");
                int userChoice = 0;
                int userCount = 0;
                try
                {
                    temp = Console.ReadLine();
                    userChoice= int.Parse(temp);
                    userCount = 0;
                    if (Regex.IsMatch(userChoice.ToString(), @"^([1-9]|1[0-2])$"))
                    {

                        userCount = OrderQuantity();

                    }
                    else
                    {
                        Console.WriteLine("Please Input a valid number:");
                        userChoice = int.Parse(Console.ReadLine());
                    }

                }
                catch (FormatException)
                {
                    try
                    {
                        userChoice = guide[temp];
                        userCount = OrderQuantity();
                    }
                    catch (Exception f)
                    {
                        Console.WriteLine($"Error: {f.Message}");
                    }
                }
                catch(Exception e)
                {

                    Console.WriteLine($"Error: {e.Message}");

                }
                

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

            //process the order and get the totals here, subtotal, tax, total




            //ask for a payment type and do appropriate actions to refrence the correct class
            PaymentMethod.Cash(price);

            //ask for a payment type and do appropriate actions to refrence the correct class
<<<<<<< HEAD

            //Console.WriteLine("Please enter your payment type(Cash, Check, or Credit):");
            //string payChoice = Console.ReadLine();
            //whileBreak = false;
            //do
            //{
            //    if(Regex.IsMatch(payChoice.ToLower(), @"^cash|check|credit$"))
            //    {
            //        whileBreak = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter one of the valid payment types:");
            //        payChoice = Console.ReadLine();
            //    }

            //} while (!whileBreak);

            //double total = 100;// this is just for test purposes and can be commented out when we store a total.

            //if (payChoice.ToLower() == "cash")
            //{
            //    PaymentMethod.Cash(total);
            //}
            //else if (payChoice.ToLower() == "credit")
            //{
            //    PaymentMethod.Credit();
            //}
            //else if (payChoice.ToLower() == "Check")
            //{
            //    PaymentMethod.Check();
            //}
=======
            double total = 56.75;
            GetPayment(total);
            
>>>>>>> Adjustments to payments




            //PaymentMethod.Cash(price);


           //some sort of possible method here to do the receipt
           //console.write
        }

    }

}