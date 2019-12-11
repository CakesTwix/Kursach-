using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Password : Form
    {
        string Pass = Environment.CurrentDirectory + "\\Password.txt";
        public Password()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form2 newPass = new Form2();
            newPass.ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PassBox.Text == File.ReadAllLines(Pass)[0]) { button1.Enabled = true; } else button1.Enabled = false;
            }
            catch
            {
                MessageBox.Show(
                "Не найден файл",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
