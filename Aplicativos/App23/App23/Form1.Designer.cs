namespace App23
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeLabel aGaugeLabel5 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange9 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange10 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel6 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange11 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange12 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBitsParada = new System.Windows.Forms.ComboBox();
            this.cbBitsDados = new System.Windows.Forms.ComboBox();
            this.cbParidade = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnInicia = new System.Windows.Forms.Button();
            this.mnApp = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrApp = new System.Windows.Forms.Timer(this.components);
            this.svArquivo = new System.Windows.Forms.SaveFileDialog();
            this.aGadc = new System.Windows.Forms.AGauge();
            this.aGvolt = new System.Windows.Forms.AGauge();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrPlot = new System.Windows.Forms.Timer(this.components);
            this.scrGraf = new System.Windows.Forms.HScrollBar();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.mnApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBitsParada);
            this.groupBox1.Controls.Add(this.cbBitsDados);
            this.groupBox1.Controls.Add(this.cbParidade);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.cbPortas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // cbBitsParada
            // 
            this.cbBitsParada.FormattingEnabled = true;
            this.cbBitsParada.Location = new System.Drawing.Point(383, 47);
            this.cbBitsParada.Name = "cbBitsParada";
            this.cbBitsParada.Size = new System.Drawing.Size(92, 21);
            this.cbBitsParada.TabIndex = 9;
            // 
            // cbBitsDados
            // 
            this.cbBitsDados.FormattingEnabled = true;
            this.cbBitsDados.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbBitsDados.Location = new System.Drawing.Point(284, 47);
            this.cbBitsDados.Name = "cbBitsDados";
            this.cbBitsDados.Size = new System.Drawing.Size(84, 21);
            this.cbBitsDados.TabIndex = 8;
            // 
            // cbParidade
            // 
            this.cbParidade.FormattingEnabled = true;
            this.cbParidade.Location = new System.Drawing.Point(189, 47);
            this.cbParidade.Name = "cbParidade";
            this.cbParidade.Size = new System.Drawing.Size(80, 21);
            this.cbParidade.TabIndex = 7;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(87, 47);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(86, 21);
            this.cbBaud.TabIndex = 6;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Location = new System.Drawing.Point(7, 47);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(69, 21);
            this.cbPortas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bits de Parada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bits de Dados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade (bps):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portas:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(522, 31);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(84, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Porta";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(522, 58);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar Porta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(522, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Serial
            // 
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_DataReceived);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(522, 156);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(84, 23);
            this.btnFinaliza.TabIndex = 3;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(522, 127);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(84, 23);
            this.btnInicia.TabIndex = 1;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // mnApp
            // 
            this.mnApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.mnApp.Location = new System.Drawing.Point(0, 0);
            this.mnApp.Name = "mnApp";
            this.mnApp.Size = new System.Drawing.Size(625, 24);
            this.mnApp.TabIndex = 5;
            this.mnApp.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // tmrApp
            // 
            this.tmrApp.Interval = 1000;
            this.tmrApp.Tick += new System.EventHandler(this.tmrApp_Tick);
            // 
            // svArquivo
            // 
            this.svArquivo.DefaultExt = "txt";
            this.svArquivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.svArquivo.Title = "Salvar Arquivo";
            // 
            // aGadc
            // 
            this.aGadc.BaseArcColor = System.Drawing.Color.Gray;
            this.aGadc.BaseArcRadius = 81;
            this.aGadc.BaseArcStart = 180;
            this.aGadc.BaseArcSweep = 180;
            this.aGadc.BaseArcWidth = 2;
            this.aGadc.Center = new System.Drawing.Point(120, 120);
            aGaugeLabel5.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel5.Name = "gladc";
            aGaugeLabel5.Position = new System.Drawing.Point(107, 75);
            aGaugeLabel5.Text = "000";
            this.aGadc.GaugeLabels.Add(aGaugeLabel5);
            aGaugeRange9.Color = System.Drawing.Color.Green;
            aGaugeRange9.EndValue = 900F;
            aGaugeRange9.InnerRadius = 70;
            aGaugeRange9.InRange = true;
            aGaugeRange9.Name = "FuncOk";
            aGaugeRange9.OuterRadius = 80;
            aGaugeRange9.StartValue = 0F;
            aGaugeRange10.Color = System.Drawing.Color.Red;
            aGaugeRange10.EndValue = 1100F;
            aGaugeRange10.InnerRadius = 70;
            aGaugeRange10.InRange = false;
            aGaugeRange10.Name = "Alerta";
            aGaugeRange10.OuterRadius = 80;
            aGaugeRange10.StartValue = 900F;
            this.aGadc.GaugeRanges.Add(aGaugeRange9);
            this.aGadc.GaugeRanges.Add(aGaugeRange10);
            this.aGadc.Location = new System.Drawing.Point(23, 120);
            this.aGadc.MaxValue = 1100F;
            this.aGadc.MinValue = 0F;
            this.aGadc.Name = "aGadc";
            this.aGadc.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGadc.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGadc.NeedleRadius = 80;
            this.aGadc.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGadc.NeedleWidth = 2;
            this.aGadc.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGadc.ScaleLinesInterInnerRadius = 73;
            this.aGadc.ScaleLinesInterOuterRadius = 80;
            this.aGadc.ScaleLinesInterWidth = 1;
            this.aGadc.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGadc.ScaleLinesMajorInnerRadius = 70;
            this.aGadc.ScaleLinesMajorOuterRadius = 80;
            this.aGadc.ScaleLinesMajorStepValue = 100F;
            this.aGadc.ScaleLinesMajorWidth = 2;
            this.aGadc.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGadc.ScaleLinesMinorInnerRadius = 75;
            this.aGadc.ScaleLinesMinorOuterRadius = 80;
            this.aGadc.ScaleLinesMinorTicks = 9;
            this.aGadc.ScaleLinesMinorWidth = 1;
            this.aGadc.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGadc.ScaleNumbersFormat = null;
            this.aGadc.ScaleNumbersRadius = 95;
            this.aGadc.ScaleNumbersRotation = 0;
            this.aGadc.ScaleNumbersStartScaleLine = 0;
            this.aGadc.ScaleNumbersStepScaleLines = 1;
            this.aGadc.Size = new System.Drawing.Size(258, 146);
            this.aGadc.TabIndex = 6;
            this.aGadc.Text = "aGauge1";
            this.aGadc.Value = 0F;
            // 
            // aGvolt
            // 
            this.aGvolt.BaseArcColor = System.Drawing.Color.Gray;
            this.aGvolt.BaseArcRadius = 81;
            this.aGvolt.BaseArcStart = 180;
            this.aGvolt.BaseArcSweep = 180;
            this.aGvolt.BaseArcWidth = 2;
            this.aGvolt.Center = new System.Drawing.Point(120, 120);
            aGaugeLabel6.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel6.Name = "glVolt";
            aGaugeLabel6.Position = new System.Drawing.Point(107, 75);
            aGaugeLabel6.Text = "0000";
            this.aGvolt.GaugeLabels.Add(aGaugeLabel6);
            aGaugeRange11.Color = System.Drawing.Color.Green;
            aGaugeRange11.EndValue = 4000F;
            aGaugeRange11.InnerRadius = 70;
            aGaugeRange11.InRange = true;
            aGaugeRange11.Name = "FuncOk";
            aGaugeRange11.OuterRadius = 80;
            aGaugeRange11.StartValue = 0F;
            aGaugeRange12.Color = System.Drawing.Color.Red;
            aGaugeRange12.EndValue = 5000F;
            aGaugeRange12.InnerRadius = 70;
            aGaugeRange12.InRange = false;
            aGaugeRange12.Name = "Alerta";
            aGaugeRange12.OuterRadius = 80;
            aGaugeRange12.StartValue = 4000F;
            this.aGvolt.GaugeRanges.Add(aGaugeRange11);
            this.aGvolt.GaugeRanges.Add(aGaugeRange12);
            this.aGvolt.Location = new System.Drawing.Point(249, 127);
            this.aGvolt.MaxValue = 5000F;
            this.aGvolt.MinValue = 0F;
            this.aGvolt.Name = "aGvolt";
            this.aGvolt.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGvolt.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGvolt.NeedleRadius = 80;
            this.aGvolt.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGvolt.NeedleWidth = 2;
            this.aGvolt.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGvolt.ScaleLinesInterInnerRadius = 73;
            this.aGvolt.ScaleLinesInterOuterRadius = 80;
            this.aGvolt.ScaleLinesInterWidth = 1;
            this.aGvolt.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGvolt.ScaleLinesMajorInnerRadius = 70;
            this.aGvolt.ScaleLinesMajorOuterRadius = 80;
            this.aGvolt.ScaleLinesMajorStepValue = 500F;
            this.aGvolt.ScaleLinesMajorWidth = 2;
            this.aGvolt.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGvolt.ScaleLinesMinorInnerRadius = 75;
            this.aGvolt.ScaleLinesMinorOuterRadius = 80;
            this.aGvolt.ScaleLinesMinorTicks = 9;
            this.aGvolt.ScaleLinesMinorWidth = 1;
            this.aGvolt.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGvolt.ScaleNumbersFormat = null;
            this.aGvolt.ScaleNumbersRadius = 95;
            this.aGvolt.ScaleNumbersRotation = 0;
            this.aGvolt.ScaleNumbersStartScaleLine = 0;
            this.aGvolt.ScaleNumbersStepScaleLines = 1;
            this.aGvolt.Size = new System.Drawing.Size(258, 146);
            this.aGvolt.TabIndex = 8;
            this.aGvolt.Text = "aGauge1";
            this.aGvolt.Value = 0F;
            // 
            // chart1
            // 
            chartArea3.AxisX.Interval = 10D;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Tempo(s)";
            chartArea3.AxisY.Maximum = 5000D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Tensão (mV)";
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 80.92239F;
            chartArea3.InnerPlotPosition.Width = 85.08459F;
            chartArea3.InnerPlotPosition.X = 12.12286F;
            chartArea3.InnerPlotPosition.Y = 3.35106F;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(12, 264);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(601, 294);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // tmrPlot
            // 
            this.tmrPlot.Interval = 1000;
            this.tmrPlot.Tick += new System.EventHandler(this.tmrPlot_Tick);
            // 
            // scrGraf
            // 
            this.scrGraf.Location = new System.Drawing.Point(99, 541);
            this.scrGraf.Maximum = 150;
            this.scrGraf.Name = "scrGraf";
            this.scrGraf.Size = new System.Drawing.Size(205, 17);
            this.scrGraf.TabIndex = 10;
            this.scrGraf.Visible = false;
            this.scrGraf.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrGraf_Scroll);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Abrir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.Filter = "Arquivos txt (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            this.openFile.Title = "Abrir Arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 570);
            this.Controls.Add(this.scrGraf);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.aGvolt);
            this.Controls.Add(this.aGadc);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnApp);
            this.MainMenuStrip = this.mnApp;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnApp.ResumeLayout(false);
            this.mnApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBitsParada;
        private System.Windows.Forms.ComboBox cbBitsDados;
        private System.Windows.Forms.ComboBox cbParidade;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSair;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.MenuStrip mnApp;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer tmrApp;
        private System.Windows.Forms.SaveFileDialog svArquivo;
        private System.Windows.Forms.AGauge aGadc;
        private System.Windows.Forms.AGauge aGvolt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer tmrPlot;
        private System.Windows.Forms.HScrollBar scrGraf;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

