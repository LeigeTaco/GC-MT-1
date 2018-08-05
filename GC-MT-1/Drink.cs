using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Drink:Product
    {
        private string drink;
        
        public Drink
        {
            set {drink = value;}
            get {return drink;}
        }
        
        Drink()
        {
            Drink = "pop";
        }
        
        Drink(string dr):base(fn,fc,fd,fp)
        {
            Drink = dr;
        }
 
        public override void //Method from Main()
        {
            Console.WriteLine("{Drink}");
        }
  
    }

}
