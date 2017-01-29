using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawaa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>();

            figury.Add(new Kwadrat(4,4,4,4));
            figury.Add(new Kwadrat(6, 6, 6, 6));
            figury.Add(new Kwadrat(3, 3, 3, 3));
            figury.Add(new Kwadrat(1, 1, 1, 1));
        }
    }
}
