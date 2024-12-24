namespace Project.V11
{
    partial class FormAbout
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 15);
            label1.TabIndex = 0;
            label1.Text = "Разработчик: Ухалов Арсений Константинович";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Группа АСОиУБ-24-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(303, 15);
            label3.TabIndex = 2;
            label3.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(282, 15);
            label4.TabIndex = 3;
            label4.Text = "Тюменский Индустриальный Университет (с)2024\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 95);
            label5.Name = "label5";
            label5.Size = new Size(261, 30);
            label5.TabIndex = 4;
            label5.Text = "Высшая Школа Цифровых Технологий(с)2024\r\n\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(225, 15);
            label6.TabIndex = 5;
            label6.Text = "Внутреннее имя: Tyuiu.UhalovAK.Sprint7";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(349, 171);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAbout";
            Text = "FormAbout";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}