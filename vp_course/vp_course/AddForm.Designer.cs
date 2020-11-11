namespace vp_course
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
            this.LifeTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.PregnancyUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProgenyUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProgenyLabel = new System.Windows.Forms.Label();
            this.LatNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PregnancyLabel = new System.Windows.Forms.Label();
            this.LifeTimeLabel = new System.Windows.Forms.Label();
            this.LatNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AnimalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AnimalTypeLabel = new System.Windows.Forms.Label();
            this.CancelAdButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AnimalKindComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LifeTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PregnancyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgenyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LifeTimeUpDown
            // 
            this.LifeTimeUpDown.Location = new System.Drawing.Point(14, 188);
            this.LifeTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LifeTimeUpDown.Name = "LifeTimeUpDown";
            this.LifeTimeUpDown.Size = new System.Drawing.Size(260, 20);
            this.LifeTimeUpDown.TabIndex = 22;
            // 
            // PregnancyUpDown
            // 
            this.PregnancyUpDown.Location = new System.Drawing.Point(14, 227);
            this.PregnancyUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PregnancyUpDown.Name = "PregnancyUpDown";
            this.PregnancyUpDown.Size = new System.Drawing.Size(260, 20);
            this.PregnancyUpDown.TabIndex = 21;
            // 
            // ProgenyUpDown
            // 
            this.ProgenyUpDown.Location = new System.Drawing.Point(14, 266);
            this.ProgenyUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ProgenyUpDown.Name = "ProgenyUpDown";
            this.ProgenyUpDown.Size = new System.Drawing.Size(260, 20);
            this.ProgenyUpDown.TabIndex = 20;
            // 
            // ProgenyLabel
            // 
            this.ProgenyLabel.AutoSize = true;
            this.ProgenyLabel.Location = new System.Drawing.Point(14, 250);
            this.ProgenyLabel.Name = "ProgenyLabel";
            this.ProgenyLabel.Size = new System.Drawing.Size(168, 13);
            this.ProgenyLabel.TabIndex = 19;
            this.ProgenyLabel.Text = "Среднее количество потомства";
            // 
            // LatNameTextBox
            // 
            this.LatNameTextBox.Location = new System.Drawing.Point(14, 147);
            this.LatNameTextBox.Name = "LatNameTextBox";
            this.LatNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.LatNameTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(14, 107);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 17;
            // 
            // PregnancyLabel
            // 
            this.PregnancyLabel.AutoSize = true;
            this.PregnancyLabel.Location = new System.Drawing.Point(14, 211);
            this.PregnancyLabel.Name = "PregnancyLabel";
            this.PregnancyLabel.Size = new System.Drawing.Size(205, 13);
            this.PregnancyLabel.TabIndex = 16;
            this.PregnancyLabel.Text = "Длительность беременности (месяцы)";
            // 
            // LifeTimeLabel
            // 
            this.LifeTimeLabel.AutoSize = true;
            this.LifeTimeLabel.Location = new System.Drawing.Point(14, 170);
            this.LifeTimeLabel.Name = "LifeTimeLabel";
            this.LifeTimeLabel.Size = new System.Drawing.Size(222, 13);
            this.LifeTimeLabel.TabIndex = 15;
            this.LifeTimeLabel.Text = "Средняя продолжительность жизни (года)";
            // 
            // LatNameLabel
            // 
            this.LatNameLabel.AutoSize = true;
            this.LatNameLabel.Location = new System.Drawing.Point(14, 130);
            this.LatNameLabel.Name = "LatNameLabel";
            this.LatNameLabel.Size = new System.Drawing.Size(130, 13);
            this.LatNameLabel.TabIndex = 14;
            this.LatNameLabel.Text = "Название на латинском";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 91);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Название";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 23);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AnimalTypeComboBox
            // 
            this.AnimalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalTypeComboBox.FormattingEnabled = true;
            this.AnimalTypeComboBox.Location = new System.Drawing.Point(14, 67);
            this.AnimalTypeComboBox.Name = "AnimalTypeComboBox";
            this.AnimalTypeComboBox.Size = new System.Drawing.Size(260, 21);
            this.AnimalTypeComboBox.TabIndex = 24;
            this.AnimalTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.AnimalTypeComboBox_SelectionChangeCommitted);
            // 
            // AnimalTypeLabel
            // 
            this.AnimalTypeLabel.AutoSize = true;
            this.AnimalTypeLabel.Location = new System.Drawing.Point(14, 51);
            this.AnimalTypeLabel.Name = "AnimalTypeLabel";
            this.AnimalTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.AnimalTypeLabel.TabIndex = 25;
            this.AnimalTypeLabel.Text = "Вид животного";
            // 
            // CancelAdButton
            // 
            this.CancelAdButton.Location = new System.Drawing.Point(148, 415);
            this.CancelAdButton.Name = "CancelAdButton";
            this.CancelAdButton.Size = new System.Drawing.Size(127, 23);
            this.CancelAdButton.TabIndex = 26;
            this.CancelAdButton.Text = "Отмена";
            this.CancelAdButton.UseVisualStyleBackColor = true;
            this.CancelAdButton.Click += new System.EventHandler(this.CancelAdButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Тип животного";
            // 
            // AnimalKindComboBox
            // 
            this.AnimalKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalKindComboBox.FormattingEnabled = true;
            this.AnimalKindComboBox.Items.AddRange(new object[] {
            "Кишечнополостное",
            "Членистоногое",
            "Моллюск",
            "Иглокожое",
            "Хордовое"});
            this.AnimalKindComboBox.Location = new System.Drawing.Point(14, 23);
            this.AnimalKindComboBox.Name = "AnimalKindComboBox";
            this.AnimalKindComboBox.Size = new System.Drawing.Size(260, 21);
            this.AnimalKindComboBox.TabIndex = 31;
            this.AnimalKindComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalKindComboBox_SelectedIndexChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnimalKindComboBox);
            this.Controls.Add(this.CancelAdButton);
            this.Controls.Add(this.AnimalTypeLabel);
            this.Controls.Add(this.AnimalTypeComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LifeTimeUpDown);
            this.Controls.Add(this.PregnancyUpDown);
            this.Controls.Add(this.ProgenyUpDown);
            this.Controls.Add(this.ProgenyLabel);
            this.Controls.Add(this.LatNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PregnancyLabel);
            this.Controls.Add(this.LifeTimeLabel);
            this.Controls.Add(this.LatNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddForm";
            this.Text = "Добавление животного";
            ((System.ComponentModel.ISupportInitialize)(this.LifeTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PregnancyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgenyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LifeTimeUpDown;
        private System.Windows.Forms.NumericUpDown PregnancyUpDown;
        private System.Windows.Forms.NumericUpDown ProgenyUpDown;
        private System.Windows.Forms.Label ProgenyLabel;
        private System.Windows.Forms.TextBox LatNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label PregnancyLabel;
        private System.Windows.Forms.Label LifeTimeLabel;
        private System.Windows.Forms.Label LatNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox AnimalTypeComboBox;
        private System.Windows.Forms.Label AnimalTypeLabel;
        private System.Windows.Forms.Button CancelAdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AnimalKindComboBox;
    }
}