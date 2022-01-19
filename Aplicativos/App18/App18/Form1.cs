using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App18
{
    public partial class Form1 : Form
    {
        Livro livro = new Livro();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            livro.Id = int.Parse(textBox1.Text);
            livro.Titulo = textBox2.Text;
            livro.Autor = textBox3.Text;
            livro.Editora = textBox4.Text;
            livro.Data_pub = DateTime.Parse(textBox5.Text);

            listBox1.Items.Add(livro.Id.ToString());
            listBox1.Items.Add(livro.Titulo);
            listBox1.Items.Add(livro.Autor);
            listBox1.Items.Add(livro.Editora);
            listBox1.Items.Add(livro.Data_pub.ToString());

        }
    }
}
