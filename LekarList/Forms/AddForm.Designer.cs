﻿namespace LekarList.Forms
{
    partial class AddForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lekarListClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnatomTypeLabel = new System.Windows.Forms.Label();
            this.AnatomComboBox = new System.Windows.Forms.ComboBox();
            this.TherapTypeLabel = new System.Windows.Forms.Label();
            this.TherapComboBox = new System.Windows.Forms.ComboBox();
            this.PharmaTypeLabel = new System.Windows.Forms.Label();
            this.PharmaComboBox = new System.Windows.Forms.ComboBox();
            this.ChemTypeLabel = new System.Windows.Forms.Label();
            this.ChemComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new LekarList.Controls.ButtonNew();
            this.CancelButton = new LekarList.Controls.ButtonNew();
            this.DescriptionBox = new LekarList.EgoldsGoogleTextBox();
            this.CodeTextBox = new LekarList.EgoldsGoogleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lekarListClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AnatomTypeLabel
            // 
            this.AnatomTypeLabel.AutoSize = true;
            this.AnatomTypeLabel.Location = new System.Drawing.Point(21, 9);
            this.AnatomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnatomTypeLabel.Name = "AnatomTypeLabel";
            this.AnatomTypeLabel.Size = new System.Drawing.Size(159, 17);
            this.AnatomTypeLabel.TabIndex = 48;
            this.AnatomTypeLabel.Text = "Анатомическая группа";
            // 
            // AnatomComboBox
            // 
            this.AnatomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnatomComboBox.FormattingEnabled = true;
            this.AnatomComboBox.Location = new System.Drawing.Point(21, 28);
            this.AnatomComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnatomComboBox.Name = "AnatomComboBox";
            this.AnatomComboBox.Size = new System.Drawing.Size(418, 24);
            this.AnatomComboBox.TabIndex = 47;
            this.AnatomComboBox.SelectedIndexChanged += new System.EventHandler(this.AnatomComboBox_SelectedIndexChanged);
            // 
            // TherapTypeLabel
            // 
            this.TherapTypeLabel.AutoSize = true;
            this.TherapTypeLabel.Location = new System.Drawing.Point(21, 63);
            this.TherapTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TherapTypeLabel.Name = "TherapTypeLabel";
            this.TherapTypeLabel.Size = new System.Drawing.Size(173, 17);
            this.TherapTypeLabel.TabIndex = 45;
            this.TherapTypeLabel.Text = "Терапевтическая группа";
            // 
            // TherapComboBox
            // 
            this.TherapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TherapComboBox.FormattingEnabled = true;
            this.TherapComboBox.Location = new System.Drawing.Point(21, 82);
            this.TherapComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TherapComboBox.Name = "TherapComboBox";
            this.TherapComboBox.Size = new System.Drawing.Size(418, 24);
            this.TherapComboBox.TabIndex = 44;
            this.TherapComboBox.SelectedIndexChanged += new System.EventHandler(this.TherapComboBox_SelectedIndexChanged);
            // 
            // PharmaTypeLabel
            // 
            this.PharmaTypeLabel.AutoSize = true;
            this.PharmaTypeLabel.Location = new System.Drawing.Point(23, 115);
            this.PharmaTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PharmaTypeLabel.Name = "PharmaTypeLabel";
            this.PharmaTypeLabel.Size = new System.Drawing.Size(192, 17);
            this.PharmaTypeLabel.TabIndex = 50;
            this.PharmaTypeLabel.Text = "Фармакологическая группа";
            // 
            // PharmaComboBox
            // 
            this.PharmaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PharmaComboBox.FormattingEnabled = true;
            this.PharmaComboBox.Location = new System.Drawing.Point(23, 134);
            this.PharmaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PharmaComboBox.Name = "PharmaComboBox";
            this.PharmaComboBox.Size = new System.Drawing.Size(416, 24);
            this.PharmaComboBox.TabIndex = 49;
            this.PharmaComboBox.SelectedIndexChanged += new System.EventHandler(this.PharmaComboBox_SelectedIndexChanged);
            // 
            // ChemTypeLabel
            // 
            this.ChemTypeLabel.AutoSize = true;
            this.ChemTypeLabel.Location = new System.Drawing.Point(22, 169);
            this.ChemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChemTypeLabel.Name = "ChemTypeLabel";
            this.ChemTypeLabel.Size = new System.Drawing.Size(136, 17);
            this.ChemTypeLabel.TabIndex = 52;
            this.ChemTypeLabel.Text = "Химическая группа";
            // 
            // ChemComboBox
            // 
            this.ChemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChemComboBox.FormattingEnabled = true;
            this.ChemComboBox.Location = new System.Drawing.Point(22, 188);
            this.ChemComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChemComboBox.Name = "ChemComboBox";
            this.ChemComboBox.Size = new System.Drawing.Size(417, 24);
            this.ChemComboBox.TabIndex = 51;
            this.ChemComboBox.SelectedIndexChanged += new System.EventHandler(this.ChemComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.AddButton.BackColorGradientEnabled = false;
            this.AddButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AddButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AddButton.BorderColorEnabled = false;
            this.AddButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AddButton.BorderColorOnHoverEnabled = false;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(26, 509);
            this.AddButton.Name = "AddButton";
            this.AddButton.RippleColor = System.Drawing.Color.Black;
            this.AddButton.RoundingEnable = false;
            this.AddButton.Size = new System.Drawing.Size(170, 30);
            this.AddButton.TabIndex = 55;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextHover = null;
            this.AddButton.UseDownPressEffectOnClick = false;
            this.AddButton.UseRippleEffect = true;
            this.AddButton.UseZoomEffectOnHover = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.CancelButton.BackColorGradientEnabled = false;
            this.CancelButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CancelButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton.BorderColorEnabled = false;
            this.CancelButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CancelButton.BorderColorOnHoverEnabled = false;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(256, 509);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.RippleColor = System.Drawing.Color.Black;
            this.CancelButton.RoundingEnable = false;
            this.CancelButton.Size = new System.Drawing.Size(170, 30);
            this.CancelButton.TabIndex = 56;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextHover = null;
            this.CancelButton.UseDownPressEffectOnClick = false;
            this.CancelButton.UseRippleEffect = true;
            this.CancelButton.UseZoomEffectOnHover = false;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.White;
            this.DescriptionBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.DescriptionBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.DescriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBox.FontTextPreview = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.DescriptionBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionBox.Location = new System.Drawing.Point(21, 298);
            this.DescriptionBox.MultiLine = false;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(418, 171);
            this.DescriptionBox.TabIndex = 57;
            this.DescriptionBox.TextInput = "";
            this.DescriptionBox.TextPreview = "Описание";
            this.DescriptionBox.UseSystemPasswordChar = false;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.BackColor = System.Drawing.Color.White;
            this.CodeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CodeTextBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.CodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeTextBox.FontTextPreview = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.CodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CodeTextBox.Location = new System.Drawing.Point(21, 238);
            this.CodeTextBox.MultiLine = false;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(418, 54);
            this.CodeTextBox.TabIndex = 58;
            this.CodeTextBox.TextInput = "";
            this.CodeTextBox.TextPreview = "Код группы";
            this.CodeTextBox.UseSystemPasswordChar = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 553);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ChemTypeLabel);
            this.Controls.Add(this.ChemComboBox);
            this.Controls.Add(this.PharmaTypeLabel);
            this.Controls.Add(this.PharmaComboBox);
            this.Controls.Add(this.AnatomTypeLabel);
            this.Controls.Add(this.AnatomComboBox);
            this.Controls.Add(this.TherapTypeLabel);
            this.Controls.Add(this.TherapComboBox);
            this.Name = "AddForm";
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lekarListClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource lekarListClassBindingSource;
        private System.Windows.Forms.Label AnatomTypeLabel;
        private System.Windows.Forms.ComboBox AnatomComboBox;
        private System.Windows.Forms.Label TherapTypeLabel;
        private System.Windows.Forms.ComboBox TherapComboBox;
        private System.Windows.Forms.Label PharmaTypeLabel;
        private System.Windows.Forms.ComboBox PharmaComboBox;
        private System.Windows.Forms.Label ChemTypeLabel;
        private System.Windows.Forms.ComboBox ChemComboBox;
        private Controls.ButtonNew AddButton;
        private Controls.ButtonNew CancelButton;
        private EgoldsGoogleTextBox DescriptionBox;
        private EgoldsGoogleTextBox CodeTextBox;
    }
}