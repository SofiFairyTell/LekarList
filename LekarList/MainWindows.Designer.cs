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
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(304, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(585, 217);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 34);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LBdata
            // 
            this.LBdata.FormattingEnabled = true;
            this.LBdata.ItemHeight = 16;
            this.LBdata.Items.AddRange(new object[] {
            "A,0",
            "B,0",
            "D,0",
            "D01,1",
            "D01A,2",
            "C,0",
            "D01AA,3",
            "C01,1",
            "1C01"});
            this.LBdata.Location = new System.Drawing.Point(365, 24);
            this.LBdata.Name = "LBdata";
            this.LBdata.Size = new System.Drawing.Size(337, 180);
            this.LBdata.TabIndex = 3;
            this.LBdata.SelectedIndexChanged += new System.EventHandler(this.LBdata_SelectedIndexChanged);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(442, 217);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(102, 34);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.LBdata);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.treeView1);
            this.Name = "MainWindows";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainWindows_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox LBdata;
        private System.Windows.Forms.Button SortButton;
    }
}

