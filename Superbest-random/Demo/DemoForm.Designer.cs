namespace Demo
{
    partial class DemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_execute = new System.Windows.Forms.Button();
            this.demo_picker = new System.Windows.Forms.ComboBox();
            this.Waiting = new System.Windows.Forms.TextBox();
            this.sigma = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.DeviationListElement = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Waiting2 = new System.Windows.Forms.TextBox();
            this.sigma2 = new System.Windows.Forms.TextBox();
            this.color1 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DispersionResult = new System.Windows.Forms.TextBox();
            this.NQDResult = new System.Windows.Forms.TextBox();
            this.LabelFor2 = new System.Windows.Forms.Label();
            this.labelFor2_1 = new System.Windows.Forms.Label();
            this.labelFor2_2 = new System.Windows.Forms.Label();
            this.FullPropabilityRes = new System.Windows.Forms.TextBox();
            this.FullPropTitle = new System.Windows.Forms.Label();
            this.FullPropMainDesc = new System.Windows.Forms.Label();
            this.FullPropPicFormula = new System.Windows.Forms.PictureBox();
            this.pictureBox1_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullPropPicFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(17, 40);
            this.graph.Name = "graph";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graph.Series.Add(series3);
            this.graph.Size = new System.Drawing.Size(489, 211);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // btn_execute
            // 
            this.btn_execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_execute.Location = new System.Drawing.Point(20, 360);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(194, 23);
            this.btn_execute.TabIndex = 2;
            this.btn_execute.Text = "Решить";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.DemoRequested);
            // 
            // demo_picker
            // 
            this.demo_picker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demo_picker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demo_picker.FormattingEnabled = true;
            this.demo_picker.Items.AddRange(new object[] {
            "Нормальное распределение",
            "Полная вероятность",
            "Матожидание, дисперсия и СКО"});
            this.demo_picker.Location = new System.Drawing.Point(13, 13);
            this.demo_picker.Name = "demo_picker";
            this.demo_picker.Size = new System.Drawing.Size(762, 21);
            this.demo_picker.TabIndex = 1;
            this.demo_picker.SelectedIndexChanged += new System.EventHandler(this.demo_picker_SelectedIndexChanged);
            // 
            // Waiting
            // 
            this.Waiting.Location = new System.Drawing.Point(17, 276);
            this.Waiting.Name = "Waiting";
            this.Waiting.Size = new System.Drawing.Size(94, 20);
            this.Waiting.TabIndex = 3;
            this.Waiting.Text = "Мат. Ожидание";
            // 
            // sigma
            // 
            this.sigma.Location = new System.Drawing.Point(16, 302);
            this.sigma.Name = "sigma";
            this.sigma.Size = new System.Drawing.Size(95, 20);
            this.sigma.TabIndex = 4;
            this.sigma.Text = "Стандартное Отклонение";
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic);
            this.Result.Location = new System.Drawing.Point(217, 270);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(286, 34);
            this.Result.TabIndex = 5;
            this.Result.Text = "Матожидание";
            // 
            // DeviationListElement
            // 
            this.DeviationListElement.Location = new System.Drawing.Point(17, 331);
            this.DeviationListElement.Name = "DeviationListElement";
            this.DeviationListElement.Size = new System.Drawing.Size(194, 20);
            this.DeviationListElement.TabIndex = 6;
            this.DeviationListElement.Text = "N";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 211);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(19, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Начертить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Waiting2
            // 
            this.Waiting2.Location = new System.Drawing.Point(117, 276);
            this.Waiting2.Name = "Waiting2";
            this.Waiting2.Size = new System.Drawing.Size(94, 20);
            this.Waiting2.TabIndex = 11;
            this.Waiting2.Text = "Мат. Ожидание";
            // 
            // sigma2
            // 
            this.sigma2.Location = new System.Drawing.Point(116, 302);
            this.sigma2.Name = "sigma2";
            this.sigma2.Size = new System.Drawing.Size(95, 20);
            this.sigma2.TabIndex = 12;
            this.sigma2.Text = "Стандартное Отклонение";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Cyan;
            this.color1.Enabled = false;
            this.color1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.color1.Location = new System.Drawing.Point(17, 328);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(31, 26);
            this.color1.TabIndex = 13;
            this.color1.UseVisualStyleBackColor = false;
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.color3.Enabled = false;
            this.color3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.color3.Location = new System.Drawing.Point(117, 328);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(31, 26);
            this.color3.TabIndex = 14;
            this.color3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(535, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Нормальный закон распределения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(509, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 85);
            this.label2.TabIndex = 16;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.Location = new System.Drawing.Point(592, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Правило трёх сигм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(519, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 102);
            this.label4.TabIndex = 19;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // DispersionResult
            // 
            this.DispersionResult.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic);
            this.DispersionResult.Location = new System.Drawing.Point(217, 310);
            this.DispersionResult.Name = "DispersionResult";
            this.DispersionResult.Size = new System.Drawing.Size(286, 34);
            this.DispersionResult.TabIndex = 21;
            this.DispersionResult.Text = "Дисперсия";
            // 
            // NQDResult
            // 
            this.NQDResult.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic);
            this.NQDResult.Location = new System.Drawing.Point(217, 350);
            this.NQDResult.Name = "NQDResult";
            this.NQDResult.Size = new System.Drawing.Size(286, 34);
            this.NQDResult.TabIndex = 22;
            this.NQDResult.Text = "СКО";
            // 
            // LabelFor2
            // 
            this.LabelFor2.AutoSize = true;
            this.LabelFor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelFor2.Location = new System.Drawing.Point(509, 37);
            this.LabelFor2.Name = "LabelFor2";
            this.LabelFor2.Size = new System.Drawing.Size(366, 68);
            this.LabelFor2.TabIndex = 23;
            this.LabelFor2.Text = "Математи́ческое ожида́ние — понятие в теории\r\n вероятностей, означающее среднее \r" +
    "\n(взвешенное по вероятностям \r\nвозможных значений) значение случайной величины.";
            // 
            // labelFor2_1
            // 
            this.labelFor2_1.AutoSize = true;
            this.labelFor2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFor2_1.Location = new System.Drawing.Point(519, 169);
            this.labelFor2_1.Name = "labelFor2_1";
            this.labelFor2_1.Size = new System.Drawing.Size(312, 51);
            this.labelFor2_1.TabIndex = 25;
            this.labelFor2_1.Text = "Диспе́рсия случа́йной величины́ — мера \r\nразброса значений случайной величины \r\nо" +
    "тносительно её математического ожидания.";
            // 
            // labelFor2_2
            // 
            this.labelFor2_2.AutoSize = true;
            this.labelFor2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFor2_2.Location = new System.Drawing.Point(509, 263);
            this.labelFor2_2.Name = "labelFor2_2";
            this.labelFor2_2.Size = new System.Drawing.Size(361, 90);
            this.labelFor2_2.TabIndex = 27;
            this.labelFor2_2.Text = resources.GetString("labelFor2_2.Text");
            // 
            // FullPropabilityRes
            // 
            this.FullPropabilityRes.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Italic);
            this.FullPropabilityRes.Location = new System.Drawing.Point(217, 270);
            this.FullPropabilityRes.Name = "FullPropabilityRes";
            this.FullPropabilityRes.Size = new System.Drawing.Size(286, 34);
            this.FullPropabilityRes.TabIndex = 29;
            this.FullPropabilityRes.Text = "Результат";
            // 
            // FullPropTitle
            // 
            this.FullPropTitle.AutoSize = true;
            this.FullPropTitle.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.FullPropTitle.Location = new System.Drawing.Point(593, 37);
            this.FullPropTitle.Name = "FullPropTitle";
            this.FullPropTitle.Size = new System.Drawing.Size(182, 22);
            this.FullPropTitle.TabIndex = 30;
            this.FullPropTitle.Text = "Полная вероятность";
            // 
            // FullPropMainDesc
            // 
            this.FullPropMainDesc.AutoSize = true;
            this.FullPropMainDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FullPropMainDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FullPropMainDesc.Location = new System.Drawing.Point(509, 72);
            this.FullPropMainDesc.Name = "FullPropMainDesc";
            this.FullPropMainDesc.Size = new System.Drawing.Size(360, 85);
            this.FullPropMainDesc.TabIndex = 31;
            this.FullPropMainDesc.Text = "Формула полной вероятности позволяет вычислить \r\nвероятность интересующего событи" +
    "я через\r\n условные вероятности этого события в предполо\r\nжении неких гипотез, а " +
    "также вероятностей этих \r\nгипотез.";
            // 
            // FullPropPicFormula
            // 
            this.FullPropPicFormula.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_21855_900igr_net;
            this.FullPropPicFormula.Location = new System.Drawing.Point(522, 173);
            this.FullPropPicFormula.Name = "FullPropPicFormula";
            this.FullPropPicFormula.Size = new System.Drawing.Size(318, 87);
            this.FullPropPicFormula.TabIndex = 32;
            this.FullPropPicFormula.TabStop = false;
            // 
            // pictureBox1_3
            // 
            this.pictureBox1_3.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_202759_www_avito_ru;
            this.pictureBox1_3.Location = new System.Drawing.Point(613, 356);
            this.pictureBox1_3.Name = "pictureBox1_3";
            this.pictureBox1_3.Size = new System.Drawing.Size(150, 39);
            this.pictureBox1_3.TabIndex = 28;
            this.pictureBox1_3.TabStop = false;
            // 
            // pictureBox1_2
            // 
            this.pictureBox1_2.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_20249_www_avito_ru;
            this.pictureBox1_2.Location = new System.Drawing.Point(581, 221);
            this.pictureBox1_2.Name = "pictureBox1_2";
            this.pictureBox1_2.Size = new System.Drawing.Size(217, 39);
            this.pictureBox1_2.TabIndex = 26;
            this.pictureBox1_2.TabStop = false;
            // 
            // pictureBox1_1
            // 
            this.pictureBox1_1.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_201851_www_matburo_ru;
            this.pictureBox1_1.Location = new System.Drawing.Point(610, 111);
            this.pictureBox1_1.Name = "pictureBox1_1";
            this.pictureBox1_1.Size = new System.Drawing.Size(139, 55);
            this.pictureBox1_1.TabIndex = 24;
            this.pictureBox1_1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_142859_www_avito_ru;
            this.pictureBox2.Location = new System.Drawing.Point(555, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 55);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.Web_capture_21_6_2022_141638_ru_wikipedia_org;
            this.pictureBox1.Location = new System.Drawing.Point(584, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 55);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 418);
            this.Controls.Add(this.FullPropPicFormula);
            this.Controls.Add(this.FullPropMainDesc);
            this.Controls.Add(this.FullPropTitle);
            this.Controls.Add(this.FullPropabilityRes);
            this.Controls.Add(this.pictureBox1_3);
            this.Controls.Add(this.labelFor2_2);
            this.Controls.Add(this.pictureBox1_2);
            this.Controls.Add(this.labelFor2_1);
            this.Controls.Add(this.pictureBox1_1);
            this.Controls.Add(this.LabelFor2);
            this.Controls.Add(this.NQDResult);
            this.Controls.Add(this.DispersionResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.sigma2);
            this.Controls.Add(this.Waiting2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeviationListElement);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.sigma);
            this.Controls.Add(this.Waiting);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.demo_picker);
            this.Controls.Add(this.graph);
            this.Name = "DemoForm";
            this.Text = "Superbest random demo";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullPropPicFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.ComboBox demo_picker;
        private System.Windows.Forms.TextBox Waiting;
        private System.Windows.Forms.TextBox sigma;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox DeviationListElement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Waiting2;
        private System.Windows.Forms.TextBox sigma2;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.TextBox DispersionResult;
        private System.Windows.Forms.TextBox NQDResult;
        private System.Windows.Forms.Label LabelFor2;
        private System.Windows.Forms.PictureBox pictureBox1_1;
        private System.Windows.Forms.Label labelFor2_1;
        private System.Windows.Forms.PictureBox pictureBox1_2;
        private System.Windows.Forms.Label labelFor2_2;
        private System.Windows.Forms.PictureBox pictureBox1_3;
        private System.Windows.Forms.TextBox FullPropabilityRes;
        private System.Windows.Forms.Label FullPropTitle;
        private System.Windows.Forms.Label FullPropMainDesc;
        private System.Windows.Forms.PictureBox FullPropPicFormula;
    }
}

