using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace vp_course
{
    public partial class Form1 : Form
    {
        public static List<Animal> Animals = new List<Animal>();
        ToolStripLabel timeStartLabel, dateLabel, timeLabel;
        private static ulong timeSec = 0;
        const int SizeW = 260;
        const int SizeH = 20;
        TextBox DynamicTextBox1 = new TextBox();
        TextBox DynamicTextBox2 = new TextBox();
        TextBox DynamicTextBox3 = new TextBox();
        NumericUpDown DynamicUpDown1 = new NumericUpDown();
        NumericUpDown DynamicUpDown2 = new NumericUpDown();
        NumericUpDown DynamicUpDown3 = new NumericUpDown();
        List<Control> DynamicControls = new List<Control>();
        string CurrentFile = "";
        string FormName = "Иерархия животного мира";
        public Form1()
        {
            InitializeComponent();
            TreeContext();
            DynamicTextBox1.Location = new Point(9, 228);
            DynamicTextBox2.Location = new Point(9, 267);
            DynamicTextBox3.Location = new Point(9, 306);
            DynamicTextBox1.Size = new Size(SizeW, SizeH);
            DynamicTextBox2.Size = new Size(SizeW, SizeH);
            DynamicTextBox3.Size = new Size(SizeW, SizeH);
            DynamicUpDown1.Location = new Point(9, 228);
            DynamicUpDown2.Location = new Point(9, 267);
            DynamicUpDown3.Location = new Point(9, 306);
            DynamicUpDown1.Size = new Size(SizeW, SizeH);
            DynamicUpDown2.Size = new Size(SizeW, SizeH);
            DynamicUpDown3.Size = new Size(SizeW, SizeH);
            DynamicTextBox1.TextChanged += DynamicTextBox1_TextChanged;
            DynamicTextBox2.TextChanged += DynamicTextBox2_TextChanged;
            DynamicTextBox3.TextChanged += DynamicTextBox3_TextChanged;
            DynamicUpDown1.ValueChanged += DynamicUpDown1_ValueChanged;
            DynamicUpDown2.ValueChanged += DynamicUpDown2_ValueChanged;
            DynamicUpDown3.ValueChanged += DynamicUpDown3_ValueChanged;
            DynamicTextBox1.ReadOnly = true;
            DynamicTextBox2.ReadOnly = true;
            DynamicTextBox3.ReadOnly = true;
            DynamicUpDown1.ReadOnly = true;
            DynamicUpDown2.ReadOnly = true;
            DynamicUpDown3.ReadOnly = true;
            DynamicUpDown1.Maximum = 10000;
            DynamicUpDown2.Maximum = 10000;
            DynamicUpDown3.Maximum = 10000;
            StatusStrip1Initizlization();
            StatusStrip2Initizlization(); 
            this.ControlAdded += Form1_ControlAdded;
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                    c.KeyUp += TextBoxKeyUp;
            }
        }
        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is TextBox)
            {
                (e.Control as TextBox).KeyUp += TextBoxKeyUp;
            }
        }
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
                (sender as TextBox).Paste();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        void timer_Tick2(object sender, EventArgs e)
        {
            timeSec += 1;
            timeStartLabel.Text = timeSec.ToString();
        }
        private void StatusStrip1Initizlization()
        {
            ToolStripLabel infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            Timer timer2 = new Timer() { Interval = 1000 };
            timer2.Tick += timer_Tick2;
            timer.Start();
            timer2.Start();
        }
        private void StatusStrip2Initizlization()
        {
            ToolStripLabel infoLabel = new ToolStripLabel();
            infoLabel.Text = "Время работы программы в секундах:";
            timeStartLabel = new ToolStripLabel();
            statusStrip2.Items.Add(infoLabel);
            statusStrip2.Items.Add(timeStartLabel);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void Form1_Load(object sender, EventArgs e){
        }
        private void ClearInfo()
        {
            bool editing = false;
            if (EditCheckBox.Checked == true)
            {
                EditCheckBox.Checked = false;
                editing = true;
            }
            NameTextBox.Text = "";
            LatNameTextBox.Text = "";
            LifeTimeUpDown.Value = 0;
            PregnancyUpDown.Value = 0;
            ProgenyUpDown.Value = 0;
            if (editing == true)
                EditCheckBox.Checked = true;
        }

        private void DynamicTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {

                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Coelenterata c:
                        c.ReproductionType = DynamicTextBox1.Text;
                        break;
                    case Anthropod a:
                        a.Wings = DynamicTextBox1.Text;
                        break;
                    case Chordata ch:
                        ch.Skull = DynamicTextBox1.Text;
                        break;
                }
            }
        }
        private void DynamicTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Corals c:
                        c.Color = DynamicTextBox1.Text;
                        break;
                    case Bivalvias b:
                        b.Pattern = DynamicTextBox1.Text;
                        break;
                    case Starfish s:
                        s.StarSize = DynamicTextBox1.Text;
                        break;
                    case Vertebrates v:
                        v.RespiratorySystem = DynamicTextBox1.Text;
                        break;
                }
            }
        }
        private void DynamicTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Amphibians a:
                        a.Tail = DynamicTextBox1.Text;
                        break;
                    case Fish f:
                        f.ScalesType = DynamicTextBox1.Text;
                        break;
                    case Mammals m:
                        m.WoolType = DynamicTextBox1.Text;
                        break;
                    case Reptiles r:
                        r.CoverType = DynamicTextBox1.Text;
                        break;
                }
            }
        }
        private void DynamicUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Mollusca m:
                        m.AtriaNumb = (int)DynamicUpDown1.Value;
                        break;
                    case Echinoderm ech:
                        ech.RaysNumb = (int)DynamicUpDown1.Value;
                        break;
                }
            }
        }
        private void DynamicUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Jellyfish j:
                        j.TentacleLength = (int)DynamicUpDown1.Value;
                        break;
                    case Insects insects:
                        insects.Facets = (int)DynamicUpDown1.Value;
                        break;
                    case Spiders s:
                        s.Eyes = (int)DynamicUpDown1.Value;
                        break;
                    case Crustaceans c:
                        c.Segments = (int)DynamicUpDown1.Value;
                        break;
                    case Cephalopods cephalopods:
                        cephalopods.Tentacles = (int)DynamicUpDown1.Value;
                        break;
                    case SeaUrchins seaUrchins:
                        seaUrchins.RayLength = (int)DynamicUpDown1.Value;
                        break;
                }
            }
        }
        private void DynamicUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                switch (animal)
                {
                    case Birds b:
                        b.WingsSize = (int)DynamicUpDown1.Value;
                        break;
                }
            }
        }
        private void AnimalsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string text = AnimalsTreeView.SelectedNode.Text;
            if (text == "Животные" || text == "Кишечнополостные" || text == "Членистоногие" || text == "Моллюски" || text == "Иглокожие" || text == "Хордовые" || text == "Медузы" || text == "Кораллы" || text == "Насекомые" || text == "Паукообразные" || text == "Ракообразные" || text == "Двустворчатые" || text == "Головоногие" || text == "Морские ежи" || text == "Морские звезды" || text == "Позвоночные" || text == "Земноводные" || text == "Птицы" || text == "Рыбы" || text == "Млекопитающие" || text == "Пресмыкающиеся")
            {
                ClearInfo();
                foreach (Control c in DynamicControls)
                    infotab.Controls.Remove(c);
                DynamicControls.Clear();
                DynamicLabel1.Visible = false;
                DynamicLabel2.Visible = false;
                DynamicLabel3.Visible = false;
            }
            else
            {
                ClearInfo();
                Animal animal = Animals.Find(x => x.Name == text);
                NameTextBox.Text = animal.Name;
                LatNameTextBox.Text = animal.LatName;
                LifeTimeUpDown.Value = animal.Lifetime;
                PregnancyUpDown.Value = animal.Pregnancy;
                ProgenyUpDown.Value = animal.Progeny;
                switch (animal)
                {
                    case Jellyfish j:
                        DynamicLabel1.Text = "Тип размножения";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Длина щупалец";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = j.ReproductionType;
                        DynamicUpDown2.Value = (decimal)j.TentacleLength;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case Corals corals:
                        DynamicLabel1.Text = "Тип размножения";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Цвет";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = corals.ReproductionType;
                        DynamicTextBox2.Text = corals.Color;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        break;
                    case Insects i:
                        DynamicLabel1.Text = "Наличие крыльев";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Количество фасеток";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = i.Wings;
                        DynamicUpDown2.Value = (decimal)i.Facets;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case Spiders s:
                        DynamicLabel1.Text = "Наличие крыльев";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Количество глаз";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = s.Wings;
                        DynamicUpDown2.Value = (decimal)s.Eyes;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case Crustaceans crustaceans:
                        DynamicLabel1.Text = "Наличие крыльев";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Количество сегментов тела";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = crustaceans.Wings;
                        DynamicUpDown2.Value = (decimal)crustaceans.Segments;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case Bivalvias b:
                        DynamicLabel1.Text = "Количество предсердий";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Узор на панцыре";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicUpDown1.Value = (decimal)b.AtriaNumb;
                        DynamicTextBox2.Text = b.Pattern;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicUpDown1);
                        infotab.Controls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicUpDown1);
                        DynamicControls.Add(DynamicTextBox2);
                        break;
                    case Cephalopods cephalopods:
                        DynamicLabel1.Text = "Количество предсердий";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Количество щупалец";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicUpDown1.Value = (decimal)cephalopods.AtriaNumb;
                        DynamicUpDown2.Value = (decimal)cephalopods.Tentacles;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicUpDown1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicUpDown1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case SeaUrchins seaurchins:
                        DynamicLabel1.Text = "Количество лучей";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Длина лучей (см)";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicUpDown1.Value = (decimal)seaurchins.RaysNumb;
                        DynamicUpDown2.Value = (decimal)seaurchins.RayLength;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicUpDown1);
                        infotab.Controls.Add(DynamicUpDown2);
                        DynamicControls.Add(DynamicUpDown1);
                        DynamicControls.Add(DynamicUpDown2);
                        break;
                    case Starfish starfish:
                        DynamicLabel1.Text = "Количество лучей";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Размер звезды (см)";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Visible = false;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicUpDown1.Value = (decimal)starfish.RaysNumb;
                        DynamicTextBox2.Text = starfish.StarSize;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicUpDown1);
                        infotab.Controls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicUpDown1);
                        DynamicControls.Add(DynamicTextBox2);
                        break;
                    case Amphibians amphibians:
                        DynamicLabel1.Text = "Наличие черепа";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Органы дыхания";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Text = "Наличие хвоста";
                        DynamicLabel3.Visible = true;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = amphibians.Skull;
                        DynamicTextBox2.Text = amphibians.RespiratorySystem;
                        DynamicTextBox3.Text = amphibians.Tail;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        infotab.Controls.Add(DynamicTextBox3);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicTextBox3);
                        break;
                    case Birds birds:
                        DynamicLabel1.Text = "Наличие черепа";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Органы дыхания";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Text = "Размах крыльев (м)";
                        DynamicLabel3.Visible = true;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = birds.Skull;
                        DynamicTextBox2.Text = birds.RespiratorySystem;
                        DynamicUpDown3.Value = (decimal)birds.WingsSize;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        infotab.Controls.Add(DynamicUpDown3);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicUpDown3);
                        break;
                    case Fish fish:
                        DynamicLabel1.Text = "Наличие черепа";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Органы дыхания";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Text = "Тип чешуи";
                        DynamicLabel3.Visible = true;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = fish.Skull;
                        DynamicTextBox2.Text = fish.RespiratorySystem;
                        DynamicTextBox3.Text = fish.ScalesType;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        infotab.Controls.Add(DynamicTextBox3);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicTextBox3);
                        break;
                    case Mammals mammals:
                        DynamicLabel1.Text = "Наличие черепа";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Органы дыхания";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Text = "Тип шерсти";
                        DynamicLabel3.Visible = true;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = mammals.Skull;
                        DynamicTextBox2.Text = mammals.RespiratorySystem;
                        DynamicTextBox3.Text = mammals.WoolType;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        infotab.Controls.Add(DynamicTextBox3);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicTextBox3);
                        break;
                    case Reptiles reptiles:
                        DynamicLabel1.Text = "Наличие черепа";
                        DynamicLabel1.Visible = true;
                        DynamicLabel2.Text = "Органы дыхания";
                        DynamicLabel2.Visible = true;
                        DynamicLabel3.Text = "Тип покрова";
                        DynamicLabel3.Visible = true;
                        foreach (Control c in DynamicControls)
                        {
                            infotab.Controls.Remove(c);
                        }
                        DynamicTextBox1.Text = reptiles.Skull;
                        DynamicTextBox2.Text = reptiles.RespiratorySystem;
                        DynamicTextBox3.Text = reptiles.CoverType;
                        DynamicControls.Clear();
                        infotab.Controls.Add(DynamicTextBox1);
                        infotab.Controls.Add(DynamicTextBox2);
                        infotab.Controls.Add(DynamicTextBox3);
                        DynamicControls.Add(DynamicTextBox1);
                        DynamicControls.Add(DynamicTextBox2);
                        DynamicControls.Add(DynamicTextBox3);
                        break;
                }
            }
        }

        private void EditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                NameTextBox.ReadOnly = false;
                LatNameTextBox.ReadOnly = false;
                LifeTimeUpDown.ReadOnly = false;
                PregnancyUpDown.ReadOnly = false;
                ProgenyUpDown.ReadOnly = false;
                DynamicTextBox1.ReadOnly = false;
                DynamicTextBox2.ReadOnly = false;
                DynamicTextBox3.ReadOnly = false;
                DynamicUpDown1.ReadOnly = false;
                DynamicUpDown2.ReadOnly = false;
                DynamicUpDown3.ReadOnly = false;
            }
            else
            {
                NameTextBox.ReadOnly = true;
                LatNameTextBox.ReadOnly = true;
                LifeTimeUpDown.ReadOnly = true;
                PregnancyUpDown.ReadOnly = true;
                ProgenyUpDown.ReadOnly = true;
                DynamicTextBox1.ReadOnly = true;
                DynamicTextBox2.ReadOnly = true;
                DynamicTextBox3.ReadOnly = true;
                DynamicUpDown1.ReadOnly = true;
                DynamicUpDown2.ReadOnly = true;
                DynamicUpDown3.ReadOnly = true;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                animal.Name = NameTextBox.Text;
                AnimalsTreeView.SelectedNode.Text = animal.Name;
            }
        }

        private void LatNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                animal.LatName = LatNameTextBox.Text;
            }
        }

        private void LifeTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                animal.Lifetime = (int)LifeTimeUpDown.Value;
            }
        }

        private void PregnancyUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                animal.Pregnancy = (int)PregnancyUpDown.Value;
            }
        }

        private void ProgenyUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                Animal animal = Animals.Find(x => x.Name == AnimalsTreeView.SelectedNode.Text);
                animal.Progeny = (int)ProgenyUpDown.Value;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private bool ContainsAnimal(TreeNode node, string name)
        {
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Text == name)
                    return true;
            }
            return false;
        }

        private void ClearTree()
        {
            try
            {
                AnimalsTreeView.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[0].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[1].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[2].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[2].Nodes[0].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[2].Nodes[1].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[3].Nodes[0].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[3].Nodes[1].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[0].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[1].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[2].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[3].Nodes.Clear();
                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[4].Nodes.Clear();
                //throw new ArgumentException("Коллекция содержит объект недопустимого типа!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTree()
        {
            try
            {
                foreach (var a in Animals)
                {
                    switch (a)
                    {
                        case Jellyfish j:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[0].Nodes[0], j.Name))
                                AnimalsTreeView.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(j.Name);
                            break;
                        case Corals c:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[0].Nodes[1], c.Name))
                                AnimalsTreeView.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(c.Name);
                            break;
                        case Insects i:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[1].Nodes[0], i.Name))
                                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(i.Name);
                            break;
                        case Spiders s:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[1].Nodes[1], s.Name))
                                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(s.Name);
                            break;
                        case Crustaceans cru:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[1].Nodes[2], cru.Name))
                                AnimalsTreeView.Nodes[0].Nodes[1].Nodes[2].Nodes.Add(cru.Name);
                            break;
                        case Bivalvias b:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[2].Nodes[0], b.Name))
                                AnimalsTreeView.Nodes[0].Nodes[2].Nodes[0].Nodes.Add(b.Name);
                            break;
                        case Cephalopods ceph:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[2].Nodes[1], ceph.Name))
                                AnimalsTreeView.Nodes[0].Nodes[2].Nodes[1].Nodes.Add(ceph.Name);
                            break;
                        case SeaUrchins sea:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[3].Nodes[0], sea.Name))
                                AnimalsTreeView.Nodes[0].Nodes[3].Nodes[0].Nodes.Add(sea.Name);
                            break;
                        case Starfish starfish:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[3].Nodes[1], starfish.Name))
                                AnimalsTreeView.Nodes[0].Nodes[3].Nodes[1].Nodes.Add(starfish.Name);
                            break;
                        case Amphibians amphibians:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[0], amphibians.Name))
                                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[0].Nodes.Add(amphibians.Name);
                            break;
                        case Birds birds:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[1], birds.Name))
                                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[1].Nodes.Add(birds.Name);
                            break;
                        case Fish fish:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[2], fish.Name))
                                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[2].Nodes.Add(fish.Name);
                            break;
                        case Mammals m:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[3], m.Name))
                                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[3].Nodes.Add(m.Name);
                            break;
                        case Reptiles reptiles:
                            if (!ContainsAnimal(AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[4], reptiles.Name))
                                AnimalsTreeView.Nodes[0].Nodes[4].Nodes[0].Nodes[4].Nodes.Add(reptiles.Name);
                            break;
                        //default:
                            //throw new ArgumentException("Коллекция содержит объект недопустимого типа!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            FillTree();
        }
        /*DeleteButton_Click
         * string text = AnimalsTreeView.SelectedNode.Text;
            try
            {
                if (text == "Животные" || text == "Кишечнополостные" || text == "Членистоногие" || text == "Моллюски" || text == "Иглокожие" || text == "Хордовые" || text == "Медузы" || text == "Кораллы" || text == "Насекомые" || text == "Паукообразные" || text == "Ракообразные" || text == "Двустворчатые" || text == "Головоногие" || text == "Морские ежи" || text == "Морские звезды" || text == "Позвоночные" || text == "Земноводные" || text == "Птицы" || text == "Рыбы" || text == "Млекопитающие" || text == "Пресмыкающиеся")
                {
                    throw new Exception("Нельзя удалить класс!");
                }
                Animal animal = Animals.Find(x => x.Name == text);
                Animals.Remove(animal);
                AnimalsTreeView.SelectedNode.Parent.Nodes.Remove(AnimalsTreeView.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         */
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string text = AnimalsTreeView.SelectedNode.Text;
            try
            {
                if (text == "Животные" || text == "Кишечнополостные" || text == "Членистоногие" || text == "Моллюски" || text == "Иглокожие" || text == "Хордовые" || text == "Медузы" || text == "Кораллы" || text == "Насекомые" || text == "Паукообразные" || text == "Ракообразные" || text == "Двустворчатые" || text == "Головоногие" || text == "Морские ежи" || text == "Морские звезды" || text == "Позвоночные" || text == "Земноводные" || text == "Птицы" || text == "Рыбы" || text == "Млекопитающие" || text == "Пресмыкающиеся")
                {
                    throw new Exception("Нельзя удалить класс!");
                }
                Animal animal = Animals.Find(x => x.Name == text);
                Animals.Remove(animal);
                AnimalsTreeView.SelectedNode.Parent.Nodes.Remove(AnimalsTreeView.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                if ((CurrentFile != null) && (CurrentFile != ""))
                {
                    Type[] Types = new Type[14];
                    Types[0] = typeof(Jellyfish);
                    Types[1] = typeof(Corals);
                    Types[2] = typeof(Insects);
                    Types[3] = typeof(Spiders);
                    Types[4] = typeof(Crustaceans);
                    Types[5] = typeof(Bivalvias);
                    Types[6] = typeof(Cephalopods);
                    Types[7] = typeof(SeaUrchins);
                    Types[8] = typeof(Starfish);
                    Types[9] = typeof(Amphibians);
                    Types[10] = typeof(Birds);
                    Types[11] = typeof(Fish);
                    Types[12] = typeof(Mammals);
                    Types[13] = typeof(Reptiles);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>), Types);
                    using (FileStream file = new FileStream(CurrentFile, FileMode.OpenOrCreate))
                    {
                        serializer.Serialize(file, Animals);
                    }
                    this.Text = FormName + " " + CurrentFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveFile()
        {

            try
            {
                if ((CurrentFile != null) && (CurrentFile != ""))
                {
                    Type[] Types = new Type[14];
                    Types[0] = typeof(Jellyfish);
                    Types[1] = typeof(Corals);
                    Types[2] = typeof(Insects);
                    Types[3] = typeof(Spiders);
                    Types[4] = typeof(Crustaceans);
                    Types[5] = typeof(Bivalvias);
                    Types[6] = typeof(Cephalopods);
                    Types[7] = typeof(SeaUrchins);
                    Types[8] = typeof(Starfish);
                    Types[9] = typeof(Amphibians);
                    Types[10] = typeof(Birds);
                    Types[11] = typeof(Fish);
                    Types[12] = typeof(Mammals);
                    Types[13] = typeof(Reptiles);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>), Types);
                    using (FileStream file = new FileStream(CurrentFile, FileMode.OpenOrCreate))
                    {
                        file.SetLength(0);
                        file.Flush();
                        serializer.Serialize(file, Animals);
                    }
                    this.Text = FormName + " " + CurrentFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadFile()
        {
            DialogResult res = MessageBox.Show("Любые несохраненные изменения будут потеряны. Вы уверены, что хотите загрузить файл?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    openFileDialog1.ShowDialog();
                    if ((CurrentFile != null) && (CurrentFile != ""))
                    {
                        Type[] Types = new Type[14];
                        Types[0] = typeof(Jellyfish);
                        Types[1] = typeof(Corals);
                        Types[2] = typeof(Insects);
                        Types[3] = typeof(Spiders);
                        Types[4] = typeof(Crustaceans);
                        Types[5] = typeof(Bivalvias);
                        Types[6] = typeof(Cephalopods);
                        Types[7] = typeof(SeaUrchins);
                        Types[8] = typeof(Starfish);
                        Types[9] = typeof(Amphibians);
                        Types[10] = typeof(Birds);
                        Types[11] = typeof(Fish);
                        Types[12] = typeof(Mammals);
                        Types[13] = typeof(Reptiles);
                        XmlSerializer deserializer = new XmlSerializer(typeof(List<Animal>), Types);
                        using (FileStream file = new FileStream(CurrentFile, FileMode.OpenOrCreate))
                        {
                            Animals = (List<Animal>)deserializer.Deserialize(file);
                        }
                        //AnimalsTreeView.Nodes.Clear();
                        ClearTree();
                        FillTree();
                        this.Text = FormName + " " + CurrentFile;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Неправильно указан файл или содержимое имеет неверный формат. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            CurrentFile = openFileDialog1.FileName;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.Control && e.KeyCode == Keys.S)
                    SaveFile();
                if (e.Control && e.KeyCode == Keys.L)
                    LoadFile();
                if (e.Control && e.KeyCode == Keys.P)
                    customControl11_Click(new object(), new EventArgs());
                if (e.KeyCode == Keys.Delete)
                    DeleteButton_Click(new object(), new EventArgs());
                if (e.Control && e.KeyCode == Keys.I)
                    AboutToolStripMenuItem_Click(new object(), new EventArgs());
                if (e.KeyCode == Keys.F1)
                    HelpToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help a = new Help();
            a.ShowDialog();
        }

        private void SaveFileSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void customControl11_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void AnimalsTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string text = AnimalsTreeView.SelectedNode.Text;
            if (text == "Животные" || text == "Кишечнополостные" || text == "Членистоногие" || text == "Моллюски" || text == "Иглокожие" || text == "Хордовые" || text == "Медузы" || text == "Кораллы" || text == "Насекомые" || text == "Паукообразные" || text == "Ракообразные" || text == "Двустворчатые" || text == "Головоногие" || text == "Морские ежи" || text == "Морские звезды" || text == "Позвоночные" || text == "Земноводные" || text == "Птицы" || text == "Рыбы" || text == "Млекопитающие" || text == "Пресмыкающиеся")
            {
                MessageBox.Show("Нельзя удалить класс!");
            }
            else
            {
                AnimalsTreeView.DoDragDrop(AnimalsTreeView.SelectedNode, DragDropEffects.Move);
            }
        }

        private void CustomControl12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void CustomControl12_DragDrop(object sender, DragEventArgs e)
        {
            string text = AnimalsTreeView.SelectedNode.Text;
            try
            {
                if (text == "Животные" || text == "Кишечнополостные" || text == "Членистоногие" || text == "Моллюски" || text == "Иглокожие" || text == "Хордовые" || text == "Медузы" || text == "Кораллы" || text == "Насекомые" || text == "Паукообразные" || text == "Ракообразные" || text == "Двустворчатые" || text == "Головоногие" || text == "Морские ежи" || text == "Морские звезды" || text == "Позвоночные" || text == "Земноводные" || text == "Птицы" || text == "Рыбы" || text == "Млекопитающие" || text == "Пресмыкающиеся")
                {
                    throw new Exception("Нельзя удалить класс!");
                }
                Animal animal = Animals.Find(x => x.Name == text);
                Animals.Remove(animal);
                AnimalsTreeView.SelectedNode.Parent.Nodes.Remove(AnimalsTreeView.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            CurrentFile = saveFileDialog1.FileName + ".xml";
        }

        public void TreeContext()
        {
            AnimalsTreeView.ContextMenuStrip = contextMenuStrip1;
            ToolStripMenuItem AddMenuItem = new ToolStripMenuItem("Добавить");
            ToolStripMenuItem EditMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem DeleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { AddMenuItem, EditMenuItem, DeleteMenuItem });
            AddMenuItem.Click += AddMenuItem_Click;
            EditMenuItem.Click += EditMenuItem_Click;
            DeleteMenuItem.Click += DeleteMenuItem_Click;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AnimalsCountLabel.Text = Animal.count(Animals).ToString();
            AmphibiansCountLabel.Text = Amphibians.count(Animals).ToString();
            AnthropodCountLabel.Text = Anthropod.count(Animals).ToString();
            BirdsCountLabel.Text = Birds.count(Animals).ToString();
            BivalvesCountLabel.Text = Bivalvias.count(Animals).ToString();
            CephalobodsCountLabel.Text = Cephalopods.count(Animals).ToString();
            ChordataCountLabel.Text = Chordata.count(Animals).ToString();
            CoelentrataCountLabel.Text = Coelenterata.count(Animals).ToString();
            CoralCountLabel.Text = Corals.count(Animals).ToString();
            CrustaceaCountLabel.Text = Crustaceans.count(Animals).ToString();
            EchinodermCountLabel.Text = Echinoderm.count(Animals).ToString();
            FishCountLabel.Text = Fish.count(Animals).ToString();
            InsectsCountLabel.Text = Insects.count(Animals).ToString();
            JellyfishCountLabel.Text = Jellyfish.count(Animals).ToString();
            MammalsCountLabel.Text = Mammals.count(Animals).ToString();
            ReptilesCountLabel.Text = Reptiles.count(Animals).ToString();
            SeaUrchinsCountLabel.Text = SeaUrchins.count(Animals).ToString();
            SpidersCountLabel.Text = Spiders.count(Animals).ToString();
            StarfishCountLabel.Text = Starfish.count(Animals).ToString();
            VertebratesCountLabel.Text = Vertebrates.count(Animals).ToString();
        }

        private void SortCustomControl13_Click(object sender, EventArgs e)
        {
            if(SortCustomControl13.Text == "Сортировка А-Я")
            {
                SortCustomControl13.Text = "Сортировка Я-А";
                Animals.Sort();
                Animals.GroupBy(x => x.GetType());
                ClearTree();
                FillTree();
            }
            else
            {
                SortCustomControl13.Text = "Сортировка А-Я";
                Animals.Sort();
                Animals.Reverse();
                Animals.GroupBy(x => x.GetType());
                ClearTree();
                FillTree();
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditCheckBox.Checked)
                EditCheckBox.Checked = true;
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            customControl11_Click(sender, e);
        }
    }
}
