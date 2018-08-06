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

                    Console.WriteLine("Product Category Unclear, defaulting to Product");
                    output.Add(new Product(prod));

                //}

            }

            return output.ToArray();

        }



        static void Main(string[] args)
        {

            //PaymentMethod.Cash(20.99);

            StreamReader menu = new StreamReader("../../Menu.txt");
            string RESTAURANTNAME = menu.ReadLine();

            foreach (string[] word in ArrayBuilder1(menu))
            {

                foreach (string word2 in word)
                {

                    Console.Write(word2 + ' ');

                }
                Console.WriteLine();

            }

            double price = 0;
            bool whileBreak = false;

            do
            {
                Console.WriteLine("Input a menu item by number:");
                int userChoice =int.Parse(Console.ReadLine());
                if(Regex.IsMatch(userChoice.ToString(), @"^([1-9]|1[0-2])$"))
                {
                   
                }
                else
                {
                    Console.WriteLine("Please Input a valid number:");
                    userChoice = int.Parse(Console.ReadLine());
                }

                        
                //something here to catalog the users choice and pull its price from the product list
                //price = price + userChoice[index];
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

            //process the order and get the totals here, subtotal, tax, total


            //ask for a payment type and do appropriate actions to refrence the correct class
            Console.WriteLine("Please enter your payment type(Cash, CHeack, or Credit:");
            string payChoice = Console.ReadLine();
            whileBreak = false;
            do
            {
                if(Regex.IsMatch(payChoice.ToLower(), @"^cash|check|credit$"))
                {
                    whileBreak = true;
                }
                else
                {
                    Console.WriteLine("Please enter one of the valid payment types:");
                    payChoice = Console.ReadLine();
                }

            } while (!whileBreak);



           //some sort of possible method here to do the receipt
           //console.write
        }

    }

}