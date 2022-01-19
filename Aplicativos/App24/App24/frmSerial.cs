using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace App24
{
    public partial class frmSerial : Form
    {
        public frmSerial()
        {
            InitializeComponent();
        }


        private void atualizaCom()
        {
            //Limpa todos os itens em cbPortas caso existam
            cmbPortas.Items.Clear();

            /* Para cada nome de porta de comunicação serial identificado
             * será atribuído à variável 's'*/
            foreach (string s in SerialPort.GetPortNames())
            {
                //adiciona a variável 's' a cada item de cbPortas
                cmbPortas.Items.Add(s);
            }

            //Seleciona o item de índice 0 em cbPortas
            cmbPortas.SelectedIndex = 0;
        }

        private void paridade()
        {
            int i = 0;      //variável de controle de índice do combo

            //Limpa todos os itens em cbParidade caso existam
            cmbParidade.Items.Clear();

            //Para cada nome de paridade identificado será atribuído à variável 's'
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                //adiciona a variável 's' a cada item de cbParidade
                cmbParidade.Items.Add(s);

                /* verifica se o nome recebido é 'None',
                 * caso seja, seleciona o seu índice para exibição*/
                if (s == "None")
                    cmbParidade.SelectedIndex = i;

                i++;    //incrementa a variável i
            }
        }

        private void bitsParada()
        {
            int i = 0;      //variável de controle de índice do combo

            //Limpa todos os itens em cbBitsParada caso existam
            cmbBitsParada.Items.Clear();

            //Cada nome de bits de parada identificado será atribuído à variável 's'
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                //adiciona a variável 's' a cada item de cbBitsParada
                cmbBitsParada.Items.Add(str);

                /* verifica se o nome recebido é 'One',
                 * caso seja, seleciona o seu índice para exibição*/
                if (str == "One") cmbBitsParada.SelectedIndex = i;

                i++;    //inrementa a variável i
            }

        }

        private void frmSerial_Load(object sender, EventArgs e)
        {
            atualizaCom();

            cmbBaud.SelectedText = "9600";

            paridade();

            cmbBitsDados.SelectedText = "8";

            bitsParada();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            clsSerial.Porta = cmbPortas.Text;
            clsSerial.BRate = cmbBaud.Text;
            clsSerial.SBits = cmbBitsParada.Text;
            clsSerial.DBits = cmbBitsDados.Text;
            clsSerial.Paridade = cmbParidade.Text;
            clsSerial.Cancela = false;
            Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            //Garante o fechamento da porta serial
            if(mainSerial.IsOpen) mainSerial.Close();
            clsSerial.Cancela = true;
            Close();
        }
    }
}
