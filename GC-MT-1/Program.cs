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

        static Product[] ArrayBuilder(StreamReader menu)
        {

            


            List<string> tempList = new List<string>();

            string fileData = "";
            string nextLine = menu.ReadLine();
            while (nextLine != null)
            {

                fileData += nextLine + "\n";
                tempList.Add(nextLine);
                nextLine = menu.ReadLine();

            }

            Console.WriteLine(fileData);

            foreach (string item in tempList)
            {
                
                string[] info = item.Split(',');

            }

        }

        static void Main(string[] args)
        {

            PaymentMethod.Cash(20.99);

            StreamReader menu = new StreamReader("../../Menu.txt");
            string RESTAURANTNAME = menu.ReadLine();

        }

    }

}