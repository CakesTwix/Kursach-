namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlDataBase = new System.Windows.Forms.TabControl();
            this.tabPageDatabaseTable = new System.Windows.Forms.TabPage();
            this.DatabaseTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stojanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxAddAndEdit = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.comboBoxListDB = new System.Windows.Forms.ComboBox();
            this.LabelAddAfter = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.FioBox = new System.Windows.Forms.TextBox();
            this.CarBox = new System.Windows.Forms.TextBox();
            this.checkBoxMoney = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxView = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuDataBase = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioView = new System.Windows.Forms.RadioButton();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioFio = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.tabControlDataBase.SuspendLayout();
            this.tabPageDatabaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxAddAndEdit.SuspendLayout();
            this.menuDataBase.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDataBase
            // 
            this.tabControlDataBase.Controls.Add(this.tabPageDatabaseTable);
            this.tabControlDataBase.Controls.Add(this.tabPage2);
            this.tabControlDataBase.Location = new System.Drawing.Point(9, 23);
            this.tabControlDataBase.Multiline = true;
            this.tabControlDataBase.Name = "tabControlDataBase";
            this.tabControlDataBase.SelectedIndex = 0;
            this.tabControlDataBase.Size = new System.Drawing.Size(538, 302);
            this.tabControlDataBase.TabIndex = 4;
            // 
            // tabPageDatabaseTable
            // 
            this.tabPageDatabaseTable.Controls.Add(this.DatabaseTable);
            this.tabPageDatabaseTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatabaseTable.Name = "tabPageDatabaseTable";
            this.tabPageDatabaseTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabaseTable.Size = new System.Drawing.Size(530, 276);
            this.tabPageDatabaseTable.TabIndex = 0;
            this.tabPageDatabaseTable.Text = "Список";
            this.tabPageDatabaseTable.UseVisualStyleBackColor = true;
            // 
            // DatabaseTable
            // 
            this.DatabaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DatabaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fio,
            this.Car,
            this.Stojanka,
            this.Money});
            this.DatabaseTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DatabaseTable.Location = new System.Drawing.Point(-1, 0);
            this.DatabaseTable.Name = "DatabaseTable";
            this.DatabaseTable.Size = new System.Drawing.Size(531, 280);
            this.DatabaseTable.TabIndex = 0;
            this.DatabaseTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // fio
            // 
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 59;
            // 
            // Car
            // 
            this.Car.HeaderText = "Автомобиль";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            this.Car.Width = 94;
            // 
            // Stojanka
            // 
            this.Stojanka.HeaderText = "Наличие на стоянке";
            this.Stojanka.Name = "Stojanka";
            this.Stojanka.ReadOnly = true;
            this.Stojanka.Width = 123;
            // 
            // Money
            // 
            this.Money.HeaderText = "Оплата";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            this.Money.Width = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxAddAndEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение/Добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddAndEdit
            // 
            this.groupBoxAddAndEdit.Controls.Add(this.button2);
            this.groupBoxAddAndEdit.Controls.Add(this.DeleteLabel);
            this.groupBoxAddAndEdit.Controls.Add(this.LabelEdit);
            this.groupBoxAddAndEdit.Controls.Add(this.labelClear);
            this.groupBoxAddAndEdit.Controls.Add(this.comboBoxListDB);
            this.groupBoxAddAndEdit.Controls.Add(this.LabelAddAfter);
            this.groupBoxAddAndEdit.Controls.Add(this.IDBox);
            this.groupBoxAddAndEdit.Controls.Add(this.FioBox);
            this.groupBoxAddAndEdit.Controls.Add(this.CarBox);
            this.groupBoxAddAndEdit.Controls.Add(this.checkBoxMoney);
            this.groupBoxAddAndEdit.Controls.Add(this.label3);
            this.groupBoxAddAndEdit.Controls.Add(this.checkBoxView);
            this.groupBoxAddAndEdit.Controls.Add(this.label4);
            this.groupBoxAddAndEdit.Controls.Add(this.label5);
            this.groupBoxAddAndEdit.Location = new System.Drawing.Point(25, 19);
            this.groupBoxAddAndEdit.Name = "groupBoxAddAndEdit";
            this.groupBoxAddAndEdit.Size = new System.Drawing.Size(463, 235);
            this.groupBoxAddAndEdit.TabIndex = 14;
            this.groupBoxAddAndEdit.TabStop = false;
            this.groupBoxAddAndEdit.Text = "Добавление/Изменение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(375, 163);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(50, 13);
            this.DeleteLabel.TabIndex = 19;
            this.DeleteLabel.Text = "Удалить";
            this.DeleteLabel.Click += new System.EventHandler(this.DeleteLabel_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Location = new System.Drawing.Point(256, 163);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(96, 13);
            this.LabelEdit.TabIndex = 18;
            this.LabelEdit.Text = "Отредактировать";
            this.LabelEdit.Click += new System.EventHandler(this.Label7_Click);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Location = new System.Drawing.Point(196, 163);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(54, 13);
            this.labelClear.TabIndex = 17;
            this.labelClear.Text = "Очистить";
            this.labelClear.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboBoxListDB
            // 
            this.comboBoxListDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListDB.Location = new System.Drawing.Point(237, 117);
            this.comboBoxListDB.MaxDropDownItems = 99;
            this.comboBoxListDB.Name = "comboBoxListDB";
            this.comboBoxListDB.Size = new System.Drawing.Size(179, 21);
            this.comboBoxListDB.TabIndex = 14;
            this.comboBoxListDB.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // LabelAddAfter
            // 
            this.LabelAddAfter.AutoSize = true;
            this.LabelAddAfter.Location = new System.Drawing.Point(309, 141);
            this.LabelAddAfter.Name = "LabelAddAfter";
            this.LabelAddAfter.Size = new System.Drawing.Size(129, 13);
            this.LabelAddAfter.TabIndex = 13;
            this.LabelAddAfter.Text = "Добавить запись после";
            this.LabelAddAfter.Click += new System.EventHandler(this.Label6_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(23, 65);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(81, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDBox_KeyPress);
            // 
            // FioBox
            // 
            this.FioBox.Location = new System.Drawing.Point(23, 118);
            this.FioBox.Name = "FioBox";
            this.FioBox.Size = new System.Drawing.Size(175, 20);
            this.FioBox.TabIndex = 2;
            this.FioBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FioBox_KeyPress);
            // 
            // CarBox
            // 
            this.CarBox.Location = new System.Drawing.Point(23, 179);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(81, 20);
            this.CarBox.TabIndex = 3;
            // 
            // checkBoxMoney
            // 
            this.checkBoxMoney.AutoSize = true;
            this.checkBoxMoney.Location = new System.Drawing.Point(237, 70);
            this.checkBoxMoney.Name = "checkBoxMoney";
            this.checkBoxMoney.Size = new System.Drawing.Size(133, 17);
            this.checkBoxMoney.TabIndex = 10;
            this.checkBoxMoney.Text = "Оплатил за стоянку?";
            this.checkBoxMoney.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // checkBoxView
            // 
            this.checkBoxView.AutoSize = true;
            this.checkBoxView.Location = new System.Drawing.Point(237, 47);
            this.checkBoxView.Name = "checkBoxView";
            this.checkBoxView.Size = new System.Drawing.Size(158, 17);
            this.checkBoxView.TabIndex = 9;
            this.checkBoxView.Text = "Присуствует на стоянке? ";
            this.checkBoxView.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Машина";
            // 
            // menuDataBase
            // 
            this.menuDataBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.справкаToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuDataBase.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuDataBase.Location = new System.Drawing.Point(0, 0);
            this.menuDataBase.Name = "menuDataBase";
            this.menuDataBase.Size = new System.Drawing.Size(750, 24);
            this.menuDataBase.TabIndex = 9;
            this.menuDataBase.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem3,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem2.Text = "Файл";
            this.fileToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // saveToolStripMenuItem3
            // 
            this.saveToolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripMenuItem3.Name = "saveToolStripMenuItem3";
            this.saveToolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem3.Text = "Сохранить как";
            this.saveToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveToolStripMenuItem3.Click += new System.EventHandler(this.SaveToolStripMenuItem3_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(619, 49);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(112, 20);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.radioMoney);
            this.SearchGroupBox.Controls.Add(this.radioView);
            this.SearchGroupBox.Controls.Add(this.radioCar);
            this.SearchGroupBox.Controls.Add(this.radioFio);
            this.SearchGroupBox.Controls.Add(this.radioID);
            this.SearchGroupBox.Location = new System.Drawing.Point(553, 89);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(178, 151);
            this.SearchGroupBox.TabIndex = 11;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Найти по столбцу";
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Location = new System.Drawing.Point(7, 116);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(120, 17);
            this.radioMoney.TabIndex = 4;
            this.radioMoney.TabStop = true;
            this.radioMoney.Text = "Оплата за стоянку";
            this.radioMoney.UseVisualStyleBackColor = true;
            // 
            // radioView
            // 
            this.radioView.AutoSize = true;
            this.radioView.Location = new System.Drawing.Point(7, 92);
            this.radioView.Name = "radioView";
            this.radioView.Size = new System.Drawing.Size(127, 17);
            this.radioView.TabIndex = 3;
            this.radioView.TabStop = true;
            this.radioView.Text = "Наличие на стоянке";
            this.radioView.UseVisualStyleBackColor = true;
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(7, 68);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(87, 17);
            this.radioCar.TabIndex = 2;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Автомобиль";
            this.radioCar.UseVisualStyleBackColor = true;
            // 
            // radioFio
            // 
            this.radioFio.AutoSize = true;
            this.radioFio.Location = new System.Drawing.Point(7, 44);
            this.radioFio.Name = "radioFio";
            this.radioFio.Size = new System.Drawing.Size(52, 17);
            this.radioFio.TabIndex = 1;
            this.radioFio.TabStop = true;
            this.radioFio.Text = "ФИО";
            this.radioFio.UseVisualStyleBackColor = true;
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Location = new System.Drawing.Point(7, 20);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(36, 17);
            this.radioID.TabIndex = 0;
            this.radioID.TabStop = true;
            this.radioID.Text = "ID";
            this.radioID.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(571, 52);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 13);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Поиск:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 419);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.menuDataBase);
            this.Controls.Add(this.tabControlDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuDataBase;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "База данных австостоянки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlDataBase.ResumeLayout(false);
            this.tabPageDatabaseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxAddAndEdit.ResumeLayout(false);
            this.groupBoxAddAndEdit.PerformLayout();
            this.menuDataBase.ResumeLayout(false);
            this.menuDataBase.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlDataBase;
        private System.Windows.Forms.TabPage tabPageDatabaseTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuDataBase;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem3;
        private System.Windows.Forms.DataGridView DatabaseTable;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox CarBox;
        private System.Windows.Forms.TextBox FioBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label LabelAddAfter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxMoney;
        private System.Windows.Forms.CheckBox checkBoxView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stojanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.GroupBox groupBoxAddAndEdit;
        private System.Windows.Forms.ComboBox comboBoxListDB;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.RadioButton radioView;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioFio;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

