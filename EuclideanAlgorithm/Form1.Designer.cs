namespace EuclideanAlgorithm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.button_loops = new System.Windows.Forms.Button();
            this.numericUpDown_loops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Method = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_getGCD = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_count = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numberoRndNumbers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberoRndNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(52, 16);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_a.TabIndex = 1;
            this.numericUpDown_a.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(53, 42);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown_b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_b.TabIndex = 2;
            this.numericUpDown_b.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b=";
            // 
            // textBox_Results
            // 
            this.textBox_Results.Location = new System.Drawing.Point(12, 207);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Results.Size = new System.Drawing.Size(338, 173);
            this.textBox_Results.TabIndex = 6;
            // 
            // button_loops
            // 
            this.button_loops.Location = new System.Drawing.Point(255, 128);
            this.button_loops.Name = "button_loops";
            this.button_loops.Size = new System.Drawing.Size(94, 44);
            this.button_loops.TabIndex = 7;
            this.button_loops.Text = "Get GCD over loops";
            this.button_loops.UseVisualStyleBackColor = true;
            this.button_loops.Click += new System.EventHandler(this.button_loops_Click);
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Location = new System.Drawing.Point(254, 98);
            this.numericUpDown_loops.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_loops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_loops.Name = "numericUpDown_loops";
            this.numericUpDown_loops.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown_loops.TabIndex = 8;
            this.numericUpDown_loops.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "loops=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_Method
            // 
            this.comboBox_Method.FormattingEnabled = true;
            this.comboBox_Method.Items.AddRange(new object[] {
            "Subtraction",
            "Modulo",
            "PrimeFactors"});
            this.comboBox_Method.Location = new System.Drawing.Point(52, 68);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Method.TabIndex = 10;
            this.comboBox_Method.SelectedIndexChanged += new System.EventHandler(this.comboBox_Method_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Method:";
            // 
            // button_getGCD
            // 
            this.button_getGCD.Location = new System.Drawing.Point(53, 95);
            this.button_getGCD.Name = "button_getGCD";
            this.button_getGCD.Size = new System.Drawing.Size(120, 23);
            this.button_getGCD.TabIndex = 12;
            this.button_getGCD.Text = "Get GCD";
            this.button_getGCD.UseVisualStyleBackColor = true;
            this.button_getGCD.Click += new System.EventHandler(this.button_getGCD_Click);
            // 
            // chart1
            // 
            this.chart1.AccessibleName = "";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(370, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1005, 366);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // comboBox_count
            // 
            this.comboBox_count.FormattingEnabled = true;
            this.comboBox_count.Items.AddRange(new object[] {
            "Steps",
            "CPU-Time"});
            this.comboBox_count.Location = new System.Drawing.Point(52, 133);
            this.comboBox_count.Name = "comboBox_count";
            this.comboBox_count.Size = new System.Drawing.Size(121, 21);
            this.comboBox_count.TabIndex = 14;
            this.comboBox_count.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "rnd a";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "rnd b";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "randNum=";
            // 
            // numberoRndNumbers
            // 
            this.numberoRndNumbers.Location = new System.Drawing.Point(254, 74);
            this.numberoRndNumbers.Name = "numberoRndNumbers";
            this.numberoRndNumbers.Size = new System.Drawing.Size(95, 20);
            this.numberoRndNumbers.TabIndex = 19;
            this.numberoRndNumbers.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(110, 181);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 20;
            this.numericUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(110, 160);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMin.TabIndex = 21;
            this.numericUpDownMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "MIN=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "MAX=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numberoRndNumbers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_count);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_getGCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Method);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_loops);
            this.Controls.Add(this.button_loops);
            this.Controls.Add(this.textBox_Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.numericUpDown_a);
            this.Name = "Form1";
            this.Text = "GCD";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberoRndNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.Button button_loops;
        private System.Windows.Forms.NumericUpDown numericUpDown_loops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Method;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_getGCD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox_count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberoRndNumbers;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

