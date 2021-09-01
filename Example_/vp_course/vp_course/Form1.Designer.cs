namespace vp_course
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Медузы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Кораллы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Кишечнополостные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Насекомые");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Паукообразные");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ракообразные");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Членистоногие", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Двустворчатые");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Головоногие");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Моллюски", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Морские ежи");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Морские звезды");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Иглокожие", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Земноводные");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Птицы");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Рыбы");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Млекопитающие");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Пресмыкающиеся");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Позвоночные", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Хордовые", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Животные", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode10,
            treeNode13,
            treeNode20});
            this.AnimalsTreeView = new System.Windows.Forms.TreeView();
            this.info = new System.Windows.Forms.TabControl();
            this.infotab = new System.Windows.Forms.TabPage();
            this.DynamicLabel3 = new System.Windows.Forms.Label();
            this.DynamicLabel2 = new System.Windows.Forms.Label();
            this.DynamicLabel1 = new System.Windows.Forms.Label();
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
            this.CountAnimals = new System.Windows.Forms.TabPage();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ReptilesCountLabel = new System.Windows.Forms.Label();
            this.MammalsCountLabel = new System.Windows.Forms.Label();
            this.FishCountLabel = new System.Windows.Forms.Label();
            this.BirdsCountLabel = new System.Windows.Forms.Label();
            this.AmphibiansCountLabel = new System.Windows.Forms.Label();
            this.VertebratesCountLabel = new System.Windows.Forms.Label();
            this.StarfishCountLabel = new System.Windows.Forms.Label();
            this.SeaUrchinsCountLabel = new System.Windows.Forms.Label();
            this.CephalobodsCountLabel = new System.Windows.Forms.Label();
            this.BivalvesCountLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.CrustaceaCountLabel = new System.Windows.Forms.Label();
            this.SpidersCountLabel = new System.Windows.Forms.Label();
            this.InsectsCountLabel = new System.Windows.Forms.Label();
            this.CoralCountLabel = new System.Windows.Forms.Label();
            this.JellyfishCountLabel = new System.Windows.Forms.Label();
            this.ChordataCountLabel = new System.Windows.Forms.Label();
            this.EchinodermCountLabel = new System.Windows.Forms.Label();
            this.MolluscaCountLabel = new System.Windows.Forms.Label();
            this.AnthropodCountLabel = new System.Windows.Forms.Label();
            this.CoelentrataCountLabel = new System.Windows.Forms.Label();
            this.AnimalsCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SortCustomControl13 = new vp_course.CustomControl1();
            this.customControl21 = new vp_course.CustomControl2();
            this.customControl12 = new vp_course.CustomControl1();
            this.customControl11 = new vp_course.CustomControl1();
            this.info.SuspendLayout();
            this.infotab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LifeTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PregnancyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgenyUpDown)).BeginInit();
            this.CountAnimals.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalsTreeView
            // 
            this.AnimalsTreeView.AllowDrop = true;
            this.AnimalsTreeView.Location = new System.Drawing.Point(12, 27);
            this.AnimalsTreeView.Name = "AnimalsTreeView";
            treeNode1.Name = "Jellyfish";
            treeNode1.Text = "Медузы";
            treeNode2.Name = "corals";
            treeNode2.Text = "Кораллы";
            treeNode3.Name = "coelenterata";
            treeNode3.Text = "Кишечнополостные";
            treeNode4.Name = "insects";
            treeNode4.Text = "Насекомые";
            treeNode5.Name = "spiders";
            treeNode5.Text = "Паукообразные";
            treeNode6.Name = "crustaceans";
            treeNode6.Text = "Ракообразные";
            treeNode7.Name = "anthropod";
            treeNode7.Text = "Членистоногие";
            treeNode8.Name = "bivalvias";
            treeNode8.Text = "Двустворчатые";
            treeNode9.Name = "cephalopods";
            treeNode9.Text = "Головоногие";
            treeNode10.Name = "mollusca";
            treeNode10.Text = "Моллюски";
            treeNode11.Name = "seaurchins";
            treeNode11.Text = "Морские ежи";
            treeNode12.Name = "starfish";
            treeNode12.Text = "Морские звезды";
            treeNode13.Name = "echinoderm";
            treeNode13.Text = "Иглокожие";
            treeNode14.Name = "Amphibians";
            treeNode14.Text = "Земноводные";
            treeNode15.Name = "Birds";
            treeNode15.Text = "Птицы";
            treeNode16.Name = "Fish";
            treeNode16.Text = "Рыбы";
            treeNode17.Name = "Mammals";
            treeNode17.Text = "Млекопитающие";
            treeNode18.Name = "Reptiles";
            treeNode18.Text = "Пресмыкающиеся";
            treeNode19.Name = "vertebrates";
            treeNode19.Text = "Позвоночные";
            treeNode20.Name = "chordata";
            treeNode20.Text = "Хордовые";
            treeNode21.Name = "animals";
            treeNode21.Text = "Животные";
            this.AnimalsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.AnimalsTreeView.Size = new System.Drawing.Size(216, 364);
            this.AnimalsTreeView.TabIndex = 0;
            this.AnimalsTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.AnimalsTreeView_ItemDrag);
            this.AnimalsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AnimalsTreeView_AfterSelect);
            // 
            // info
            // 
            this.info.Controls.Add(this.infotab);
            this.info.Controls.Add(this.CountAnimals);
            this.info.Location = new System.Drawing.Point(234, 27);
            this.info.Name = "info";
            this.info.SelectedIndex = 0;
            this.info.Size = new System.Drawing.Size(292, 367);
            this.info.TabIndex = 1;
            // 
            // infotab
            // 
            this.infotab.Controls.Add(this.DynamicLabel3);
            this.infotab.Controls.Add(this.DynamicLabel2);
            this.infotab.Controls.Add(this.DynamicLabel1);
            this.infotab.Controls.Add(this.LifeTimeUpDown);
            this.infotab.Controls.Add(this.PregnancyUpDown);
            this.infotab.Controls.Add(this.ProgenyUpDown);
            this.infotab.Controls.Add(this.ProgenyLabel);
            this.infotab.Controls.Add(this.LatNameTextBox);
            this.infotab.Controls.Add(this.NameTextBox);
            this.infotab.Controls.Add(this.PregnancyLabel);
            this.infotab.Controls.Add(this.LifeTimeLabel);
            this.infotab.Controls.Add(this.LatNameLabel);
            this.infotab.Controls.Add(this.NameLabel);
            this.infotab.Location = new System.Drawing.Point(4, 22);
            this.infotab.Name = "infotab";
            this.infotab.Padding = new System.Windows.Forms.Padding(3);
            this.infotab.Size = new System.Drawing.Size(284, 341);
            this.infotab.TabIndex = 0;
            this.infotab.Text = "Информация";
            this.infotab.UseVisualStyleBackColor = true;
            // 
            // DynamicLabel3
            // 
            this.DynamicLabel3.AutoSize = true;
            this.DynamicLabel3.Location = new System.Drawing.Point(6, 290);
            this.DynamicLabel3.Name = "DynamicLabel3";
            this.DynamicLabel3.Size = new System.Drawing.Size(34, 13);
            this.DynamicLabel3.TabIndex = 15;
            this.DynamicLabel3.Text = "Text3";
            this.DynamicLabel3.Visible = false;
            // 
            // DynamicLabel2
            // 
            this.DynamicLabel2.AutoSize = true;
            this.DynamicLabel2.Location = new System.Drawing.Point(6, 251);
            this.DynamicLabel2.Name = "DynamicLabel2";
            this.DynamicLabel2.Size = new System.Drawing.Size(34, 13);
            this.DynamicLabel2.TabIndex = 14;
            this.DynamicLabel2.Text = "Text2";
            this.DynamicLabel2.Visible = false;
            // 
            // DynamicLabel1
            // 
            this.DynamicLabel1.AutoSize = true;
            this.DynamicLabel1.Location = new System.Drawing.Point(6, 210);
            this.DynamicLabel1.Name = "DynamicLabel1";
            this.DynamicLabel1.Size = new System.Drawing.Size(34, 13);
            this.DynamicLabel1.TabIndex = 13;
            this.DynamicLabel1.Text = "Text1";
            this.DynamicLabel1.Visible = false;
            // 
            // LifeTimeUpDown
            // 
            this.LifeTimeUpDown.Location = new System.Drawing.Point(9, 109);
            this.LifeTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LifeTimeUpDown.Name = "LifeTimeUpDown";
            this.LifeTimeUpDown.ReadOnly = true;
            this.LifeTimeUpDown.Size = new System.Drawing.Size(260, 20);
            this.LifeTimeUpDown.TabIndex = 12;
            this.LifeTimeUpDown.ValueChanged += new System.EventHandler(this.LifeTimeUpDown_ValueChanged);
            // 
            // PregnancyUpDown
            // 
            this.PregnancyUpDown.Location = new System.Drawing.Point(9, 148);
            this.PregnancyUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PregnancyUpDown.Name = "PregnancyUpDown";
            this.PregnancyUpDown.ReadOnly = true;
            this.PregnancyUpDown.Size = new System.Drawing.Size(260, 20);
            this.PregnancyUpDown.TabIndex = 11;
            this.PregnancyUpDown.ValueChanged += new System.EventHandler(this.PregnancyUpDown_ValueChanged);
            // 
            // ProgenyUpDown
            // 
            this.ProgenyUpDown.Location = new System.Drawing.Point(9, 187);
            this.ProgenyUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ProgenyUpDown.Name = "ProgenyUpDown";
            this.ProgenyUpDown.ReadOnly = true;
            this.ProgenyUpDown.Size = new System.Drawing.Size(260, 20);
            this.ProgenyUpDown.TabIndex = 10;
            this.ProgenyUpDown.ValueChanged += new System.EventHandler(this.ProgenyUpDown_ValueChanged);
            // 
            // ProgenyLabel
            // 
            this.ProgenyLabel.AutoSize = true;
            this.ProgenyLabel.Location = new System.Drawing.Point(6, 171);
            this.ProgenyLabel.Name = "ProgenyLabel";
            this.ProgenyLabel.Size = new System.Drawing.Size(168, 13);
            this.ProgenyLabel.TabIndex = 8;
            this.ProgenyLabel.Text = "Среднее количество потомства";
            // 
            // LatNameTextBox
            // 
            this.LatNameTextBox.Location = new System.Drawing.Point(9, 68);
            this.LatNameTextBox.Name = "LatNameTextBox";
            this.LatNameTextBox.ReadOnly = true;
            this.LatNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.LatNameTextBox.TabIndex = 5;
            this.LatNameTextBox.TextChanged += new System.EventHandler(this.LatNameTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(9, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PregnancyLabel
            // 
            this.PregnancyLabel.AutoSize = true;
            this.PregnancyLabel.Location = new System.Drawing.Point(6, 132);
            this.PregnancyLabel.Name = "PregnancyLabel";
            this.PregnancyLabel.Size = new System.Drawing.Size(205, 13);
            this.PregnancyLabel.TabIndex = 3;
            this.PregnancyLabel.Text = "Длительность беременности (месяцы)";
            // 
            // LifeTimeLabel
            // 
            this.LifeTimeLabel.AutoSize = true;
            this.LifeTimeLabel.Location = new System.Drawing.Point(6, 91);
            this.LifeTimeLabel.Name = "LifeTimeLabel";
            this.LifeTimeLabel.Size = new System.Drawing.Size(222, 13);
            this.LifeTimeLabel.TabIndex = 2;
            this.LifeTimeLabel.Text = "Средняя продолжительность жизни (года)";
            // 
            // LatNameLabel
            // 
            this.LatNameLabel.AutoSize = true;
            this.LatNameLabel.Location = new System.Drawing.Point(6, 51);
            this.LatNameLabel.Name = "LatNameLabel";
            this.LatNameLabel.Size = new System.Drawing.Size(130, 13);
            this.LatNameLabel.TabIndex = 1;
            this.LatNameLabel.Text = "Название на латинском";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название";
            // 
            // CountAnimals
            // 
            this.CountAnimals.Controls.Add(this.UpdateButton);
            this.CountAnimals.Controls.Add(this.ReptilesCountLabel);
            this.CountAnimals.Controls.Add(this.MammalsCountLabel);
            this.CountAnimals.Controls.Add(this.FishCountLabel);
            this.CountAnimals.Controls.Add(this.BirdsCountLabel);
            this.CountAnimals.Controls.Add(this.AmphibiansCountLabel);
            this.CountAnimals.Controls.Add(this.VertebratesCountLabel);
            this.CountAnimals.Controls.Add(this.StarfishCountLabel);
            this.CountAnimals.Controls.Add(this.SeaUrchinsCountLabel);
            this.CountAnimals.Controls.Add(this.CephalobodsCountLabel);
            this.CountAnimals.Controls.Add(this.BivalvesCountLabel);
            this.CountAnimals.Controls.Add(this.label36);
            this.CountAnimals.Controls.Add(this.label37);
            this.CountAnimals.Controls.Add(this.label38);
            this.CountAnimals.Controls.Add(this.label39);
            this.CountAnimals.Controls.Add(this.label40);
            this.CountAnimals.Controls.Add(this.label41);
            this.CountAnimals.Controls.Add(this.label42);
            this.CountAnimals.Controls.Add(this.label43);
            this.CountAnimals.Controls.Add(this.label44);
            this.CountAnimals.Controls.Add(this.label45);
            this.CountAnimals.Controls.Add(this.CrustaceaCountLabel);
            this.CountAnimals.Controls.Add(this.SpidersCountLabel);
            this.CountAnimals.Controls.Add(this.InsectsCountLabel);
            this.CountAnimals.Controls.Add(this.CoralCountLabel);
            this.CountAnimals.Controls.Add(this.JellyfishCountLabel);
            this.CountAnimals.Controls.Add(this.ChordataCountLabel);
            this.CountAnimals.Controls.Add(this.EchinodermCountLabel);
            this.CountAnimals.Controls.Add(this.MolluscaCountLabel);
            this.CountAnimals.Controls.Add(this.AnthropodCountLabel);
            this.CountAnimals.Controls.Add(this.CoelentrataCountLabel);
            this.CountAnimals.Controls.Add(this.AnimalsCountLabel);
            this.CountAnimals.Controls.Add(this.label9);
            this.CountAnimals.Controls.Add(this.label10);
            this.CountAnimals.Controls.Add(this.label11);
            this.CountAnimals.Controls.Add(this.label12);
            this.CountAnimals.Controls.Add(this.label5);
            this.CountAnimals.Controls.Add(this.label6);
            this.CountAnimals.Controls.Add(this.label7);
            this.CountAnimals.Controls.Add(this.label8);
            this.CountAnimals.Controls.Add(this.label3);
            this.CountAnimals.Controls.Add(this.label4);
            this.CountAnimals.Controls.Add(this.label2);
            this.CountAnimals.Controls.Add(this.label1);
            this.CountAnimals.Location = new System.Drawing.Point(4, 22);
            this.CountAnimals.Name = "CountAnimals";
            this.CountAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.CountAnimals.Size = new System.Drawing.Size(284, 341);
            this.CountAnimals.TabIndex = 1;
            this.CountAnimals.Text = "Статистика";
            this.CountAnimals.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(55, 293);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(170, 33);
            this.UpdateButton.TabIndex = 47;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ReptilesCountLabel
            // 
            this.ReptilesCountLabel.AutoSize = true;
            this.ReptilesCountLabel.Location = new System.Drawing.Point(262, 262);
            this.ReptilesCountLabel.Name = "ReptilesCountLabel";
            this.ReptilesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.ReptilesCountLabel.TabIndex = 46;
            this.ReptilesCountLabel.Text = "0";
            // 
            // MammalsCountLabel
            // 
            this.MammalsCountLabel.AutoSize = true;
            this.MammalsCountLabel.Location = new System.Drawing.Point(262, 237);
            this.MammalsCountLabel.Name = "MammalsCountLabel";
            this.MammalsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.MammalsCountLabel.TabIndex = 45;
            this.MammalsCountLabel.Text = "0";
            // 
            // FishCountLabel
            // 
            this.FishCountLabel.AutoSize = true;
            this.FishCountLabel.Location = new System.Drawing.Point(262, 212);
            this.FishCountLabel.Name = "FishCountLabel";
            this.FishCountLabel.Size = new System.Drawing.Size(13, 13);
            this.FishCountLabel.TabIndex = 44;
            this.FishCountLabel.Text = "0";
            // 
            // BirdsCountLabel
            // 
            this.BirdsCountLabel.AutoSize = true;
            this.BirdsCountLabel.Location = new System.Drawing.Point(262, 187);
            this.BirdsCountLabel.Name = "BirdsCountLabel";
            this.BirdsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.BirdsCountLabel.TabIndex = 43;
            this.BirdsCountLabel.Text = "0";
            // 
            // AmphibiansCountLabel
            // 
            this.AmphibiansCountLabel.AutoSize = true;
            this.AmphibiansCountLabel.Location = new System.Drawing.Point(262, 163);
            this.AmphibiansCountLabel.Name = "AmphibiansCountLabel";
            this.AmphibiansCountLabel.Size = new System.Drawing.Size(13, 13);
            this.AmphibiansCountLabel.TabIndex = 42;
            this.AmphibiansCountLabel.Text = "0";
            // 
            // VertebratesCountLabel
            // 
            this.VertebratesCountLabel.AutoSize = true;
            this.VertebratesCountLabel.Location = new System.Drawing.Point(262, 138);
            this.VertebratesCountLabel.Name = "VertebratesCountLabel";
            this.VertebratesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.VertebratesCountLabel.TabIndex = 41;
            this.VertebratesCountLabel.Text = "0";
            // 
            // StarfishCountLabel
            // 
            this.StarfishCountLabel.AutoSize = true;
            this.StarfishCountLabel.Location = new System.Drawing.Point(262, 113);
            this.StarfishCountLabel.Name = "StarfishCountLabel";
            this.StarfishCountLabel.Size = new System.Drawing.Size(13, 13);
            this.StarfishCountLabel.TabIndex = 40;
            this.StarfishCountLabel.Text = "0";
            // 
            // SeaUrchinsCountLabel
            // 
            this.SeaUrchinsCountLabel.AutoSize = true;
            this.SeaUrchinsCountLabel.Location = new System.Drawing.Point(262, 88);
            this.SeaUrchinsCountLabel.Name = "SeaUrchinsCountLabel";
            this.SeaUrchinsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.SeaUrchinsCountLabel.TabIndex = 39;
            this.SeaUrchinsCountLabel.Text = "0";
            // 
            // CephalobodsCountLabel
            // 
            this.CephalobodsCountLabel.AutoSize = true;
            this.CephalobodsCountLabel.Location = new System.Drawing.Point(262, 64);
            this.CephalobodsCountLabel.Name = "CephalobodsCountLabel";
            this.CephalobodsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.CephalobodsCountLabel.TabIndex = 38;
            this.CephalobodsCountLabel.Text = "0";
            // 
            // BivalvesCountLabel
            // 
            this.BivalvesCountLabel.AutoSize = true;
            this.BivalvesCountLabel.Location = new System.Drawing.Point(262, 39);
            this.BivalvesCountLabel.Name = "BivalvesCountLabel";
            this.BivalvesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.BivalvesCountLabel.TabIndex = 37;
            this.BivalvesCountLabel.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(155, 262);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "Пресмыкающиеся";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(155, 237);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(91, 13);
            this.label37.TabIndex = 34;
            this.label37.Text = "Млекопитающих";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(155, 212);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 13);
            this.label38.TabIndex = 33;
            this.label38.Text = "Рыб";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(155, 187);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(32, 13);
            this.label39.TabIndex = 32;
            this.label39.Text = "Птиц";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(155, 163);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 13);
            this.label40.TabIndex = 31;
            this.label40.Text = "Земноводных";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(155, 138);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(75, 13);
            this.label41.TabIndex = 30;
            this.label41.Text = "Позвоночных";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(155, 113);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "Морских звезд";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(155, 88);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(80, 13);
            this.label43.TabIndex = 28;
            this.label43.Text = "Морских ежей";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(155, 64);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 13);
            this.label44.TabIndex = 27;
            this.label44.Text = "Головоногих";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(155, 39);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 13);
            this.label45.TabIndex = 26;
            this.label45.Text = "Двустворчатых";
            // 
            // CrustaceaCountLabel
            // 
            this.CrustaceaCountLabel.AutoSize = true;
            this.CrustaceaCountLabel.Location = new System.Drawing.Point(119, 261);
            this.CrustaceaCountLabel.Name = "CrustaceaCountLabel";
            this.CrustaceaCountLabel.Size = new System.Drawing.Size(13, 13);
            this.CrustaceaCountLabel.TabIndex = 25;
            this.CrustaceaCountLabel.Text = "0";
            // 
            // SpidersCountLabel
            // 
            this.SpidersCountLabel.AutoSize = true;
            this.SpidersCountLabel.Location = new System.Drawing.Point(119, 237);
            this.SpidersCountLabel.Name = "SpidersCountLabel";
            this.SpidersCountLabel.Size = new System.Drawing.Size(13, 13);
            this.SpidersCountLabel.TabIndex = 24;
            this.SpidersCountLabel.Text = "0";
            // 
            // InsectsCountLabel
            // 
            this.InsectsCountLabel.AutoSize = true;
            this.InsectsCountLabel.Location = new System.Drawing.Point(119, 212);
            this.InsectsCountLabel.Name = "InsectsCountLabel";
            this.InsectsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.InsectsCountLabel.TabIndex = 23;
            this.InsectsCountLabel.Text = "0";
            // 
            // CoralCountLabel
            // 
            this.CoralCountLabel.AutoSize = true;
            this.CoralCountLabel.Location = new System.Drawing.Point(119, 187);
            this.CoralCountLabel.Name = "CoralCountLabel";
            this.CoralCountLabel.Size = new System.Drawing.Size(13, 13);
            this.CoralCountLabel.TabIndex = 22;
            this.CoralCountLabel.Text = "0";
            // 
            // JellyfishCountLabel
            // 
            this.JellyfishCountLabel.AutoSize = true;
            this.JellyfishCountLabel.Location = new System.Drawing.Point(119, 162);
            this.JellyfishCountLabel.Name = "JellyfishCountLabel";
            this.JellyfishCountLabel.Size = new System.Drawing.Size(13, 13);
            this.JellyfishCountLabel.TabIndex = 21;
            this.JellyfishCountLabel.Text = "0";
            // 
            // ChordataCountLabel
            // 
            this.ChordataCountLabel.AutoSize = true;
            this.ChordataCountLabel.Location = new System.Drawing.Point(119, 138);
            this.ChordataCountLabel.Name = "ChordataCountLabel";
            this.ChordataCountLabel.Size = new System.Drawing.Size(13, 13);
            this.ChordataCountLabel.TabIndex = 20;
            this.ChordataCountLabel.Text = "0";
            // 
            // EchinodermCountLabel
            // 
            this.EchinodermCountLabel.AutoSize = true;
            this.EchinodermCountLabel.Location = new System.Drawing.Point(119, 113);
            this.EchinodermCountLabel.Name = "EchinodermCountLabel";
            this.EchinodermCountLabel.Size = new System.Drawing.Size(13, 13);
            this.EchinodermCountLabel.TabIndex = 19;
            this.EchinodermCountLabel.Text = "0";
            // 
            // MolluscaCountLabel
            // 
            this.MolluscaCountLabel.AutoSize = true;
            this.MolluscaCountLabel.Location = new System.Drawing.Point(119, 88);
            this.MolluscaCountLabel.Name = "MolluscaCountLabel";
            this.MolluscaCountLabel.Size = new System.Drawing.Size(13, 13);
            this.MolluscaCountLabel.TabIndex = 18;
            this.MolluscaCountLabel.Text = "0";
            // 
            // AnthropodCountLabel
            // 
            this.AnthropodCountLabel.AutoSize = true;
            this.AnthropodCountLabel.Location = new System.Drawing.Point(119, 63);
            this.AnthropodCountLabel.Name = "AnthropodCountLabel";
            this.AnthropodCountLabel.Size = new System.Drawing.Size(13, 13);
            this.AnthropodCountLabel.TabIndex = 17;
            this.AnthropodCountLabel.Text = "0";
            // 
            // CoelentrataCountLabel
            // 
            this.CoelentrataCountLabel.AutoSize = true;
            this.CoelentrataCountLabel.Location = new System.Drawing.Point(119, 39);
            this.CoelentrataCountLabel.Name = "CoelentrataCountLabel";
            this.CoelentrataCountLabel.Size = new System.Drawing.Size(13, 13);
            this.CoelentrataCountLabel.TabIndex = 16;
            this.CoelentrataCountLabel.Text = "0";
            // 
            // AnimalsCountLabel
            // 
            this.AnimalsCountLabel.AutoSize = true;
            this.AnimalsCountLabel.Location = new System.Drawing.Point(185, 15);
            this.AnimalsCountLabel.Name = "AnimalsCountLabel";
            this.AnimalsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.AnimalsCountLabel.TabIndex = 15;
            this.AnimalsCountLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ракообразных";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Паукообразных";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Насекомых";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Кораллов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Медуз";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Хордовых";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Иглокожих";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Моллюсков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Членистоногих";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кишечнополостных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Животных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.SaveFileSimpleToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // LoadFileToolStripMenuItem
            // 
            this.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            this.LoadFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.LoadFileToolStripMenuItem.Text = "Загрузить";
            this.LoadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить как";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // SaveFileSimpleToolStripMenuItem
            // 
            this.SaveFileSimpleToolStripMenuItem.Name = "SaveFileSimpleToolStripMenuItem";
            this.SaveFileSimpleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveFileSimpleToolStripMenuItem.Text = "Сохранить";
            this.SaveFileSimpleToolStripMenuItem.Click += new System.EventHandler(this.SaveFileSimpleToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // элементToolStripMenuItem
            // 
            this.элементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.DeleteElementToolStripMenuItem});
            this.элементToolStripMenuItem.Name = "элементToolStripMenuItem";
            this.элементToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.элементToolStripMenuItem.Text = "Элемент";
            // 
            // AddElementToolStripMenuItem
            // 
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddElementToolStripMenuItem.Text = "Добавить";
            this.AddElementToolStripMenuItem.Click += new System.EventHandler(this.customControl11_Click);
            // 
            // DeleteElementToolStripMenuItem
            // 
            this.DeleteElementToolStripMenuItem.Name = "DeleteElementToolStripMenuItem";
            this.DeleteElementToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.DeleteElementToolStripMenuItem.Text = "Удалить";
            this.DeleteElementToolStripMenuItem.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // EditCheckBox
            // 
            this.EditCheckBox.AutoSize = true;
            this.EditCheckBox.Location = new System.Drawing.Point(238, 400);
            this.EditCheckBox.Name = "EditCheckBox";
            this.EditCheckBox.Size = new System.Drawing.Size(103, 17);
            this.EditCheckBox.TabIndex = 7;
            this.EditCheckBox.Text = "Редактировать";
            this.EditCheckBox.UseVisualStyleBackColor = true;
            this.EditCheckBox.CheckedChanged += new System.EventHandler(this.EditCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 456);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(538, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SortCustomControl13
            // 
            this.SortCustomControl13.BackColor = System.Drawing.SystemColors.Control;
            this.SortCustomControl13.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SortCustomControl13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortCustomControl13.Location = new System.Drawing.Point(234, 426);
            this.SortCustomControl13.Name = "SortCustomControl13";
            this.SortCustomControl13.Size = new System.Drawing.Size(107, 23);
            this.SortCustomControl13.TabIndex = 14;
            this.SortCustomControl13.Text = "Сортировка А-Я";
            this.SortCustomControl13.UseVisualStyleBackColor = false;
            this.SortCustomControl13.Click += new System.EventHandler(this.SortCustomControl13_Click);
            // 
            // customControl21
            // 
            this.customControl21.Location = new System.Drawing.Point(347, 400);
            this.customControl21.Name = "customControl21";
            this.customControl21.Size = new System.Drawing.Size(119, 23);
            this.customControl21.TabIndex = 12;
            this.customControl21.Text = "Нажми на меня :)";
            this.customControl21.UseVisualStyleBackColor = true;
            // 
            // customControl12
            // 
            this.customControl12.AllowDrop = true;
            this.customControl12.BackColor = System.Drawing.SystemColors.Control;
            this.customControl12.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.customControl12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customControl12.Location = new System.Drawing.Point(12, 426);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(215, 23);
            this.customControl12.TabIndex = 11;
            this.customControl12.Text = "Удалить животное";
            this.customControl12.UseVisualStyleBackColor = false;
            this.customControl12.Click += new System.EventHandler(this.DeleteButton_Click);
            this.customControl12.DragDrop += new System.Windows.Forms.DragEventHandler(this.CustomControl12_DragDrop);
            this.customControl12.DragEnter += new System.Windows.Forms.DragEventHandler(this.CustomControl12_DragEnter);
            // 
            // customControl11
            // 
            this.customControl11.BackColor = System.Drawing.SystemColors.Control;
            this.customControl11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customControl11.Location = new System.Drawing.Point(12, 397);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(215, 23);
            this.customControl11.TabIndex = 10;
            this.customControl11.Text = "Добавить новое животное";
            this.customControl11.UseVisualStyleBackColor = false;
            this.customControl11.Click += new System.EventHandler(this.customControl11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 500);
            this.Controls.Add(this.SortCustomControl13);
            this.Controls.Add(this.customControl21);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EditCheckBox);
            this.Controls.Add(this.info);
            this.Controls.Add(this.AnimalsTreeView);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Иерархия животного мира";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.info.ResumeLayout(false);
            this.infotab.ResumeLayout(false);
            this.infotab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LifeTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PregnancyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgenyUpDown)).EndInit();
            this.CountAnimals.ResumeLayout(false);
            this.CountAnimals.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView AnimalsTreeView;
        private System.Windows.Forms.TabControl info;
        private System.Windows.Forms.TabPage infotab;
        private System.Windows.Forms.TabPage CountAnimals;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ProgenyLabel;
        private System.Windows.Forms.TextBox LatNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label PregnancyLabel;
        private System.Windows.Forms.Label LifeTimeLabel;
        private System.Windows.Forms.Label LatNameLabel;
        private System.Windows.Forms.NumericUpDown LifeTimeUpDown;
        private System.Windows.Forms.NumericUpDown PregnancyUpDown;
        private System.Windows.Forms.NumericUpDown ProgenyUpDown;
        private System.Windows.Forms.CheckBox EditCheckBox;
        private System.Windows.Forms.Label DynamicLabel3;
        private System.Windows.Forms.Label DynamicLabel2;
        private System.Windows.Forms.Label DynamicLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripMenuItem SaveFileSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private CustomControl1 customControl11;
        private CustomControl1 customControl12;
        private CustomControl2 customControl21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ReptilesCountLabel;
        private System.Windows.Forms.Label MammalsCountLabel;
        private System.Windows.Forms.Label FishCountLabel;
        private System.Windows.Forms.Label BirdsCountLabel;
        private System.Windows.Forms.Label AmphibiansCountLabel;
        private System.Windows.Forms.Label VertebratesCountLabel;
        private System.Windows.Forms.Label StarfishCountLabel;
        private System.Windows.Forms.Label SeaUrchinsCountLabel;
        private System.Windows.Forms.Label CephalobodsCountLabel;
        private System.Windows.Forms.Label BivalvesCountLabel;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label CrustaceaCountLabel;
        private System.Windows.Forms.Label SpidersCountLabel;
        private System.Windows.Forms.Label InsectsCountLabel;
        private System.Windows.Forms.Label CoralCountLabel;
        private System.Windows.Forms.Label JellyfishCountLabel;
        private System.Windows.Forms.Label ChordataCountLabel;
        private System.Windows.Forms.Label EchinodermCountLabel;
        private System.Windows.Forms.Label MolluscaCountLabel;
        private System.Windows.Forms.Label AnthropodCountLabel;
        private System.Windows.Forms.Label CoelentrataCountLabel;
        private System.Windows.Forms.Label AnimalsCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private CustomControl1 SortCustomControl13;
    }
}

