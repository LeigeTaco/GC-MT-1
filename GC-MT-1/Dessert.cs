using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Dessert:Product
    {
        private string dessert;
        
        public Dessert
        {
            set {dessert = value;}
            get {return dessert;}
        }
        
        Dessert():base()
        {
            Dessert = "churro";
        }
       
        public override void //Method from Main()
        {
            Console.WriteLine("{Dessert}");
        }
        
    }

}


