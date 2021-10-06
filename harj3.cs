using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class harj3
    {
        Console.writeLine("------------")
        int arv = int.Parse(Console.ReadLine());
        if (arv>0)
        {
        int procent = (arv + 30 / 100);
        Console.writeline("s= {0}",arv - procent);
        }
    }
}
