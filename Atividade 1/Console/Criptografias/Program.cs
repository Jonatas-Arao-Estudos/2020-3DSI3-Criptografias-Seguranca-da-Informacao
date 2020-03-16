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
            string palavra;

            CifraCesar cesar = new CifraCesar();
            CifraVigenere vigenere = new CifraVigenere();
            ZenitPolar zp = new ZenitPolar();

            Console.Write("Escreva uma Palavra para Criptografar: ");
            palavra = Console.ReadLine();
            cesar.PalavraEscolhida = palavra;
            vigenere.PalavraEscolhida = palavra;
            zp.PalavraEscolhida = palavra;

            Console.Write("Uma palavra para sua Cifra de Vigenère: ");
            vigenere.Chave = Console.ReadLine();

            Console.Write("Uma número para sua Cifra de Cesar: ");
            cesar.Chave = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("Sua Palavra: {0} \n\nCifra de César: {1} \nZenit Polar: {2} \nRoute 13: {3} \nCifra de Vigenère: {4}",
                palavra, cesar.Criptografar(), zp.Criptografar(), cesar.CriptografarRoute13(), vigenere.Criptografar());

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair");

            Console.ReadKey();
        }
    }
}
