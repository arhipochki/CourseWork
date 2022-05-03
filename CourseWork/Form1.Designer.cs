namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.solveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.funcTextBox = new System.Windows.Forms.TextBox();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.saveSeriesCheckBox = new System.Windows.Forms.CheckBox();
            this.legendTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getPathBtn = new System.Windows.Forms.Button();
            this.tPathLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.solveChart)).BeginInit();
            this.SuspendLayout();
            // 
            // solveChart
            // 
            chartArea4.Name = "ChartArea1";
            this.solveChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.solveChart.Legends.Add(legend4);
            this.solveChart.Location = new System.Drawing.Point(12, 110);
            this.solveChart.Name = "solveChart";
            this.solveChart.Size = new System.Drawing.Size(1049, 547);
            this.solveChart.TabIndex = 0;
            this.solveChart.Text = "chart1";
            // 
            // funcTextBox
            // 
            this.funcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funcTextBox.Location = new System.Drawing.Point(226, 73);
            this.funcTextBox.Name = "funcTextBox";
            this.funcTextBox.Size = new System.Drawing.Size(454, 26);
            this.funcTextBox.TabIndex = 1;
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(1220, 115);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(37, 20);
            this.x0TextBox.TabIndex = 2;
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(1220, 152);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(100, 20);
            this.epsTextBox.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(1214, 605);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(106, 52);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходная функция f(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1216, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1134, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Точность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1279, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "X1";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(1283, 115);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(37, 20);
            this.x1TextBox.TabIndex = 9;
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(1220, 266);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(56, 17);
            this.gridCheckBox.TabIndex = 10;
            this.gridCheckBox.Text = "Сетка";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // saveSeriesCheckBox
            // 
            this.saveSeriesCheckBox.AutoSize = true;
            this.saveSeriesCheckBox.Location = new System.Drawing.Point(1220, 289);
            this.saveSeriesCheckBox.Name = "saveSeriesCheckBox";
            this.saveSeriesCheckBox.Size = new System.Drawing.Size(108, 17);
            this.saveSeriesCheckBox.TabIndex = 11;
            this.saveSeriesCheckBox.Text = "Сохранять ряды";
            this.saveSeriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // legendTextBox
            // 
            this.legendTextBox.Location = new System.Drawing.Point(1220, 179);
            this.legendTextBox.Name = "legendTextBox";
            this.legendTextBox.Size = new System.Drawing.Size(100, 20);
            this.legendTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1134, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Легенда";
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(1283, 230);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(37, 20);
            this.y1TextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1279, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1216, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Y0";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(1220, 230);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(37, 20);
            this.y0TextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1093, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пределы по Y\r\n(необязательно)\r\n";
            // 
            // getPathBtn
            // 
            this.getPathBtn.Location = new System.Drawing.Point(1245, 38);
            this.getPathBtn.Name = "getPathBtn";
            this.getPathBtn.Size = new System.Drawing.Size(75, 23);
            this.getPathBtn.TabIndex = 19;
            this.getPathBtn.Text = "Open Dir";
            this.getPathBtn.UseVisualStyleBackColor = true;
            this.getPathBtn.Click += new System.EventHandler(this.getPathBtn_Click);
            // 
            // tPathLabel
            // 
            this.tPathLabel.AutoSize = true;
            this.tPathLabel.Location = new System.Drawing.Point(951, 38);
            this.tPathLabel.Name = "tPathLabel";
            this.tPathLabel.Size = new System.Drawing.Size(32, 13);
            this.tPathLabel.TabIndex = 20;
            this.tPathLabel.Text = "Path:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(998, 38);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(24, 13);
            this.pathLabel.TabIndex = 21;
            this.pathLabel.Text = "tmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 709);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.tPathLabel);
            this.Controls.Add(this.getPathBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.y1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.legendTextBox);
            this.Controls.Add(this.saveSeriesCheckBox);
            this.Controls.Add(this.gridCheckBox);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.epsTextBox);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.funcTextBox);
            this.Controls.Add(this.solveChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.solveChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart solveChart;
        private System.Windows.Forms.TextBox funcTextBox;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.CheckBox saveSeriesCheckBox;
        private System.Windows.Forms.TextBox legendTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button getPathBtn;
        private System.Windows.Forms.Label tPathLabel;
        private System.Windows.Forms.Label pathLabel;
    }
}

