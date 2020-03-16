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
    public partial class Criptografia : Form
    {
        public Criptografia()
        {
            InitializeComponent();
        }

        private void BtnCriptografar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "" && txtVigenere.Text != "" && txtCesar.Text != "")
            {
                string palavra = txtPalavra.Text, chaveVigenere = txtVigenere.Text;
                int chaveCesar = int.Parse(txtCesar.Text);
                Resultado res = new Resultado(palavra, chaveVigenere, chaveCesar);
                res.Show();
            }
        }
    }
}
