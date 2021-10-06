using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class ClassStart
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("tere tulemast");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Hi," + eesnimi);
            if (eesnimi.ToLower()=="juku")
            {
                Console.WriteLine("go v kino");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 || vanus > 120)
                {
                    Console.WriteLine("viga andmetega!");
                }
                else if (vanus < 6)
                {
                    Console.WriteLine("Tasuta pilet");
                }
                else if (vanus > 6 && vanus <= 14)
                {
                    Console.WriteLine("lastepilet");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kogus pole");
            }
            if (name1.tolower() == "artem" && name2.ToLower() == "nikita")
            {
                Console.WriteLine("they are desnates");
            }
            else if (name2.tolower() == "artem" && name2.ToLower() == "nikita")
            {
                Console.WriteLine("they are desknates")
            }

            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);

            Console.ReadLine();
        }
    }
}
