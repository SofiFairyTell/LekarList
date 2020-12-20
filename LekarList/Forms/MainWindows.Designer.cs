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
            this.SortButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataDescriptionGrid = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MinimizeItem = new LekarList.Controls.ButtonNew();
            this.AddItem = new LekarList.Controls.ButtonNew();
            this.DelItem = new LekarList.Controls.ButtonNew();
            this.EditItem = new LekarList.Controls.ButtonNew();
            this.DescriptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CтатистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(955, 53);
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
            this.menuStrip1.Size = new System.Drawing.Size(1186, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Строка меню");
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.настройкиToolStripMenuItem.Text = "Файл";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.xMLToolStripMenuItem.Text = "Открыть output.xml";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.XMLToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как output.xml";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭлементToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.показатьКнопкиToolStripMenuItem,
            this.CтатистикаToolStripMenuItem});
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.выходToolStripMenuItem.Text = "Действия";
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            this.добавитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.ПоискToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.ОбновитьToolStripMenuItem_Click);
            // 
            // показатьКнопкиToolStripMenuItem
            // 
            this.показатьКнопкиToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.показатьКнопкиToolStripMenuItem.Name = "показатьКнопкиToolStripMenuItem";
            this.показатьКнопкиToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.показатьКнопкиToolStripMenuItem.Text = "Показать кнопки";
            this.показатьКнопкиToolStripMenuItem.Click += new System.EventHandler(this.ПоказатьКнопкиToolStripMenuItem_Click);
            this.показатьКнопкиToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ПоказатьКнопкиToolStripMenuItem_MouseDown);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.ВыходToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, "Текущие дата и время");
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 478);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 28);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
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
            this.tabPage1.Size = new System.Drawing.Size(906, 416);
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
            this.DataDescriptionGrid.Location = new System.Drawing.Point(418, 2);
            this.DataDescriptionGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataDescriptionGrid.Name = "DataDescriptionGrid";
            this.DataDescriptionGrid.RowTemplate.Height = 24;
            this.DataDescriptionGrid.Size = new System.Drawing.Size(485, 412);
            this.DataDescriptionGrid.TabIndex = 1;
            this.toolTip1.SetToolTip(this.DataDescriptionGrid, "Нажмите на узел,\r\nчтобы увидеть здесь \r\nинформацию об узле");
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
            this.toolTip1.SetToolTip(this.treeView1, "Иерархия отображается здесь");
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 448);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // MinimizeItem
            // 
            this.MinimizeItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MinimizeItem.BackColorAdditional = System.Drawing.Color.Gray;
            this.MinimizeItem.BackColorGradientEnabled = false;
            this.MinimizeItem.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.MinimizeItem.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.MinimizeItem.BorderColorEnabled = false;
            this.MinimizeItem.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.MinimizeItem.BorderColorOnHoverEnabled = false;
            this.MinimizeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeItem.ForeColor = System.Drawing.Color.White;
            this.MinimizeItem.Location = new System.Drawing.Point(955, 373);
            this.MinimizeItem.Name = "MinimizeItem";
            this.MinimizeItem.RippleColor = System.Drawing.Color.DarkRed;
            this.MinimizeItem.RoundingEnable = false;
            this.MinimizeItem.Size = new System.Drawing.Size(219, 62);
            this.MinimizeItem.TabIndex = 15;
            this.MinimizeItem.Text = "Свернуть";
            this.MinimizeItem.TextHover = null;
            this.MinimizeItem.UseDownPressEffectOnClick = false;
            this.MinimizeItem.UseRippleEffect = true;
            this.MinimizeItem.UseZoomEffectOnHover = false;
            this.MinimizeItem.Visible = false;
            this.MinimizeItem.DoubleClick += new System.EventHandler(this.MinimButton_Click);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddItem.BackColorAdditional = System.Drawing.Color.Gray;
            this.AddItem.BackColorGradientEnabled = false;
            this.AddItem.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AddItem.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AddItem.BorderColorEnabled = false;
            this.AddItem.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AddItem.BorderColorOnHoverEnabled = false;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(955, 208);
            this.AddItem.Name = "AddItem";
            this.AddItem.RippleColor = System.Drawing.Color.DarkRed;
            this.AddItem.RoundingEnable = false;
            this.AddItem.Size = new System.Drawing.Size(219, 62);
            this.AddItem.TabIndex = 14;
            this.AddItem.Text = "Добавить";
            this.AddItem.TextHover = null;
            this.AddItem.UseDownPressEffectOnClick = false;
            this.AddItem.UseRippleEffect = true;
            this.AddItem.UseZoomEffectOnHover = false;
            this.AddItem.Visible = false;
            this.AddItem.DoubleClick += new System.EventHandler(this.AddButton_Click_1);
            // 
            // DelItem
            // 
            this.DelItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DelItem.BackColorAdditional = System.Drawing.Color.Gray;
            this.DelItem.BackColorGradientEnabled = false;
            this.DelItem.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DelItem.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.DelItem.BorderColorEnabled = false;
            this.DelItem.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DelItem.BorderColorOnHoverEnabled = false;
            this.DelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DelItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelItem.ForeColor = System.Drawing.Color.White;
            this.DelItem.Location = new System.Drawing.Point(955, 290);
            this.DelItem.Name = "DelItem";
            this.DelItem.RippleColor = System.Drawing.Color.DarkRed;
            this.DelItem.RoundingEnable = false;
            this.DelItem.Size = new System.Drawing.Size(219, 62);
            this.DelItem.TabIndex = 13;
            this.DelItem.Text = "Удалить";
            this.DelItem.TextHover = null;
            this.DelItem.UseDownPressEffectOnClick = false;
            this.DelItem.UseRippleEffect = true;
            this.DelItem.UseZoomEffectOnHover = false;
            this.DelItem.Visible = false;
            this.DelItem.Click += new System.EventHandler(this.DelItem_Click);
            this.DelItem.DoubleClick += new System.EventHandler(this.DelButton_Click);
            // 
            // EditItem
            // 
            this.EditItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditItem.BackColorAdditional = System.Drawing.Color.Gray;
            this.EditItem.BackColorGradientEnabled = false;
            this.EditItem.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.EditItem.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.EditItem.BorderColorEnabled = false;
            this.EditItem.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.EditItem.BorderColorOnHoverEnabled = false;
            this.EditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditItem.Location = new System.Drawing.Point(955, 130);
            this.EditItem.Name = "EditItem";
            this.EditItem.RippleColor = System.Drawing.Color.Black;
            this.EditItem.RoundingEnable = false;
            this.EditItem.Size = new System.Drawing.Size(219, 62);
            this.EditItem.TabIndex = 12;
            this.EditItem.Text = "Изменить";
            this.EditItem.TextHover = null;
            this.EditItem.UseDownPressEffectOnClick = false;
            this.EditItem.UseRippleEffect = true;
            this.EditItem.UseZoomEffectOnHover = false;
            this.EditItem.Visible = false;
            this.EditItem.DoubleClick += new System.EventHandler(this.EditButton_Click);
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
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CтатистикаToolStripMenuItem
            // 
            this.CтатистикаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CтатистикаToolStripMenuItem.Name = "CтатистикаToolStripMenuItem";
            this.CтатистикаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.CтатистикаToolStripMenuItem.Text = "Статистика";
            this.CтатистикаToolStripMenuItem.Click += new System.EventHandler(this.СтатистикаToolStripMenuItem_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 522);
            this.Controls.Add(this.MinimizeItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.DelItem);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.statusStrip1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDescriptionGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataDescriptionGrid;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private Controls.ButtonNew EditItem;
        private Controls.ButtonNew DelItem;
        private Controls.ButtonNew MinimizeItem;
        private Controls.ButtonNew AddItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem CтатистикаToolStripMenuItem;
    }
}

