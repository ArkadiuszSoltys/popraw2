using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawaa
{
    class trojkat:Ksztalt
    {



        public trojkat(double a, double b, double c);

      


        public override double ObliczPole()
        {
            return ((1/2)* (p*((p - a) + (p- b)*(p-c))));
        }


    }
}
