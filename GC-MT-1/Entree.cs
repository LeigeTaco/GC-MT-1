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
       
       Entree():base()                  //Have to make this extend the base constructor
       {
            EntreeType = "burrito";
       }

       //Entree(string en):base(fn,fc,fd,fp)      //This needs to be fed the parametes for the base constructor, right now you're only feeding it string en.
       //{
       //     EntreeType = en;
       //}

       //public override void //method from main()

    }

}
