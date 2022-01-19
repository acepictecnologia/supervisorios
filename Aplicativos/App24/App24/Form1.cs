using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App24
{
    public partial class Form1 : Form
    {
        string RxString;
        string txt_Rec = string.Empty;

        List<string> TempList = new List<string>();

        string txt_List = string.Empty;

        int qtde_data = 0;

        double crtTemp = 0;

        double x_axis = 0;

        bool rl1 = false, rl2 = false;

        int conta = 0;

        public Form1()
        {
            InitializeComponent();
        }      


        private void Form1_Load(object sender, EventArgs e)
        {            

            btnInicia.Enabled = false;
            btnFinaliza.Enabled = false;
            btnSair.Enabled = true;

            chart1.Series[0].Points.AddXY(0, 0);
        } 

        private void btnSair_Click(object sender, EventArgs e)
        {
            Serial.Close();
            Close();
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //RxString = Serial.ReadExisting();
            RxString = Serial.ReadLine();
            //chama outra thread para escrever o dado em alguma posição do formulário
            this.Invoke(new EventHandler(trataDadoRecebido));

        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            string[] txtSplit;
            float temp = 0, umid = 0;
            
            txt_Rec += RxString;

            //tratamento();

            if (txt_Rec.Length >= 18)
            {
                txtSplit = txt_Rec.Split(':');

                txt_Rec = string.Empty;
                

                if (txtSplit[0] == "TMP" && txtSplit[2] == "UMD")
                {

                    txt_List = txtSplit[0] + ":" + txtSplit[1] + ":" + txtSplit[2] + ":" + txtSplit[3];

                    if (txtSplit[1] != "NAN")
                    {
                        temp = float.Parse(txtSplit[1]) / 10;
                        glTemp.Value = temp;
                    }

                    if (txtSplit[3] != "NAN")
                    {
                        umid = float.Parse(txtSplit[3]) / 10;
                        glUmid.Value = umid;
                    }

                    crtTemp = temp;

                    glTemp.GaugeLabels[0].Text = temp.ToString() + " °C";
                    glUmid.GaugeLabels[0].Text = umid.ToString() + " %";

                    //Verifica Rele 1                    
                    if (txtSplit[4].Substring(0, 1) == "1")
                    {
                        pbRl1.Image = App24.Properties.Resources.LED_ON;
                        rl1 = true;
                    }
                    else
                    {
                        pbRl1.Image = App24.Properties.Resources.LED_OFF;
                        rl1 = false;
                    }

                    //Verifica Rele 2
                    if (txtSplit[4].Substring(1, 1) == "1")
                    {
                        pbRl2.Image = App24.Properties.Resources.LED_ON;
                        rl2 = true;
                    }
                    else
                    {
                        pbRl2.Image = App24.Properties.Resources.LED_OFF;
                        rl2 = false;
                    }

                }
            }
        }        

        private void btnInicia_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Write("IN000000\r");
                tmrApp.Enabled = true;
                tmrPlot.Enabled = true;
                btnInicia.Enabled = false;
                btnFinaliza.Enabled = true;

            }
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Write("FN000000\r");
                tmrApp.Enabled = false;
                tmrPlot.Enabled = false;
                if (x_axis > 100)
                    scrGraf.Visible = true;
                btnInicia.Enabled = true;
                btnFinaliza.Enabled = false;

            }
        }

        private void tmrApp_Tick(object sender, EventArgs e)
        {
            TempList.Add(DateTime.Now + " - " + txt_List);
            qtde_data++;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter Arq;

            try
            {
                if (svArquivo.ShowDialog() == DialogResult.OK)
                {
                    Arq = File.AppendText(svArquivo.FileName);

                    for (int i = 0; i < qtde_data; i++)
                        Arq.WriteLine(TempList[i]);

                    Arq.Close();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void tmrPlot_Tick(object sender, EventArgs e)
        {
            x_axis++;

            if (x_axis > 100)
            {
                chart1.ChartAreas[0].AxisX.Minimum = x_axis - 100;
                chart1.ChartAreas[0].AxisX.Maximum = x_axis + 1;
                scrGraf.Visible = true;
                scrGraf.Maximum = (int)x_axis + 1;
                scrGraf.Minimum = 100;
            }

            chart1.Series[0].Points.AddXY(x_axis, crtTemp);

            scrGraf.Value = (int)x_axis;

        }

        private void scrGraf_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrGraf.Value > 100)
            {
                chart1.ChartAreas[0].AxisX.Minimum = scrGraf.Value - 100;
                chart1.ChartAreas[0].AxisX.Maximum = scrGraf.Value;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Minimum = 0;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StreamReader Arq;
            string recebe = string.Empty;

            x_axis = 0; ;

            chart1.Series[0].Points.Clear();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Arq = new StreamReader(openFile.FileName);

                    while (!(Arq.EndOfStream))
                    {
                        recebe = Arq.ReadLine().Substring(26, 4);

                        crtTemp = (double.Parse(recebe) * 5000) / 1023;

                        if (x_axis > 100)
                        {
                            chart1.ChartAreas[0].AxisX.Minimum = x_axis - 100;
                            chart1.ChartAreas[0].AxisX.Maximum = x_axis + 1;
                            scrGraf.Visible = true;
                            scrGraf.Maximum = (int)x_axis + 1;
                            scrGraf.Minimum = 100;
                        }

                        chart1.Series[0].Points.AddXY(x_axis, crtTemp);

                        scrGraf.Value = (int)x_axis;

                        x_axis++;
                    }
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }

        private void pbRl1_Click(object sender, EventArgs e)
        {
            if (!rl1) Serial.Write("LG1\r");

            else Serial.Write("DG1\r");
        }

        private void pbRl2_Click(object sender, EventArgs e)
        {
            if (!rl2) Serial.Write("LG2\r");

            else Serial.Write("DG2\r");
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerial nForm = new frmSerial();
            nForm.ShowDialog();

            if(!clsSerial.Cancela)
            {
                try
                {
                    if (Serial.IsOpen) Serial.Close();
                    Serial.PortName = clsSerial.Porta;
                    Serial.BaudRate = int.Parse(clsSerial.BRate);
                    Serial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), clsSerial.SBits);
                    Serial.DataBits = int.Parse(clsSerial.DBits);
                    Serial.Parity = (Parity)Enum.Parse(typeof(Parity), clsSerial.Paridade);

                    btnInicia.Enabled = true;
                    btnFinaliza.Enabled = false;
                    Serial.Open();
                }
                catch 
                {
                    MessageBox.Show("Não foi possível abria a Porta Serial!");
                }
            }
        }
    }
}
