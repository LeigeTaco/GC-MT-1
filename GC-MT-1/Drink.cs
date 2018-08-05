using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Drink:Product
    {
        private string drinkType;
        
        public string DrinkType         //missing data type
        {
            set {drinkType = value;}
            get {return drinkType;}
        }
        
        Drink()
        {
            DrinkType = "pop";
        }
        
        //Drink(string dr):base(fn,fc,fd,fp)      //Same as Entree constructor
        //{
        //    DrinkType = dr;
        //}
 
        //public override void //Method from Main()
        //{
        //    Console.WriteLine("{Drink}");
        //}
  
    }

}
