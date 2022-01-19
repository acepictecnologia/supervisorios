namespace App24
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel4 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSair = new System.Windows.Forms.Button();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnInicia = new System.Windows.Forms.Button();
            this.mnApp = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrApp = new System.Windows.Forms.Timer(this.components);
            this.svArquivo = new System.Windows.Forms.SaveFileDialog();
            this.glTemp = new System.Windows.Forms.AGauge();
            this.glUmid = new System.Windows.Forms.AGauge();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrPlot = new System.Windows.Forms.Timer(this.components);
            this.scrGraf = new System.Windows.Forms.HScrollBar();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbRl2 = new System.Windows.Forms.PictureBox();
            this.pbRl1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(663, 147);
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
            this.btnFinaliza.Location = new System.Drawing.Point(663, 73);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(84, 23);
            this.btnFinaliza.TabIndex = 3;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(663, 44);
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
            this.arquivoToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.mnApp.Location = new System.Drawing.Point(0, 0);
            this.mnApp.Name = "mnApp";
            this.mnApp.Size = new System.Drawing.Size(760, 24);
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
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem2.Text = "Abrir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
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
            // glTemp
            // 
            this.glTemp.BackColor = System.Drawing.Color.RoyalBlue;
            this.glTemp.BaseArcColor = System.Drawing.Color.Gray;
            this.glTemp.BaseArcRadius = 81;
            this.glTemp.BaseArcStart = 180;
            this.glTemp.BaseArcSweep = 180;
            this.glTemp.BaseArcWidth = 2;
            this.glTemp.Center = new System.Drawing.Point(120, 120);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Name = "glTemp";
            aGaugeLabel1.Position = new System.Drawing.Point(100, 90);
            aGaugeLabel1.Text = "00,0 °C";
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Name = "GaugeLabel1";
            aGaugeLabel2.Position = new System.Drawing.Point(88, 75);
            aGaugeLabel2.Text = "Temperatura";
            this.glTemp.GaugeLabels.Add(aGaugeLabel1);
            this.glTemp.GaugeLabels.Add(aGaugeLabel2);
            aGaugeRange1.Color = System.Drawing.Color.Green;
            aGaugeRange1.EndValue = 80F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = true;
            aGaugeRange1.Name = "FuncOk";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Red;
            aGaugeRange2.EndValue = 100F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "Alerta";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 80F;
            this.glTemp.GaugeRanges.Add(aGaugeRange1);
            this.glTemp.GaugeRanges.Add(aGaugeRange2);
            this.glTemp.Location = new System.Drawing.Point(15, 32);
            this.glTemp.MaxValue = 100F;
            this.glTemp.MinValue = 0F;
            this.glTemp.Name = "glTemp";
            this.glTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.glTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.glTemp.NeedleRadius = 80;
            this.glTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.glTemp.NeedleWidth = 2;
            this.glTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.glTemp.ScaleLinesInterInnerRadius = 73;
            this.glTemp.ScaleLinesInterOuterRadius = 80;
            this.glTemp.ScaleLinesInterWidth = 1;
            this.glTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.glTemp.ScaleLinesMajorInnerRadius = 70;
            this.glTemp.ScaleLinesMajorOuterRadius = 80;
            this.glTemp.ScaleLinesMajorStepValue = 10F;
            this.glTemp.ScaleLinesMajorWidth = 2;
            this.glTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.glTemp.ScaleLinesMinorInnerRadius = 75;
            this.glTemp.ScaleLinesMinorOuterRadius = 80;
            this.glTemp.ScaleLinesMinorTicks = 9;
            this.glTemp.ScaleLinesMinorWidth = 1;
            this.glTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.glTemp.ScaleNumbersFormat = null;
            this.glTemp.ScaleNumbersRadius = 95;
            this.glTemp.ScaleNumbersRotation = 0;
            this.glTemp.ScaleNumbersStartScaleLine = 0;
            this.glTemp.ScaleNumbersStepScaleLines = 1;
            this.glTemp.Size = new System.Drawing.Size(258, 146);
            this.glTemp.TabIndex = 6;
            this.glTemp.Text = "aGauge1";
            this.glTemp.Value = 0F;
            // 
            // glUmid
            // 
            this.glUmid.BackColor = System.Drawing.Color.RoyalBlue;
            this.glUmid.BaseArcColor = System.Drawing.Color.Gray;
            this.glUmid.BaseArcRadius = 81;
            this.glUmid.BaseArcStart = 180;
            this.glUmid.BaseArcSweep = 180;
            this.glUmid.BaseArcWidth = 2;
            this.glUmid.Center = new System.Drawing.Point(120, 120);
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel3.Name = "glVolt";
            aGaugeLabel3.Position = new System.Drawing.Point(100, 90);
            aGaugeLabel3.Text = "00,0 %";
            aGaugeLabel4.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel4.Name = "GaugeLabel1";
            aGaugeLabel4.Position = new System.Drawing.Point(95, 75);
            aGaugeLabel4.Text = "Umidade";
            this.glUmid.GaugeLabels.Add(aGaugeLabel3);
            this.glUmid.GaugeLabels.Add(aGaugeLabel4);
            aGaugeRange3.Color = System.Drawing.Color.Green;
            aGaugeRange3.EndValue = 100F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = true;
            aGaugeRange3.Name = "FuncOk";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 40F;
            aGaugeRange4.Color = System.Drawing.Color.Red;
            aGaugeRange4.EndValue = 40F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "Alerta";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 0F;
            this.glUmid.GaugeRanges.Add(aGaugeRange3);
            this.glUmid.GaugeRanges.Add(aGaugeRange4);
            this.glUmid.Location = new System.Drawing.Point(249, 33);
            this.glUmid.MaxValue = 100F;
            this.glUmid.MinValue = 0F;
            this.glUmid.Name = "glUmid";
            this.glUmid.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.glUmid.NeedleColor2 = System.Drawing.Color.DimGray;
            this.glUmid.NeedleRadius = 80;
            this.glUmid.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.glUmid.NeedleWidth = 2;
            this.glUmid.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.glUmid.ScaleLinesInterInnerRadius = 73;
            this.glUmid.ScaleLinesInterOuterRadius = 80;
            this.glUmid.ScaleLinesInterWidth = 1;
            this.glUmid.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.glUmid.ScaleLinesMajorInnerRadius = 70;
            this.glUmid.ScaleLinesMajorOuterRadius = 80;
            this.glUmid.ScaleLinesMajorStepValue = 10F;
            this.glUmid.ScaleLinesMajorWidth = 2;
            this.glUmid.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.glUmid.ScaleLinesMinorInnerRadius = 75;
            this.glUmid.ScaleLinesMinorOuterRadius = 80;
            this.glUmid.ScaleLinesMinorTicks = 9;
            this.glUmid.ScaleLinesMinorWidth = 1;
            this.glUmid.ScaleNumbersColor = System.Drawing.Color.Black;
            this.glUmid.ScaleNumbersFormat = null;
            this.glUmid.ScaleNumbersRadius = 95;
            this.glUmid.ScaleNumbersRotation = 0;
            this.glUmid.ScaleNumbersStartScaleLine = 0;
            this.glUmid.ScaleNumbersStepScaleLines = 1;
            this.glUmid.Size = new System.Drawing.Size(258, 146);
            this.glUmid.TabIndex = 8;
            this.glUmid.Text = "aGauge1";
            this.glUmid.Value = 0F;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Tempo(s)";
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Tensão (mV)";
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80.92239F;
            chartArea1.InnerPlotPosition.Width = 85.08459F;
            chartArea1.InnerPlotPosition.X = 12.12286F;
            chartArea1.InnerPlotPosition.Y = 3.35106F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 176);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(735, 305);
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
            this.scrGraf.Location = new System.Drawing.Point(99, 453);
            this.scrGraf.Maximum = 150;
            this.scrGraf.Name = "scrGraf";
            this.scrGraf.Size = new System.Drawing.Size(205, 17);
            this.scrGraf.TabIndex = 10;
            this.scrGraf.Visible = false;
            this.scrGraf.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrGraf_Scroll);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "txt";
            this.openFile.Filter = "Arquivos txt (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            this.openFile.Title = "Abrir Arquivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbRl2);
            this.groupBox1.Controls.Add(this.pbRl1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(495, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // pbRl2
            // 
            this.pbRl2.Image = global::App24.Properties.Resources.LED_OFF;
            this.pbRl2.Location = new System.Drawing.Point(82, 79);
            this.pbRl2.Name = "pbRl2";
            this.pbRl2.Size = new System.Drawing.Size(36, 39);
            this.pbRl2.TabIndex = 3;
            this.pbRl2.TabStop = false;
            this.pbRl2.Click += new System.EventHandler(this.pbRl2_Click);
            // 
            // pbRl1
            // 
            this.pbRl1.Image = global::App24.Properties.Resources.LED_OFF;
            this.pbRl1.Location = new System.Drawing.Point(82, 34);
            this.pbRl1.Name = "pbRl1";
            this.pbRl1.Size = new System.Drawing.Size(36, 39);
            this.pbRl1.TabIndex = 2;
            this.pbRl1.TabStop = false;
            this.pbRl1.Click += new System.EventHandler(this.pbRl1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relê 02";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relê 01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(760, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scrGraf);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.glUmid);
            this.Controls.Add(this.glTemp);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mnApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnApp;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnApp.ResumeLayout(false);
            this.mnApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.AGauge glTemp;
        private System.Windows.Forms.AGauge glUmid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer tmrPlot;
        private System.Windows.Forms.HScrollBar scrGraf;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbRl2;
        private System.Windows.Forms.PictureBox pbRl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

