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
       
       public string EntreeType         //Basically, this doesn't like being called the class name, it's confusing it. I'm changing it to entreeType.
       {
            set{entreeType = value;}
            get{return entreeType;}     //return statements don't equal anything. whatever comes after them 
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
