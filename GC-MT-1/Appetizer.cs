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
        
        AppetizerName()
        {
            AppetizerName = "salsa";
        }
        
        AppetizerName(string app):base(fn,fc,fd,fp)
        {
            Appetizer = app;
        }
       
        public override void //Method from Main()
        {
            Console.WriteLine("{AppetizerName}");
        }
        
    }

}
