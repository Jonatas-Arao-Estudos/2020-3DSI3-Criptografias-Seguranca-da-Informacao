using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografias
{
    class Palavra
    {
        private string palavraEscolhida;

        public Palavra()
        {
            this.palavraEscolhida = null;
        }
        public Palavra(string palavraEscolhida)
        {
            this.palavraEscolhida = palavraEscolhida;
        }

        public string PalavraEscolhida
        {
            get { return palavraEscolhida; }
            set {
                palavraEscolhida = value;
            }
        }

        public byte[] PalavraBytes()
        {
            ASCIIEncoding ASCII = new ASCIIEncoding();
            byte[] palavraBytes = ASCII.GetBytes(this.palavraEscolhida);
            return palavraBytes;
        }
    }
}
