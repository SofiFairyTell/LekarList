﻿namespace LekarList
{
    partial class MainWindows
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddButton = new System.Windows.Forms.Button();
            this.LBdata = new System.Windows.Forms.ListBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MinimButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DataDescriptionGrid = new System.Windows.Forms.DataGridView();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView1.Size = new System.Drawing.Size(255, 387);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(706, 230);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 53);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseCompatibleTextRendering = true;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // LBdata
            // 
            this.LBdata.FormattingEnabled = true;
            this.LBdata.ItemHeight = 16;
            this.LBdata.Items.AddRange(new object[] {
            "A",
            "B",
            "D",
            "D01",
            "D01",
            "D01AA"});
            this.LBdata.Location = new System.Drawing.Point(856, 53);
            this.LBdata.Name = "LBdata";
            this.LBdata.Size = new System.Drawing.Size(153, 116);
            this.LBdata.TabIndex = 3;
            this.LBdata.Visible = false;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(875, 292);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(102, 34);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Visible = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДанныеToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.добавитьДанныеToolStripMenuItem.Text = "Добавить данные";
            this.добавитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.выходToolStripMenuItem.Text = "Помощь";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem1.Text = "Выход";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 422);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.MinimButton);
            this.tabPage1.Controls.Add(this.DelButton);
            this.tabPage1.Controls.Add(this.EditButton);
            this.tabPage1.Controls.Add(this.DataDescriptionGrid);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "АТХ классификация";
            // 
            // MinimButton
            // 
            this.MinimButton.Location = new System.Drawing.Point(706, 174);
            this.MinimButton.Name = "MinimButton";
            this.MinimButton.Size = new System.Drawing.Size(121, 50);
            this.MinimButton.TabIndex = 9;
            this.MinimButton.Text = "Свернуть";
            this.MinimButton.UseCompatibleTextRendering = true;
            this.MinimButton.UseVisualStyleBackColor = true;
            this.MinimButton.Visible = false;
            this.MinimButton.Click += new System.EventHandler(this.MinimButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(706, 284);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(121, 53);
            this.DelButton.TabIndex = 8;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseCompatibleTextRendering = true;
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(706, 337);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 53);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseCompatibleTextRendering = true;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DataDescriptionGrid
            // 
            this.DataDescriptionGrid.AllowUserToAddRows = false;
            this.DataDescriptionGrid.AllowUserToDeleteRows = false;
            this.DataDescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDescriptionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupNameColumn,
            this.DescriptColumn});
            this.DataDescriptionGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataDescriptionGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataDescriptionGrid.Location = new System.Drawing.Point(258, 3);
            this.DataDescriptionGrid.Name = "DataDescriptionGrid";
            this.DataDescriptionGrid.RowTemplate.Height = 24;
            this.DataDescriptionGrid.Size = new System.Drawing.Size(448, 387);
            this.DataDescriptionGrid.TabIndex = 1;
            this.DataDescriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDescriptionGrid_CellContentClick);
            this.DataDescriptionGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataDescriptionGrid_KeyDown);
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.Frozen = true;
            this.GroupNameColumn.HeaderText = "";
            this.GroupNameColumn.MaxInputLength = 30;
            this.GroupNameColumn.Name = "GroupNameColumn";
            this.GroupNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DescriptColumn
            // 
            this.DescriptColumn.Frozen = true;
            this.DescriptColumn.HeaderText = "";
            this.DescriptColumn.Name = "DescriptColumn";
            this.DescriptColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescriptColumn.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заболевания";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Свернуть";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBdata);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Справочник лекарственных средств";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.MainWindows_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox LBdata;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.DataGridView DataDescriptionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptColumn;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button MinimButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button button1;
    }
}
