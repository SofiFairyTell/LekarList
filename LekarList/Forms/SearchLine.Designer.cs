namespace LekarList.Forms
{
    partial class SearchLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label_SearchLine = new System.Windows.Forms.Label();
            this.TextBox_SearchLine = new System.Windows.Forms.TextBox();
            this.SearLineToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OkButton_SearchLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SearchLine
            // 
            this.Label_SearchLine.AutoSize = true;
            this.Label_SearchLine.Font = new System.Drawing.Font("Times New Roman", 12.14F);
            this.Label_SearchLine.Location = new System.Drawing.Point(12, 37);
            this.Label_SearchLine.Name = "Label_SearchLine";
            this.Label_SearchLine.Size = new System.Drawing.Size(248, 23);
            this.Label_SearchLine.TabIndex = 0;
            this.Label_SearchLine.Text = "Введите строку для поиска";
            // 
            // TextBox_SearchLine
            // 
            this.TextBox_SearchLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_SearchLine.Font = new System.Drawing.Font("Times New Roman", 12.14F);
            this.TextBox_SearchLine.Location = new System.Drawing.Point(259, 35);
            this.TextBox_SearchLine.Name = "TextBox_SearchLine";
            this.TextBox_SearchLine.Size = new System.Drawing.Size(367, 31);
            this.TextBox_SearchLine.TabIndex = 1;
            // 
            // SearLineToolTip
            // 
            this.SearLineToolTip.ToolTipTitle = "что вводить?";
            // 
            // OkButton_SearchLine
            // 
            this.OkButton_SearchLine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OkButton_SearchLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton_SearchLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton_SearchLine.Font = new System.Drawing.Font("Times New Roman", 12.14F);
            this.OkButton_SearchLine.Location = new System.Drawing.Point(413, 98);
            this.OkButton_SearchLine.Name = "OkButton_SearchLine";
            this.OkButton_SearchLine.Size = new System.Drawing.Size(213, 36);
            this.OkButton_SearchLine.TabIndex = 2;
            this.OkButton_SearchLine.Text = "Выполнить поиск";
            this.OkButton_SearchLine.UseVisualStyleBackColor = false;
            this.OkButton_SearchLine.Click += new System.EventHandler(this.OkButton_SearchLine_Click);
            // 
            // SearchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(651, 156);
            this.Controls.Add(this.OkButton_SearchLine);
            this.Controls.Add(this.TextBox_SearchLine);
            this.Controls.Add(this.Label_SearchLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchLine";
            this.Opacity = 0.7D;
            this.Text = "Поиск по имени класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SearchLine;
        private System.Windows.Forms.ToolTip SearLineToolTip;
        internal System.Windows.Forms.TextBox TextBox_SearchLine;
        public System.Windows.Forms.Button OkButton_SearchLine;
    }
}