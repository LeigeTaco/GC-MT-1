using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GC_MT_1
{
    class Product

    {
        //fields to represent data
        string foodName;
        string foodCategory;
        string foodDescription;
        double foodPrice;

        //properties
        public string FoodName
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    
                }
                else
                {
                    foodName = value;
                }
            }
            get { return foodName; }

        }


        public string FoodCategory
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    
                }
                else
                {
                    foodCategory = value.Trim();
                }
            }
            get { return foodCategory; }
        }


        public string FoodDescription
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    
                }
                else
                {
                    foodDescription = value;
                }
            }
            get { return foodDescription; }

        }

        public double FoodPrice
        {
            set
            {
                foodPrice = value;
            }
            get { return foodPrice; }

        }
        //constructors
        //default

        public Product()
        {
            FoodName = "names";
            FoodCategory = "appetizer, entree, drink";
            FoodDescription = "this is food";
            FoodPrice = 2.99;
        }
        //overload

        public Product(string fn, string fc, string fd, double fp)
        {
            FoodName = fn;
            FoodCategory = fc;
            FoodDescription = fd;
            FoodPrice = fp;
        }

        public Product(string[] arr)
        {

            FoodName = arr[0];
            FoodCategory = arr[1];
            FoodDescription = arr[2];            

            try
            {

                FoodPrice = double.Parse(arr[3]);

            }
            catch (Exception)
            {

                Console.WriteLine("Price invalid, defaulting to $2.99");
                FoodPrice = 2.99;

            }
           

        }

        public override string ToString()
        {
            return $"{FoodCategory} {FoodName} {FoodDescription} {FoodPrice}";
        }
        //methods   
        //public virtual void //Method from Main()          //No method name given here. Looks like you're trying to override ToString().
        //{                                                 //
        //    ConsoleWriteLine("{Product}");                //cw($"{variableName}")
        //}                                                 //
        //Imma let you fix this, but ask questions about anything you aren't sure on.
    }
   
}

                            


