namespace LekarList.Forms
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PharmaTypeLabel = new System.Windows.Forms.Label();
            this.PharmaComboBox = new System.Windows.Forms.ComboBox();
            this.ChemTypeLabel = new System.Windows.Forms.Label();
            this.ChemComboBox = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.CancelAdButton = new System.Windows.Forms.Button();
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
            this.AnatomComboBox.Size = new System.Drawing.Size(345, 24);
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
            this.TherapComboBox.Size = new System.Drawing.Size(345, 24);
            this.TherapComboBox.TabIndex = 44;
            this.TherapComboBox.SelectedIndexChanged += new System.EventHandler(this.TherapComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(22, 511);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(169, 28);
            this.AddButton.TabIndex = 43;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(21, 243);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(345, 22);
            this.CodeTextBox.TabIndex = 37;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(21, 223);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 17);
            this.NameLabel.TabIndex = 33;
            this.NameLabel.Text = "Код";
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
            this.PharmaComboBox.Size = new System.Drawing.Size(345, 24);
            this.PharmaComboBox.TabIndex = 49;
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
            this.ChemComboBox.Size = new System.Drawing.Size(345, 24);
            this.ChemComboBox.TabIndex = 51;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(21, 290);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(74, 17);
            this.Description.TabIndex = 53;
            this.Description.Text = "Описание";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(25, 311);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(341, 168);
            this.DescriptionBox.TabIndex = 54;
            // 
            // CancelAdButton
            // 
            this.CancelAdButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAdButton.Location = new System.Drawing.Point(199, 511);
            this.CancelAdButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelAdButton.Name = "CancelAdButton";
            this.CancelAdButton.Size = new System.Drawing.Size(169, 28);
            this.CancelAdButton.TabIndex = 46;
            this.CancelAdButton.Text = "Отмена";
            this.CancelAdButton.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 553);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ChemTypeLabel);
            this.Controls.Add(this.ChemComboBox);
            this.Controls.Add(this.PharmaTypeLabel);
            this.Controls.Add(this.PharmaComboBox);
            this.Controls.Add(this.AnatomTypeLabel);
            this.Controls.Add(this.AnatomComboBox);
            this.Controls.Add(this.CancelAdButton);
            this.Controls.Add(this.TherapTypeLabel);
            this.Controls.Add(this.TherapComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.NameLabel);
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PharmaTypeLabel;
        private System.Windows.Forms.ComboBox PharmaComboBox;
        private System.Windows.Forms.Label ChemTypeLabel;
        private System.Windows.Forms.ComboBox ChemComboBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button CancelAdButton;
    }
}