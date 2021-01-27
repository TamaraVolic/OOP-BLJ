using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        Konto konto = new Konto();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEinzahlen_Click(object sender, EventArgs e)
        {
            // 1. Eingegebener Betrag  auslesen
            int betrag= Convert.ToInt32(txtBetrag.Text);

            // 2. Eingegebener Betrag aufs Konto einzahlen
            konto.Einzahlen(betrag);

            AktualisiereSaldoAnzeige();
        }

        private void buttonAbheben_Click(object sender, EventArgs e)
        {
            int betrag = Convert.ToInt32(txtBetrag.Text);

            try
            {
                konto.Abheben(betrag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AktualisiereSaldoAnzeige();
        }

        private void AktualisiereSaldoAnzeige()
        {
            txtSaldo.Text = konto.Saldo.ToString();
        }

    }
}
