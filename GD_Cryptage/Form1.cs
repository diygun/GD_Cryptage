using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GD_Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrypter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAcrypter.Text) && !String.IsNullOrEmpty(clePerso.Text))
            {
            //  Appel du cryptage personel
                string text_a_crypter = Convert.ToString(txtAcrypter.Text);
                int clef = Convert.ToInt32(clePerso.Text);

                CryptagePerso_LoremIpsum cPerso = new CryptagePerso_LoremIpsum(text_a_crypter, clef);
                txtCryptePerso.Text = cPerso.CryptText();

            // Appel du cryptage .NET


            }



        }

        private void btnDecrypter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCryptePerso.Text) && !String.IsNullOrEmpty(clePerso.Text))
            {
                string text_a_decrypter = Convert.ToString(txtCryptePerso.Text);
                int clef = Convert.ToInt32(clePerso.Text);

                CryptagePerso_LoremIpsum cPerso = new CryptagePerso_LoremIpsum(text_a_decrypter, clef);

                txtAcrypter.Text = cPerso.DecryptText();


            }

        }
    }
}
