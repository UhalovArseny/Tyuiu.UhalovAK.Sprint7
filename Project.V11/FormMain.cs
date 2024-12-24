using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Project.V11.Lib;

namespace Project.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string chartPath = @"C:\ForSprint7\Сезонность сотрудников.txt";
        //string chartPath = $@"{Directory.GetCurrentDirectory()}\Сезонность сотрудников.txt";
        string employeesPath = @"C:\ForSprint7\Сотрудники.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        { LoadChartData(); }
        private void buttonReboot_UAK_Click(object sender, EventArgs e)
        { LoadChartData(); }

        private void LoadChartData()
        {
            try
            {
                // Проверяем, существует ли директория, если нет - создаем ее
                string directoryPath = Path.GetDirectoryName(chartPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Проверяем, существует ли файл
                if (File.Exists(chartPath))
                {
                    chartInfo_UAK.ChartAreas[0].AxisX.Title = "Зима/Весна/Лето/Осень";
                    chartInfo_UAK.ChartAreas[0].AxisY.Title = "Кол-во сотрудников";

                    chartInfo_UAK.Series[0].Points.Clear();

                    double[] serviceArray = ds.LoadFromDataFile(chartPath);
                    for (int i = 0; i < 12; i++)
                    {
                        chartInfo_UAK.Series[0].Points.AddXY(i + 1, serviceArray[i]);
                    }
                }
                else
                {
                    // Создаем файл с начальными значениями, если он не существует
                    File.WriteAllText(chartPath, "1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1");
                    double[] serviceArray = ds.LoadFromDataFile(chartPath);
                    for (int i = 0; i < 12; i++)
                    {
                        chartInfo_UAK.Series[0].Points.AddXY(i + 1, serviceArray[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке графика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonChart_UAK_Click(object sender, EventArgs e)
        {
            FormChart ched = new FormChart();
            ched.ShowDialog();
        }

        private void buttonDone_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей и элемента выбора даты
                string name = textBoxInputName_UAK.Text.Trim();
                string surname = textBoxInputSurname_UAK.Text.Trim();
                string fullName = textBoxInputFullname_UAK.Text.Trim();
                DateTime date = dateTimePickerInput_UAK.Value;

                // Проверяем, что все поля заполнены
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Формируем строку для записи в файл
                string record = $"{name} {surname} {fullName} {date.ToShortDateString()}";

                // Проверяем, существует ли директория, если нет - создаем ее
                string directoryPath = Path.GetDirectoryName(employeesPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Записываем данные в файл
                using (StreamWriter sw = new StreamWriter(employeesPath, true)) // true для добавления данных
                {
                    sw.WriteLine(record);
                }

                MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей после успешного сохранения
                textBoxInputName_UAK.Clear();
                textBoxInputSurname_UAK.Clear();
                textBoxInputFullname_UAK.Clear();
                dateTimePickerInput_UAK.Value = DateTime.Now; // Устанавливаем текущее время
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelet_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей
                string name = textBoxInputName_UAK.Text.Trim();
                string surname = textBoxInputSurname_UAK.Text.Trim();
                string fullName = textBoxInputFullname_UAK.Text.Trim();

                // Проверяем, что все поля заполнены
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Проверяем, существует ли файл
                if (!File.Exists(employeesPath))
                {
                    MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Читаем все строки из файла
                var lines = File.ReadAllLines(employeesPath).ToList();

                // Формируем строку для поиска
                string recordToDelete = $"{name} {surname} {fullName}";

                // Проверяем, существует ли такая строка в списке
                if (lines.RemoveAll(line => line.StartsWith(recordToDelete)) == 0)
                {
                    MessageBox.Show("Сотрудник не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Записываем обратно оставшиеся строки в файл
                File.WriteAllLines(employeesPath, lines);

                MessageBox.Show("Данные о сотруднике успешно удалены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей после успешного удаления
                textBoxInputName_UAK.Clear();
                textBoxInputSurname_UAK.Clear();
                textBoxInputFullname_UAK.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReward_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем DataGridView перед добавлением новых данных
                dataGridViewReward_UAK.Rows.Clear();

                // Путь к файлу
                string filePath = @"C:\ForSprint7\Сотрудники.txt";

                // Чтение данных из файла
                string[] lines = System.IO.File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Разделение строки на ФИО и дату
                    
                    int lastSpaceIndex = line.LastIndexOf(' ');
                    if (lastSpaceIndex != -1)
                    {
                        string fio = line.Substring(0, lastSpaceIndex).Trim(); // ФИО
                        string dateString = line.Substring(lastSpaceIndex + 1).Trim(); // Дата

                        // строку даты в DateTime
                        if (DateTime.TryParseExact(dateString, "dd.MM.yyyy",
                                                    System.Globalization.CultureInfo.InvariantCulture,
                                                    System.Globalization.DateTimeStyles.None,
                                                    out DateTime date))
                        {
                            // разница между сегодняшней датой и датой из файла
                            TimeSpan timeSpan = DateTime.Now - date;
                            int daysPassed = (int)timeSpan.TotalDays;
                            int yearsPassed = DateTime.Now.Year - date.Year;
                            if (DateTime.Now < date.AddYears(yearsPassed)) yearsPassed--;

                            
                            string timePassed = $"лет - {yearsPassed}";

                            
                            string message;
                            if (yearsPassed < 1)
                            {
                                message = "...";
                            }
                            else if (yearsPassed == 1)
                            {
                                message = "Пирожок";
                            }
                            else if (yearsPassed == 2)
                            {
                                message = "Шоколодная медаль";
                            }
                            else if (yearsPassed == 3)
                            {
                                message = "Немного денег";
                            }
                            else if (yearsPassed == 4)
                            {
                                message = "Немного денег";
                            }
                            else if (yearsPassed >= 5)
                            {
                                message = "Много денег";
                            }
                            else
                            {
                                message = "...";
                            }

                            
                            dataGridViewReward_UAK.Rows.Add(fio, date.ToShortDateString(), timePassed, message);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка формата даты: '{dateString}' в строке: '{line}'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка формата строки: '{line}'. Ожидалось 'ФИО Дата'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_UAK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxInput_UAK_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
