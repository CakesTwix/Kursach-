using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*TODO*/
namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string BD;
        public string Pass = Environment.CurrentDirectory + "\\Password.txt";
        //============================================================================================
        public void ViewBD()
        {
            try
            {
                int count = File.ReadAllLines(BD).Length;
                for (int i = 0; i < count; i++)
                {
                    string temp = File.ReadAllLines(BD)[i];
                    string[] temp1;
                    temp1 = temp.Split('|');
                    DatabaseTable.Rows.Add(temp1);
                    DatabaseTable.AutoResizeColumns();
                }
            }
            catch { }
        }
        public void WriteComboBox()
        {
            try
            {
                //Отобразить
                //Записать в комбо_бокс
                comboBoxListDB.Items.Clear();
                List<string> a = new List<string>();
                for (int i = 0; i < DatabaseTable.RowCount; i++)
                {
                    comboBoxListDB.Items.Add(DatabaseTable.Rows[i].Cells[1].Value);
                }
            }
            catch { };
        }
        //Запись/Открытие файла
        #region
        //============================================================================================
        //Запись в файл
        private void SaveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter BD = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
                try
                {
                    List<int> col_n = new List<int>();
                    foreach (DataGridViewColumn col in DatabaseTable.Columns)
                        if (col.Visible)
                        {
                            col_n.Add(col.Index);
                        }
                    int x = DatabaseTable.RowCount;
                    if (DatabaseTable.AllowUserToAddRows) x--;

                    for (int i = 0; i < x; i++)
                    {
                        for (int y = 0; y < col_n.Count; y++)
                            BD.Write(DatabaseTable[col_n[y], i].Value + "|");
                        BD.Write(" \r\n");
                    }
                    BD.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            }
        }
        //============================================================================================
        //Open
        //Открыть файл
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл .txt (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DatabaseTable.Rows.Clear();
                BD = openFileDialog.FileName;
                ViewBD();
                WriteComboBox();
            }
        }
        #endregion //
        //============================================================================================
        private void Button2_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" & FioBox.Text != "" & CarBox.Text != "")
            {
                string temp = IDBox.Text + "|" + FioBox.Text + "|" + CarBox.Text;
                temp += checkBoxView.Checked ? "|Есть|" : "|Отсуствует|";
                temp += checkBoxMoney.Checked ? "Оплачен|" : "Не оплачен|";
                //Debug.Text = temp;
                DatabaseTable.Rows.Add(temp.Split('|'));
                WriteComboBox();
            }
            else
            {
                MessageBox.Show(
                "Введите все поля!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        //============================================================================================
        //Поиск в таблице по столбцам
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int radioIndex = 0;
            if (radioID.Checked) radioIndex = 0;
            if (radioFio.Checked) radioIndex = 1;
            if (radioCar.Checked) radioIndex = 2;
            if (radioView.Checked) radioIndex = 3;
            if (radioMoney.Checked) radioIndex = 4;
            for (int i = 0; i < DatabaseTable.RowCount - 1; i++)
            {
                for (int j = 0; j < DatabaseTable.ColumnCount; j++)
                {
                    if (Convert.ToString(DatabaseTable.Rows[i].Cells[radioIndex].Value).Contains(SearchTextBox.Text))
                    {
                        DatabaseTable.Rows[i].Visible = true;
                        break;
                    }
                    else
                    {
                        DatabaseTable.Rows[i].Visible = false;
                    }
                }
            }
        }
        //Удаление строк и обновление comboBox
        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            WriteComboBox();
        }
        //Добавление в textBox для редактирования
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListDB.SelectedIndex != -1)
            {
                string temp = "";
                for (int j = 0; j < DatabaseTable.ColumnCount; j++)
                {
                    temp += DatabaseTable.Rows[comboBoxListDB.SelectedIndex].Cells[j].Value + "|";
                }
                List<string> ArrayTemp = new List<string>();
                ArrayTemp.AddRange(temp.Split('|'));
                IDBox.Text = ArrayTemp[0];
                FioBox.Text = ArrayTemp[1];
                CarBox.Text = ArrayTemp[2];
                if (ArrayTemp[3] == "Есть") { checkBoxView.Checked = true; } else checkBoxView.Checked = false;
                if (ArrayTemp[4] == "Оплачен") { checkBoxMoney.Checked = true; } else checkBoxMoney.Checked = false;
            }
        }
        //Очистка textBox
        private void Label1_Click(object sender, EventArgs e)
        {
            comboBoxListDB.SelectedIndex = -1;
            IDBox.Text = "";
            FioBox.Text = "";
            CarBox.Text = "";
        }
        //Редактировать через textBox
        private void Label7_Click(object sender, EventArgs e)
        {
            string ViewTemp, MoneyTemp = "";
            if (checkBoxView.Checked) ViewTemp = "Есть"; else ViewTemp = "Отсуствует";
            if (checkBoxMoney.Checked) MoneyTemp = "Оплачен"; else MoneyTemp = "Не  оплатил";
            string temp = IDBox.Text + "|" + FioBox.Text + "|" + CarBox.Text + "|" + ViewTemp + "|" + MoneyTemp + "|";
            string[] ArrayTemp = temp.Split('|');
            for (int i = 0; i < DatabaseTable.ColumnCount; i++) DatabaseTable.Rows[comboBoxListDB.SelectedIndex].Cells[i].Value = ArrayTemp[i];
            WriteComboBox();
        }
        //Удаление строк через comboBox & Label
        private void DeleteLabel_Click(object sender, EventArgs e)
        {
            DatabaseTable.Rows.RemoveAt(comboBoxListDB.SelectedIndex);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" & FioBox.Text != "" & CarBox.Text != "")
            {
                if (comboBoxListDB.SelectedIndex != -1)
                {
                    int SelectedIndex = comboBoxListDB.SelectedIndex + 1;
                    string ViewTemp, MoneyTemp = "";
                    if (checkBoxView.Checked) ViewTemp = "Есть"; else ViewTemp = "Отсуствует";
                    if (checkBoxMoney.Checked) MoneyTemp = "Оплатил"; else MoneyTemp = "Не оплатил";
                    DatabaseTable.Rows.Insert(SelectedIndex, IDBox.Text, FioBox.Text, CarBox.Text, ViewTemp, MoneyTemp);
                }
            }
            else
            {
                MessageBox.Show(
                "Введите все поля!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
        private void Label9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password password = new Password();
            password.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (КурСова.AboutBox1 box = new КурСова.AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            КурСова.HelpForm help = new КурСова.HelpForm();
            help.ShowDialog();
        }
//Всякие проверки для ввода в textBox
#region
        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)) e.Handled = true;
        }

        private void FioBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)) e.Handled = true;
        }
    }
#endregion
}
    //============================================================================================




