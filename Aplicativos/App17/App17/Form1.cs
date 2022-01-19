using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaração das variáveis
                int TCel, TKel, TFah;

                //lendo a temperatura a ser convertida
                TCel = int.Parse(textBox1.Text);

                //calculando as conversões
                TKel = TCel + 273;
                TFah = (((TCel * 9) / 5) + 32);

                label3.Text = TKel.ToString();
                label5.Text = TFah.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Esta não é uma entrada válida",
                                "* ATENÇÃO, ERRO *",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
