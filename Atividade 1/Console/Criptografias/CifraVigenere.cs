using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografias
{
    class CifraVigenere : Palavra
    {
        private string chave;
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        public CifraVigenere()
            : base()
        {
            this.chave = null;
        }

        public CifraVigenere(string palavra, string chave)
            : base(palavra)
        {
            this.chave = chave.ToLower().Replace(" ","");
        }

        public string Chave
        {
            get { return chave; }
            set { chave = value.ToLower().Replace(" ", ""); }
        }

        public string Criptografar()
        {
            ASCIIEncoding ASCII = new ASCIIEncoding();
            byte[] palavraBytes = this.PalavraBytes();
            string chavePalavra = "";
            string palavraCodificada = "";

            for (int i = 0; i < palavraBytes.Length; i++)
            {
                if ((palavraBytes[i] >= 65 && palavraBytes[i] <= 90) || (palavraBytes[i] >= 97 && palavraBytes[i] <= 122))
                {
                    chavePalavra += Convert.ToString(this.chave[i % chave.Length]);
                }
                else
                {
                    chavePalavra += " " + Convert.ToString(this.chave[i % chave.Length]);
                }
            }

            CifraCesar cesar = new CifraCesar();
            
            for (int i = 0; i < palavraBytes.Length; i++)
            {
                if ((palavraBytes[i] >= 65 && palavraBytes[i] <= 90) || (palavraBytes[i] >= 97 && palavraBytes[i] <= 122))
                {
                    cesar.PalavraEscolhida = Convert.ToString(this.PalavraEscolhida[i]);
                    cesar.Chave = alfabeto.IndexOf(chavePalavra[i]);
                    palavraCodificada += cesar.Criptografar();
                }else
                {
                    palavraCodificada += PalavraEscolhida[i];
                }
            }

            return palavraCodificada;
        }
    }
}
