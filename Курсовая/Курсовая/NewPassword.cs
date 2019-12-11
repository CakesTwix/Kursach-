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

namespace Курсовая
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Pass = Environment.CurrentDirectory + "\\Password.txt";

            if (textBox1.Text == textBox2.Text && textBox1.Text == File.ReadAllLines(Pass)[0] && File.ReadAllLines(Pass)[0] == textBox2.Text)
            {
                StreamWriter Password = new StreamWriter(Pass);
                Password.Write(textBox3.Text);
                Password.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                "Неправильные данные!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
