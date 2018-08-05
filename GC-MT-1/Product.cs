using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (!Regex.IsMatch(value, @"^.\D\S[a-z][A-Z]{1,100}$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    throw new Exception("Item not found. Please try again.");
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
                if (!Regex.IsMatch(value, @"^.\D\S[a-z][A-Z]{1,100}$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    throw new Exception("Item not found. Please try again.");
                }
                else
                {
                    foodcategory = value;
                }
            }
            get { return foodcatagory; }
        }


        public string FoodDescription
        {
            set
            {
                if (!Regex.IsMatch(value, @"^.\D\S[a-z][A-Z]{1,100}$"))   //not digit, no whitespaces, lowerCase or upperCase,1-100char long
                {
                    throw new Exception("Item not found. Please try again.");
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
                if (!Regex.IsMatch(value, @"^[0-9]([.,][0-9]{1,2})?$")) //only show numbers with two decimal places
                {
                    throw new Exception("Not valid.");
                }
                else
                {
                    foodPrice = value;
                }
            }
            get { return foodPrice; }

        }

        //constructors
        //methods   

    }
   
}

                            


