using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawaa
{
    
        abstract class Ksztalt
    {

        protected double a;
        protected double b;
        protected double c;
        protected double d;
        protected double p;

        public Ksztalt()
        {

        }



        public abstract double ObliczObwod();
        public abstract double ObliczPole();

       
       

        public override string ToString()
        {
            return ("Obwod:" + this.ObliczObwod() + "Pole" + this.ObliczPole()) ;
        }


        


    }
}
