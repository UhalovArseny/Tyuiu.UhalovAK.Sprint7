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
        string chartPath = @"C:\ForSprint7\���������� �����������.txt";
        //string chartPath = $@"{Directory.GetCurrentDirectory()}\���������� �����������.txt";
        string employeesPath = @"C:\ForSprint7\����������.txt";
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
                // ���������, ���������� �� ����������, ���� ��� - ������� ��
                string directoryPath = Path.GetDirectoryName(chartPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // ���������, ���������� �� ����
                if (File.Exists(chartPath))
                {
                    chartInfo_UAK.ChartAreas[0].AxisX.Title = "����/�����/����/�����";
                    chartInfo_UAK.ChartAreas[0].AxisY.Title = "���-�� �����������";

                    chartInfo_UAK.Series[0].Points.Clear();

                    double[] serviceArray = ds.LoadFromDataFile(chartPath);
                    for (int i = 0; i < 12; i++)
                    {
                        chartInfo_UAK.Series[0].Points.AddXY(i + 1, serviceArray[i]);
                    }
                }
                else
                {
                    // ������� ���� � ���������� ����������, ���� �� �� ����������
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
                MessageBox.Show($"������ ��� �������� �������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // �������� ������ �� ��������� ����� � �������� ������ ����
                string name = textBoxInputName_UAK.Text.Trim();
                string surname = textBoxInputSurname_UAK.Text.Trim();
                string fullName = textBoxInputFullname_UAK.Text.Trim();
                DateTime date = dateTimePickerInput_UAK.Value;

                // ���������, ��� ��� ���� ���������
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("����������, ��������� ��� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ��������� ������ ��� ������ � ����
                string record = $"{name} {surname} {fullName} {date.ToShortDateString()}";

                // ���������, ���������� �� ����������, ���� ��� - ������� ��
                string directoryPath = Path.GetDirectoryName(employeesPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // ���������� ������ � ����
                using (StreamWriter sw = new StreamWriter(employeesPath, true)) // true ��� ���������� ������
                {
                    sw.WriteLine(record);
                }

                MessageBox.Show("������ ������� ���������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ������� ����� ����� ��������� ����������
                textBoxInputName_UAK.Clear();
                textBoxInputSurname_UAK.Clear();
                textBoxInputFullname_UAK.Clear();
                dateTimePickerInput_UAK.Value = DateTime.Now; // ������������� ������� �����
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelet_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� ������ �� ��������� �����
                string name = textBoxInputName_UAK.Text.Trim();
                string surname = textBoxInputSurname_UAK.Text.Trim();
                string fullName = textBoxInputFullname_UAK.Text.Trim();

                // ���������, ��� ��� ���� ���������
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("����������, ��������� ��� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ���������, ���������� �� ����
                if (!File.Exists(employeesPath))
                {
                    MessageBox.Show("���� �� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ������ ��� ������ �� �����
                var lines = File.ReadAllLines(employeesPath).ToList();

                // ��������� ������ ��� ������
                string recordToDelete = $"{name} {surname} {fullName}";

                // ���������, ���������� �� ����� ������ � ������
                if (lines.RemoveAll(line => line.StartsWith(recordToDelete)) == 0)
                {
                    MessageBox.Show("��������� �� ������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // ���������� ������� ���������� ������ � ����
                File.WriteAllLines(employeesPath, lines);

                MessageBox.Show("������ � ���������� ������� �������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ������� ����� ����� ��������� ��������
                textBoxInputName_UAK.Clear();
                textBoxInputSurname_UAK.Clear();
                textBoxInputFullname_UAK.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReward_UAK_Click(object sender, EventArgs e)
        {
            try
            {
                // ������� DataGridView ����� ����������� ����� ������
                dataGridViewReward_UAK.Rows.Clear();

                // ���� � �����
                string filePath = @"C:\ForSprint7\����������.txt";

                // ������ ������ �� �����
                string[] lines = System.IO.File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // ���������� ������ �� ��� � ����
                    
                    int lastSpaceIndex = line.LastIndexOf(' ');
                    if (lastSpaceIndex != -1)
                    {
                        string fio = line.Substring(0, lastSpaceIndex).Trim(); // ���
                        string dateString = line.Substring(lastSpaceIndex + 1).Trim(); // ����

                        // ������ ���� � DateTime
                        if (DateTime.TryParseExact(dateString, "dd.MM.yyyy",
                                                    System.Globalization.CultureInfo.InvariantCulture,
                                                    System.Globalization.DateTimeStyles.None,
                                                    out DateTime date))
                        {
                            // ������� ����� ����������� ����� � ����� �� �����
                            TimeSpan timeSpan = DateTime.Now - date;
                            int daysPassed = (int)timeSpan.TotalDays;
                            int yearsPassed = DateTime.Now.Year - date.Year;
                            if (DateTime.Now < date.AddYears(yearsPassed)) yearsPassed--;

                            
                            string timePassed = $"��� - {yearsPassed}";

                            
                            string message;
                            if (yearsPassed < 1)
                            {
                                message = "...";
                            }
                            else if (yearsPassed == 1)
                            {
                                message = "�������";
                            }
                            else if (yearsPassed == 2)
                            {
                                message = "���������� ������";
                            }
                            else if (yearsPassed == 3)
                            {
                                message = "������� �����";
                            }
                            else if (yearsPassed == 4)
                            {
                                message = "������� �����";
                            }
                            else if (yearsPassed >= 5)
                            {
                                message = "����� �����";
                            }
                            else
                            {
                                message = "...";
                            }

                            
                            dataGridViewReward_UAK.Rows.Add(fio, date.ToShortDateString(), timePassed, message);
                        }
                        else
                        {
                            MessageBox.Show($"������ ������� ����: '{dateString}' � ������: '{line}'", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"������ ������� ������: '{line}'. ��������� '��� ����'", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������� ������ ��� ������ �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
