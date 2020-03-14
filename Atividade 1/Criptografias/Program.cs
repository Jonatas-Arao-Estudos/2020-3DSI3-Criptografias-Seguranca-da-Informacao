using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografias
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            CifraCesar Cesar = new CifraCesar(palavra, 26);
            Console.Write(Cesar.Criptografar());
            Console.ReadKey();
        }
    }
}
