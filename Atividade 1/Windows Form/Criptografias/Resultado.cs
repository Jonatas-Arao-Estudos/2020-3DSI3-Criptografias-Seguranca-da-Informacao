using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografias
{
    public partial class Resultado : Form
    {
        public Resultado(string palavra, string chaveVigenere, int chaveCesar)
        {
            ZenitPolar zp = new ZenitPolar(palavra);
            CifraVigenere vigenere = new CifraVigenere(palavra, chaveVigenere);
            CifraCesar cesar = new CifraCesar(palavra, chaveCesar);

            InitializeComponent();

            labelPalavra.Text += palavra;
            labelZP.Text += zp.Criptografar();
            labelVigenere.Text += vigenere.Criptografar();
            labelCesar.Text += cesar.Criptografar();
            labelR13.Text += cesar.CriptografarRoute13();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
