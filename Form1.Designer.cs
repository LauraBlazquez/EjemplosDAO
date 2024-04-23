namespace AC4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxYear = new ComboBox();
            comboBoxComarca = new ComboBox();
            textBoxPopulation = new TextBox();
            textBoxDomNet = new TextBox();
            textBoxEconomical = new TextBox();
            textBoxDomCap = new TextBox();
            textBoxTotal = new TextBox();
            Clean = new Button();
            Save = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelGT = new Label();
            labelAvg = new Label();
            labelHighest = new Label();
            labelLowest = new Label();
            leftArrow = new Button();
            rightArrow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Any";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 26);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Comarca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 26);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Població";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 90);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Domèstic xarxa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 90);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 5;
            label5.Text = "Activitats econòmiques\r\ni fonts pròpies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(282, 90);
            label6.Name = "label6";
            label6.Size = new Size(105, 30);
            label6.TabIndex = 6;
            label6.Text = "Consum domèstic\r\nper càpita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(282, 135);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 7;
            label7.Text = "Total";
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(18, 49);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(65, 23);
            comboBoxYear.TabIndex = 1;
            // 
            // comboBoxComarca
            // 
            comboBoxComarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComarca.FormattingEnabled = true;
            comboBoxComarca.Location = new Point(100, 49);
            comboBoxComarca.Name = "comboBoxComarca";
            comboBoxComarca.Size = new Size(112, 23);
            comboBoxComarca.TabIndex = 2;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(229, 49);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(100, 23);
            textBoxPopulation.TabIndex = 3;
            // 
            // textBoxDomNet
            // 
            textBoxDomNet.Location = new Point(18, 130);
            textBoxDomNet.Name = "textBoxDomNet";
            textBoxDomNet.Size = new Size(100, 23);
            textBoxDomNet.TabIndex = 4;
            // 
            // textBoxEconomical
            // 
            textBoxEconomical.Location = new Point(137, 130);
            textBoxEconomical.Name = "textBoxEconomical";
            textBoxEconomical.Size = new Size(100, 23);
            textBoxEconomical.TabIndex = 5;
            // 
            // textBoxDomCap
            // 
            textBoxDomCap.Location = new Point(393, 97);
            textBoxDomCap.Name = "textBoxDomCap";
            textBoxDomCap.Size = new Size(100, 23);
            textBoxDomCap.TabIndex = 6;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(393, 130);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(100, 23);
            textBoxTotal.TabIndex = 7;
            // 
            // Clean
            // 
            Clean.Location = new Point(324, 191);
            Clean.Name = "Clean";
            Clean.Size = new Size(75, 23);
            Clean.TabIndex = 8;
            Clean.Text = "Netejar";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += Clean_Click;
            // 
            // Save
            // 
            Save.Location = new Point(430, 191);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 9;
            Save.Text = "Guardar";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(13, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1030, 292);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBoxYear);
            groupBox1.Controls.Add(comboBoxComarca);
            groupBox1.Controls.Add(textBoxPopulation);
            groupBox1.Controls.Add(textBoxDomNet);
            groupBox1.Controls.Add(textBoxEconomical);
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(textBoxDomCap);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(labelGT);
            groupBox2.Controls.Add(labelAvg);
            groupBox2.Controls.Add(labelHighest);
            groupBox2.Controls.Add(labelLowest);
            groupBox2.Location = new Point(540, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 26);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 10;
            label8.Text = "Població > 20000 hab.:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 49);
            label9.Name = "label9";
            label9.Size = new Size(139, 15);
            label9.TabIndex = 12;
            label9.Text = "Consum domèstic mitjà:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 73);
            label10.Name = "label10";
            label10.Size = new Size(209, 15);
            label10.TabIndex = 14;
            label10.Text = "Consum domèstic per càpita més alt:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 96);
            label11.Name = "label11";
            label11.Size = new Size(218, 15);
            label11.TabIndex = 16;
            label11.Text = "Consum domèstic per càpita més baix:";
            // 
            // labelGT
            // 
            labelGT.BackColor = SystemColors.ControlLight;
            labelGT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGT.ForeColor = Color.FromArgb(0, 0, 192);
            labelGT.Location = new Point(154, 26);
            labelGT.Name = "labelGT";
            labelGT.Size = new Size(30, 15);
            labelGT.TabIndex = 11;
            // 
            // labelAvg
            // 
            labelAvg.BackColor = SystemColors.ControlLight;
            labelAvg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAvg.ForeColor = Color.FromArgb(0, 0, 192);
            labelAvg.Location = new Point(162, 49);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(30, 15);
            labelAvg.TabIndex = 13;
            // 
            // labelHighest
            // 
            labelHighest.BackColor = SystemColors.ControlLight;
            labelHighest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHighest.ForeColor = Color.FromArgb(0, 0, 192);
            labelHighest.Location = new Point(232, 73);
            labelHighest.Name = "labelHighest";
            labelHighest.Size = new Size(30, 15);
            labelHighest.TabIndex = 15;
            // 
            // labelLowest
            // 
            labelLowest.BackColor = SystemColors.ControlLight;
            labelLowest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLowest.ForeColor = Color.FromArgb(0, 0, 192);
            labelLowest.Location = new Point(241, 96);
            labelLowest.Name = "labelLowest";
            labelLowest.Size = new Size(30, 15);
            labelLowest.TabIndex = 17;
            // 
            // leftArrow
            // 
            leftArrow.Location = new Point(465, 528);
            leftArrow.Name = "leftArrow";
            leftArrow.Size = new Size(53, 23);
            leftArrow.TabIndex = 19;
            leftArrow.Text = "◀";
            leftArrow.UseVisualStyleBackColor = true;
            leftArrow.Click += leftArrow_Click;
            // 
            // rightArrow
            // 
            rightArrow.Location = new Point(536, 528);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(53, 23);
            rightArrow.TabIndex = 20;
            rightArrow.Text = "▶";
            rightArrow.UseVisualStyleBackColor = true;
            rightArrow.Click += rightArrow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 567);
            Controls.Add(rightArrow);
            Controls.Add(leftArrow);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(Save);
            Controls.Add(Clean);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxComarca;
        private TextBox textBoxPopulation;
        private TextBox textBoxDomNet;
        private TextBox textBoxEconomical;
        private TextBox textBoxDomCap;
        private TextBox textBoxTotal;
        private Button Clean;
        private Button Save;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelGT;
        private Label labelAvg;
        private Label labelHighest;
        private Label labelLowest;
        private Button leftArrow;
        private Button rightArrow;
    }
}
