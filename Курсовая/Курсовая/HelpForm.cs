using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурСова
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Tag=="Add") tabControl1.SelectTab(1);
            if (treeView1.SelectedNode.Tag == "EditExstingLine") tabControl1.SelectTab(2);
            if (treeView1.SelectedNode.Tag == "AddLine") tabControl1.SelectTab(3);
            if (treeView1.SelectedNode.Tag == "Простые операции") tabControl1.SelectTab(4);
            if (treeView1.SelectedNode.Tag == "Поиск") tabControl1.SelectTab(5);
            if (treeView1.SelectedNode.Tag == "Удаление") tabControl1.SelectTab(6);
            if (treeView1.SelectedNode.Tag == "Сохранение") tabControl1.SelectTab(7);
            if (treeView1.SelectedNode.Tag == "Открытие") tabControl1.SelectTab(8);
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
