using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KlasaArrayList
{
    public partial class Automobili : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Automobili()
        {
            InitializeComponent();
        }

        private void Automobili_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNovi_TextChanged(object sender, EventArgs e)
        {
            Automobil a = new Automobil(textBoxNovi.Text);
            listaAutomobila.Add(a);
            richTextBox1.AppendText
            (listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
        }
    }
}
