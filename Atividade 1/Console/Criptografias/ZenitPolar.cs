using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografias
{
    class ZenitPolar : Palavra
    {

        public ZenitPolar()
            : base()
        {
        }

        public ZenitPolar(string palavra)
            : base(palavra)
        {
        }

        public string Criptografar()
        {
            ASCIIEncoding ASCII = new ASCIIEncoding();
            byte[] palavraBytes = this.PalavraBytes();
            byte[] ZENIT = new byte[] { 90, 69, 78, 73, 84 };
            byte[] zenit = new byte[] { 122, 101, 110, 105, 116 };
            byte[] POLAR = new byte[] { 80, 79, 76, 65, 82 };
            byte[] polar = new byte[] { 112, 111, 108, 97, 114 };

            for (int i = 0; i < palavraBytes.Length; i++)
            {
                for (int zp = 0; zp < 5; zp++)
                {
                    if (palavraBytes[i] == zenit[zp])
                    {
                        palavraBytes[i] = polar[zp];
                    }else if(palavraBytes[i] == polar[zp])
                    {
                        palavraBytes[i] = zenit[zp];
                    }
                    if (palavraBytes[i] == ZENIT[zp])
                    {
                        palavraBytes[i] = POLAR[zp];
                    }
                    else if (palavraBytes[i] == POLAR[zp])
                    {
                        palavraBytes[i] = ZENIT[zp];
                    }
                }
            }

            string palavraCodificada = ASCII.GetString(palavraBytes);
            return palavraCodificada;
        }
    }
}
