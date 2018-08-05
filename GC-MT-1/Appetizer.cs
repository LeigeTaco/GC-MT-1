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
        
        public string AppetizerName
        {
            set {appetizerName = value;}
            get {return appetizerName;}
        }
        
        Appetizer():base()
        {
            AppetizerName = "salsa";
        }
        
        Appetizer(string fn, string fc, string fd, double fp, string app):base(fn,fc,fd,fp)
        {
            AppetizerName = app;
        }
       
        //public override void //Method from Main()
        //{
        //    Console.WriteLine("{AppetizerName}");
        //}
        
    }

}
