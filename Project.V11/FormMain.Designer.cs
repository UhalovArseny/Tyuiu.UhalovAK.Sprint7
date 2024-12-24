namespace Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            toolTip1 = new ToolTip(components);
            buttonChart_UAK = new Button();
            buttonReboot_UAK = new Button();
            buttonDelet_UAK = new Button();
            buttonDone_UAK = new Button();
            buttonReward_UAK = new Button();
            chartInfo_UAK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxInputName_UAK = new TextBox();
            textBoxInputFullname_UAK = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePickerInput_UAK = new DateTimePicker();
            label4 = new Label();
            textBoxInputSurname_UAK = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            dataGridViewReward_UAK = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            buttonHelp_UAK = new Button();
            ((System.ComponentModel.ISupportInitialize)chartInfo_UAK).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReward_UAK).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonChart_UAK
            // 
            buttonChart_UAK.Image = (Image)resources.GetObject("buttonChart_UAK.Image");
            buttonChart_UAK.Location = new Point(169, 9);
            buttonChart_UAK.Name = "buttonChart_UAK";
            buttonChart_UAK.Size = new Size(71, 58);
            buttonChart_UAK.TabIndex = 6;
            toolTip1.SetToolTip(buttonChart_UAK, "Изменить график");
            buttonChart_UAK.UseVisualStyleBackColor = true;
            buttonChart_UAK.Click += buttonChart_UAK_Click;
            // 
            // buttonReboot_UAK
            // 
            buttonReboot_UAK.BackColor = SystemColors.Control;
            buttonReboot_UAK.Image = (Image)resources.GetObject("buttonReboot_UAK.Image");
            buttonReboot_UAK.Location = new Point(246, 9);
            buttonReboot_UAK.Name = "buttonReboot_UAK";
            buttonReboot_UAK.Size = new Size(78, 58);
            buttonReboot_UAK.TabIndex = 12;
            toolTip1.SetToolTip(buttonReboot_UAK, "Обновить график");
            buttonReboot_UAK.UseVisualStyleBackColor = false;
            buttonReboot_UAK.Click += buttonReboot_UAK_Click;
            // 
            // buttonDelet_UAK
            // 
            buttonDelet_UAK.Location = new Point(452, 84);
            buttonDelet_UAK.Name = "buttonDelet_UAK";
            buttonDelet_UAK.Size = new Size(107, 28);
            buttonDelet_UAK.TabIndex = 20;
            buttonDelet_UAK.Text = "Исключить";
            toolTip1.SetToolTip(buttonDelet_UAK, "Исключить строку с данными о сотруднике из файла");
            buttonDelet_UAK.UseVisualStyleBackColor = true;
            buttonDelet_UAK.Click += buttonDelet_UAK_Click;
            // 
            // buttonDone_UAK
            // 
            buttonDone_UAK.Location = new Point(565, 84);
            buttonDone_UAK.Name = "buttonDone_UAK";
            buttonDone_UAK.Size = new Size(134, 28);
            buttonDone_UAK.TabIndex = 19;
            buttonDone_UAK.Text = "Добавить";
            toolTip1.SetToolTip(buttonDone_UAK, "Добавить нового сотрудника в файл");
            buttonDone_UAK.UseVisualStyleBackColor = true;
            buttonDone_UAK.Click += buttonDone_UAK_Click;
            // 
            // buttonReward_UAK
            // 
            buttonReward_UAK.Location = new Point(232, 28);
            buttonReward_UAK.Name = "buttonReward_UAK";
            buttonReward_UAK.Size = new Size(123, 43);
            buttonReward_UAK.TabIndex = 6;
            buttonReward_UAK.Text = "Рассчитать ";
            toolTip1.SetToolTip(buttonReward_UAK, "Посчитать года с начала работы сотрудника");
            buttonReward_UAK.UseVisualStyleBackColor = true;
            buttonReward_UAK.Click += buttonReward_UAK_Click;
            // 
            // chartInfo_UAK
            // 
            chartArea2.Name = "ChartArea1";
            chartInfo_UAK.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartInfo_UAK.Legends.Add(legend2);
            chartInfo_UAK.Location = new Point(430, 85);
            chartInfo_UAK.Name = "chartInfo_UAK";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartInfo_UAK.Series.Add(series2);
            chartInfo_UAK.Size = new Size(309, 294);
            chartInfo_UAK.TabIndex = 7;
            chartInfo_UAK.Text = "chart1";
            // 
            // textBoxInputName_UAK
            // 
            textBoxInputName_UAK.Location = new Point(55, 37);
            textBoxInputName_UAK.Name = "textBoxInputName_UAK";
            textBoxInputName_UAK.Size = new Size(120, 23);
            textBoxInputName_UAK.TabIndex = 8;
            // 
            // textBoxInputFullname_UAK
            // 
            textBoxInputFullname_UAK.Location = new Point(492, 36);
            textBoxInputFullname_UAK.Name = "textBoxInputFullname_UAK";
            textBoxInputFullname_UAK.Size = new Size(191, 23);
            textBoxInputFullname_UAK.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDelet_UAK);
            groupBox1.Controls.Add(buttonDone_UAK);
            groupBox1.Controls.Add(dateTimePickerInput_UAK);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxInputSurname_UAK);
            groupBox1.Controls.Add(textBoxInputFullname_UAK);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxInputName_UAK);
            groupBox1.Location = new Point(12, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 129);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Менеджмент сотрудников:";
            // 
            // dateTimePickerInput_UAK
            // 
            dateTimePickerInput_UAK.Location = new Point(154, 84);
            dateTimePickerInput_UAK.Name = "dateTimePickerInput_UAK";
            dateTimePickerInput_UAK.Size = new Size(140, 23);
            dateTimePickerInput_UAK.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 84);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 17;
            label4.Text = "Дата трудоустройства:";
            // 
            // textBoxInputSurname_UAK
            // 
            textBoxInputSurname_UAK.Location = new Point(267, 36);
            textBoxInputSurname_UAK.Name = "textBoxInputSurname_UAK";
            textBoxInputSurname_UAK.Size = new Size(124, 23);
            textBoxInputSurname_UAK.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 39);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 40);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 13;
            label2.Text = "Фамилия:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 12;
            label1.Text = "Имя:";
            label1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(buttonReward_UAK);
            groupBox2.Controls.Add(dataGridViewReward_UAK);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 373);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(6, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 43);
            textBox1.TabIndex = 7;
            textBox1.Text = "Рассчитать выслугу лет сотрудника:";
            // 
            // dataGridViewReward_UAK
            // 
            dataGridViewReward_UAK.AllowUserToAddRows = false;
            dataGridViewReward_UAK.AllowUserToDeleteRows = false;
            dataGridViewReward_UAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReward_UAK.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewReward_UAK.Location = new Point(0, 99);
            dataGridViewReward_UAK.Name = "dataGridViewReward_UAK";
            dataGridViewReward_UAK.ReadOnly = true;
            dataGridViewReward_UAK.RowHeadersVisible = false;
            dataGridViewReward_UAK.Size = new Size(412, 268);
            dataGridViewReward_UAK.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ФИО";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 59;
            // 
            // Column2
            // 
            Column2.HeaderText = "Дата";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Выслуга лет";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Награда";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonHelp_UAK);
            groupBox3.Controls.Add(buttonChart_UAK);
            groupBox3.Controls.Add(buttonReboot_UAK);
            groupBox3.Location = new Point(421, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 373);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // buttonHelp_UAK
            // 
            buttonHelp_UAK.Image = (Image)resources.GetObject("buttonHelp_UAK.Image");
            buttonHelp_UAK.Location = new Point(9, 9);
            buttonHelp_UAK.Name = "buttonHelp_UAK";
            buttonHelp_UAK.Size = new Size(68, 58);
            buttonHelp_UAK.TabIndex = 13;
            buttonHelp_UAK.UseVisualStyleBackColor = true;
            buttonHelp_UAK.Click += buttonHelp_UAK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 532);
            Controls.Add(groupBox2);
            Controls.Add(chartInfo_UAK);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "FormMain";
            Text = "Отдел кадров";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chartInfo_UAK).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReward_UAK).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private Button buttonChart_UAK;
        private TextBox textBoxInputName_UAK;
        private TextBox textBoxInputFullname_UAK;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxInputSurname_UAK;
        private Button buttonDone_UAK;
        private DateTimePicker dateTimePickerInput_UAK;
        private Button buttonDelet_UAK;
        private Button buttonReboot_UAK;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewReward_UAK;
        private Button buttonReward_UAK;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_UAK;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBox1;
        private Button buttonHelp_UAK;
    }
}
