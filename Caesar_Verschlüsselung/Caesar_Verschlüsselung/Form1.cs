using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caesar_Verschlüsselung
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void txteingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_verschlüsseln_Click(object sender, EventArgs e)
        {
            string eingabe = txteingabe.Text;
            int schlüssel = Convert.ToInt32(txt_schlüssel.Text);
            char[] chararray = eingabe.ToCharArray();
            int[] ascii = new int[eingabe.Length];
            for (int i = 0; i < eingabe.Length; i++)
            {
                ascii[i] = Convert.ToInt32(chararray[i]) + schlüssel;
            }
            for (int i = 0; i < eingabe.Length; i++)
            {
                chararray[i] = Convert.ToChar(ascii[i]);
            }
            string ausgabe = "";
            for (int i = 0; i < chararray.Length; i++)
            {
                ausgabe = ausgabe + Convert.ToString(chararray[i]);
            }
            txtausgabe.Text = ausgabe;
        }

        private void txtausgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_entschlüssels_eingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entschlüsseln_Click(object sender, EventArgs e)
        {

        }

        private void txt_entschlüsseln_ausgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_schlüssel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
