using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografias
{
    class CifraCesar : Palavra
    {
        private int chave;

        public CifraCesar()
            : base()
        {
            this.chave = 0;
        }

        public CifraCesar(string palavra, int chave)
            : base(palavra)
        {
            this.chave = chave;
        }

        public int Chave
        {
            get { return chave; }
            set { chave = value; }
        }

        public string Criptografar()
        {
            ASCIIEncoding ASCII = new ASCIIEncoding();
            byte[] palavraBytes = this.PalavraBytes();
            for (int i = 0; i < palavraBytes.Length; i++)
            {
                if (palavraBytes[i] >= 65 && palavraBytes[i] <= 90)
                {
                    palavraBytes[i] = calculaCifraCesar(65, this.chave, palavraBytes[i]);
                }
                if (palavraBytes[i] >= 97 && palavraBytes[i] <= 122)
                {
                    palavraBytes[i] = calculaCifraCesar(97, this.chave, palavraBytes[i]);
                }
            }

            byte calculaCifraCesar(int inicio, int chave , byte letra)
            {
                int salto = inicio + ((chave + (letra - inicio)) % 26);
                letra = Convert.ToByte(salto);
                return letra;
            }

            string palavraCodificada = ASCII.GetString(palavraBytes);
            return palavraCodificada;
        }
    }
}
