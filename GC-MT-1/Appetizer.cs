using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Appetizer:Product
    {
        private string appetizerName;
        
        public AppetizerName
        {
            set {appetizerName = value;}
            get {return appetizerName;}
        }
        
        AppetizerName():base()
        {
            AppetizerName = "salsa";
        }
       
        public override void //Method from Main()
        {
            Console.WriteLine("{AppetizerName}");
        }
        
    }

}
