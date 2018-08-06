using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_MT_1
{

    class Entree:Product
    {
       private string entreeType;
       
       public string EntreeType        
       {
            set{entreeType = value;}
            get{return entreeType;}     
       }
       
       Entree():base()                
       {
            EntreeType = "burrito";
       }

       Entree(string fn, string fc, string fd, double fp, string en):base(fn,fc,fd,fp)     
       {     
            EntreeType = en;
       }

       //public override void //method from main()

    }

}
