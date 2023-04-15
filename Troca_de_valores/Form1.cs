using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troca_de_valores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "")
                MessageBox.Show("Você precisa inserir um valor!!! ");

            textBoxtrocaa.Text = (Convert.ToDouble(textBoxB.Text).ToString());
            trocab.Text = (Convert.ToDouble(textBoxA.Text).ToString());
        }
    }
}
