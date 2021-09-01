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
            this.buttonNew1 = new LekarList.Controls.ButtonNew();
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
            this.TextBox_SearchLine.Location = new System.Drawing.Point(316, 35);
            this.TextBox_SearchLine.Name = "TextBox_SearchLine";
            this.TextBox_SearchLine.Size = new System.Drawing.Size(367, 31);
            this.TextBox_SearchLine.TabIndex = 1;
            // 
            // SearLineToolTip
            // 
            this.SearLineToolTip.ToolTipTitle = "что вводить?";
            // 
            // buttonNew1
            // 
            this.buttonNew1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNew1.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonNew1.BackColorGradientEnabled = false;
            this.buttonNew1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonNew1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNew1.BorderColorEnabled = false;
            this.buttonNew1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonNew1.BorderColorOnHoverEnabled = false;
            this.buttonNew1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonNew1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.buttonNew1.ForeColor = System.Drawing.Color.White;
            this.buttonNew1.Location = new System.Drawing.Point(12, 97);
            this.buttonNew1.Name = "buttonNew1";
            this.buttonNew1.RippleColor = System.Drawing.Color.Black;
            this.buttonNew1.RoundingEnable = false;
            this.buttonNew1.Size = new System.Drawing.Size(671, 47);
            this.buttonNew1.TabIndex = 3;
            this.buttonNew1.Text = "Выполнить поиск";
            this.buttonNew1.TextHover = null;
            this.buttonNew1.UseDownPressEffectOnClick = false;
            this.buttonNew1.UseRippleEffect = true;
            this.buttonNew1.UseZoomEffectOnHover = false;
            this.buttonNew1.Click += new System.EventHandler(this.OkButton_SearchLine_Click);
            // 
            // SearchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(695, 156);
            this.Controls.Add(this.buttonNew1);
            this.Controls.Add(this.TextBox_SearchLine);
            this.Controls.Add(this.Label_SearchLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по имени класса";
            this.Load += new System.EventHandler(this.SearchLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SearchLine;
        private System.Windows.Forms.ToolTip SearLineToolTip;
        internal System.Windows.Forms.TextBox TextBox_SearchLine;
        private Controls.ButtonNew buttonNew1;
    }
}