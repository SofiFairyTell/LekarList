namespace LekarList
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.LBdata = new System.Windows.Forms.ListBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DescriptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataDescriptionGrid = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Location = new System.Drawing.Point(939, 328);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(219, 63);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseCompatibleTextRendering = true;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // LBdata
            // 
            this.LBdata.FormattingEnabled = true;
            this.LBdata.ItemHeight = 19;
            this.LBdata.Items.AddRange(new object[] {
            "A",
            "B",
            "D",
            "D01",
            "D01",
            "D01AA"});
            this.LBdata.Location = new System.Drawing.Point(941, 30);
            this.LBdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBdata.Name = "LBdata";
            this.LBdata.Size = new System.Drawing.Size(229, 99);
            this.LBdata.TabIndex = 3;
            this.LBdata.Visible = false;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(941, 133);
            this.SortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(217, 57);
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
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДанныеToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.настройкиToolStripMenuItem.Text = "Файл";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.добавитьДанныеToolStripMenuItem.Text = "Открыть";
            this.добавитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭлементToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.показатьКнопкиToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.выходToolStripMenuItem.Text = "Правка";
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // показатьКнопкиToolStripMenuItem
            // 
            this.показатьКнопкиToolStripMenuItem.Name = "показатьКнопкиToolStripMenuItem";
            this.показатьКнопкиToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.показатьКнопкиToolStripMenuItem.Text = "Показать кнопки";
            this.показатьКнопкиToolStripMenuItem.Click += new System.EventHandler(this.показатьКнопкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // MinimButton
            // 
            this.MinimButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimButton.Location = new System.Drawing.Point(939, 395);
            this.MinimButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimButton.Name = "MinimButton";
            this.MinimButton.Size = new System.Drawing.Size(219, 59);
            this.MinimButton.TabIndex = 9;
            this.MinimButton.Text = "Свернуть";
            this.MinimButton.UseCompatibleTextRendering = true;
            this.MinimButton.UseVisualStyleBackColor = true;
            this.MinimButton.Visible = false;
            this.MinimButton.Click += new System.EventHandler(this.MinimButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DelButton.Location = new System.Drawing.Point(939, 261);
            this.DelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(219, 63);
            this.DelButton.TabIndex = 8;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseCompatibleTextRendering = true;
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Visible = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.Location = new System.Drawing.Point(939, 194);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(219, 63);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseCompatibleTextRendering = true;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DescriptColumn
            // 
            this.DescriptColumn.Frozen = true;
            this.DescriptColumn.HeaderText = "";
            this.DescriptColumn.Name = "DescriptColumn";
            this.DescriptColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescriptColumn.Width = 300;
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.Frozen = true;
            this.GroupNameColumn.HeaderText = "";
            this.GroupNameColumn.MaxInputLength = 30;
            this.GroupNameColumn.Name = "GroupNameColumn";
            this.GroupNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 448);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.DataDescriptionGrid);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(934, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "АТХ классификация";
            // 
            // DataDescriptionGrid
            // 
            this.DataDescriptionGrid.AllowUserToAddRows = false;
            this.DataDescriptionGrid.AllowUserToDeleteRows = false;
            this.DataDescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDescriptionGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataDescriptionGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataDescriptionGrid.Location = new System.Drawing.Point(413, 2);
            this.DataDescriptionGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataDescriptionGrid.Name = "DataDescriptionGrid";
            this.DataDescriptionGrid.RowTemplate.Height = 24;
            this.DataDescriptionGrid.Size = new System.Drawing.Size(518, 412);
            this.DataDescriptionGrid.TabIndex = 1;
            this.DataDescriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDescriptionGrid_CellContentClick);
            this.DataDescriptionGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataDescriptionGrid_KeyDown);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeView1.Location = new System.Drawing.Point(3, 2);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(409, 412);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1170, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 478);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1170, 22);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 522);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LBdata);
            this.Controls.Add(this.MinimButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Справочник лекарственных средств";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.MainWindows_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindows_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox LBdata;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button MinimButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataDescriptionGrid;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
    }
}

