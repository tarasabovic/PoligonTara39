using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonTara39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tara Sabovic
            // Tacka prva = new Tacka();
            // Console.WriteLine(prva.d());
            //Tacka A = new Tacka(1, 2);
            //Tacka B = new Tacka(2, 3);
            //Vektor AB = new Vektor(A, B);
            //Tacka C = AB.Centriraj();
            //Console.WriteLine(C.d());
            Tacka A = new Tacka(3,2);
            Tacka B = new Tacka(-2,3);
            Tacka O = new Tacka();
            Vektor OA = new Vektor(O, A);
            Vektor OB = new Vektor(O, B);
            Console.WriteLine(Vektor.SP(OA, OB));
        }
    }
}
