using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V11.Lib;

namespace Project.V11
{
    public partial class FormChart : Form
    {
        DataService ds = new DataService();
        //string chartPath = $@"{Directory.GetCurrentDirectory()}\Сезонность сотрудников.txt";
        string chartPath = @"C:\ForSprint7\Сезонность сотрудников.txt"; // Путь к файлу
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в каждое поле требуемое количество сотрудников. Поля не должны оставаться пустыми. В случае ненадобности сотрудников, введите 0.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            double[] serviceArray = ds.LoadFromDataFile(chartPath);

            textBoxJanuaryInput_UAK.Text = Convert.ToString(serviceArray[0]);
            textBoxFebruaryInput_UAK.Text = Convert.ToString(serviceArray[1]);
            textBoxMarchInput_UAK.Text = Convert.ToString(serviceArray[2]);
            textBoxAprilInput_UAK.Text = Convert.ToString(serviceArray[3]);
            textBoxMayInput_UAK.Text = Convert.ToString(serviceArray[4]);
            textBoxJuneInput_UAK.Text = Convert.ToString(serviceArray[5]);
            textBoxJulyInput_UAK.Text = Convert.ToString(serviceArray[6]);
            textBoxAugustInput_UAK.Text = Convert.ToString(serviceArray[7]);
            textBoxSeptemberInput_UAK.Text = Convert.ToString(serviceArray[8]);
            textBoxOctoberInput_UAK.Text = Convert.ToString(serviceArray[9]);
            textBoxNovemberInput_UAK.Text = Convert.ToString(serviceArray[10]);
            textBoxDecemberInput_UAK.Text = Convert.ToString(serviceArray[11]);
        }

        private void buttonOk_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDecemberInput_UAK.Text == null || textBoxJanuaryInput_UAK.Text == null || textBoxFebruaryInput_UAK.Text == null || textBoxMarchInput_UAK.Text == null || textBoxAprilInput_UAK.Text == null || textBoxMayInput_UAK.Text == null || textBoxJuneInput_UAK.Text == null || textBoxJulyInput_UAK.Text == null || textBoxAugustInput_UAK.Text == null || textBoxSeptemberInput_UAK.Text == null || textBoxOctoberInput_UAK.Text == null || textBoxNovemberInput_UAK.Text == null)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToDouble(textBoxDecemberInput_UAK.Text) < 0 || Convert.ToDouble(textBoxJanuaryInput_UAK.Text) < 0 || Convert.ToDouble(textBoxFebruaryInput_UAK.Text) < 0 || Convert.ToDouble(textBoxMarchInput_UAK.Text) < 0 || Convert.ToDouble(textBoxAprilInput_UAK.Text) < 0 || Convert.ToDouble(textBoxMayInput_UAK.Text) < 0 || Convert.ToDouble(textBoxJuneInput_UAK.Text) < 0 || Convert.ToDouble(textBoxJulyInput_UAK.Text) < 0 || Convert.ToDouble(textBoxAugustInput_UAK.Text) < 0 || Convert.ToDouble(textBoxSeptemberInput_UAK.Text) < 0 || Convert.ToDouble(textBoxOctoberInput_UAK.Text) < 0 || Convert.ToDouble(textBoxNovemberInput_UAK.Text) < 0)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] res = new string[12] { textBoxJanuaryInput_UAK.Text, textBoxFebruaryInput_UAK.Text, textBoxMarchInput_UAK.Text, textBoxAprilInput_UAK.Text, textBoxMayInput_UAK.Text, textBoxJuneInput_UAK.Text, textBoxJulyInput_UAK.Text, textBoxAugustInput_UAK.Text, textBoxSeptemberInput_UAK.Text, textBoxOctoberInput_UAK.Text, textBoxNovemberInput_UAK.Text, textBoxDecemberInput_UAK.Text };
                    System.IO.File.WriteAllText(chartPath, textBoxJanuaryInput_UAK.Text + "\n" + textBoxFebruaryInput_UAK.Text + "\n" + textBoxMarchInput_UAK.Text + "\n" + textBoxAprilInput_UAK.Text + "\n" + textBoxMayInput_UAK.Text + "\n" + textBoxJuneInput_UAK.Text + "\n" + textBoxJulyInput_UAK.Text + "\n" + textBoxAugustInput_UAK.Text + "\n" + textBoxSeptemberInput_UAK.Text + "\n" + textBoxOctoberInput_UAK.Text + "\n" + textBoxNovemberInput_UAK.Text + "\n"+ textBoxDecemberInput_UAK.Text );
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Возможно, некоторые данные некорректны. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxJanuaryInput_UAK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
