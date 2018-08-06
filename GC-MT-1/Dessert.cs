using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Dessert:Product
    {
        private string dessertType;
        
        public string DessertType
        {
            set {dessertType = value;}
            get {return dessertType;}
        }
        
        Dessert():base()
        {
            DessertType = "churro";
        }
       
        Dessert(string fn, string fc, string fd, double fp, string ds):base(fn,fc,fd,fp)
        {
           DessertType = ds;
        }
      
        
        //public override void //Method from Main()
        //{
        //    Console.WriteLine("{Dessert}");
        //}
        
    }

}


