using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_course
{
    public partial class AddForm : Form
    {
        const int SizeW = 260;
        const int SizeH = 20;
        List<Control> CustomControls1 = new List<Control>();
        List<Control> CustomControls2 = new List<Control>();
        NumericUpDown TentLengthUpDown;
        TextBox ColorTextBox;
        NumericUpDown FacetsNumbUpDown;
        NumericUpDown EyesNumbUpDown;
        NumericUpDown SegmentsNumbUpDown;
        TextBox PatternTextBox;
        NumericUpDown TentNumbUpDown;
        NumericUpDown RayLengthUpDown;
        TextBox StarValueTextBox;
        TextBox TailTextBox;
        NumericUpDown WingsLengthUpDown;
        TextBox ScaleTextBox;
        TextBox FurTextBox;
        TextBox CoverTextBox;

        TextBox ReproductionTextBox;
        TextBox WingsTextBox;
        NumericUpDown HeartsUpDown;
        NumericUpDown RowsCountUpDown;
        TextBox SkullTextBox;
        TextBox BreathTextBox;
        public AddForm()
        {
            InitializeComponent();
            this.ControlAdded += AddForm_ControlAdded;
        }

        private void AddForm_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is NumericUpDown)
            {
                NumericUpDown n = (NumericUpDown)e.Control;
                n.Maximum = 10000;
            }
        }

        private void AnimalTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Control c in CustomControls2)
            {
                this.Controls.Remove(c);
            }
            CustomControls2.Clear();
            switch ((string) AnimalTypeComboBox.SelectedItem) {
                case "Медуза":
                    TentLengthUpDown = new NumericUpDown();
                    TentLengthUpDown.Location = new Point(14, 344);
                    TentLengthUpDown.Size = new Size(SizeW, SizeH);
                    Label TentLengthLabel = new Label();
                    TentLengthLabel.Location = new Point(14, 328);
                    TentLengthLabel.AutoSize = true;
                    TentLengthLabel.Text = "Длина щупалец";
                    CustomControls2.Add(TentLengthUpDown);
                    CustomControls2.Add(TentLengthLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Коралл":
                    ColorTextBox = new TextBox();
                    ColorTextBox.Location = new Point(14, 344);
                    ColorTextBox.Size = new Size(SizeW, SizeH);
                    Label ColorLabel = new Label();
                    ColorLabel.Location = new Point(14, 328);
                    ColorLabel.AutoSize = true;
                    ColorLabel.Text = "Цвет";
                    CustomControls2.Add(ColorTextBox);
                    CustomControls2.Add(ColorLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Насекомое":
                    FacetsNumbUpDown = new NumericUpDown();
                    FacetsNumbUpDown.Location = new Point(14, 344);
                    FacetsNumbUpDown.Size = new Size(SizeW, SizeH);
                    Label FacetsNumbLabel = new Label();
                    FacetsNumbLabel.Location = new Point(14, 328);
                    FacetsNumbLabel.AutoSize = true;
                    FacetsNumbLabel.Text = "Количество фасеток";
                    CustomControls2.Add(FacetsNumbUpDown);
                    CustomControls2.Add(FacetsNumbLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Паукообразное":
                    EyesNumbUpDown = new NumericUpDown();
                    EyesNumbUpDown.Location = new Point(14, 344);
                    EyesNumbUpDown.Size = new Size(SizeW, SizeH);
                    Label EyesNumbLabel = new Label();
                    EyesNumbLabel.Location = new Point(14, 328);
                    EyesNumbLabel.AutoSize = true;
                    EyesNumbLabel.Text = "Количество глаз";
                    CustomControls2.Add(EyesNumbUpDown);
                    CustomControls2.Add(EyesNumbLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Ракообразное":
                    SegmentsNumbUpDown = new NumericUpDown();
                    SegmentsNumbUpDown.Location = new Point(14, 344);
                    SegmentsNumbUpDown.Size = new Size(SizeW, SizeH);
                    Label SegmentsNumbLabel = new Label();
                    SegmentsNumbLabel.Location = new Point(14, 328);
                    SegmentsNumbLabel.AutoSize = true;
                    SegmentsNumbLabel.Text = "Количество сегментов тела";
                    CustomControls2.Add(SegmentsNumbUpDown);
                    CustomControls2.Add(SegmentsNumbLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Двустворчатое":
                    PatternTextBox = new TextBox();
                    PatternTextBox.Location = new Point(14, 344);
                    PatternTextBox.Size = new Size(SizeW, SizeH);
                    Label PatternLabel = new Label();
                    PatternLabel.Location = new Point(14, 328);
                    PatternLabel.AutoSize = true;
                    PatternLabel.Text = "Узор на панцыре";
                    CustomControls2.Add(PatternTextBox);
                    CustomControls2.Add(PatternLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Головоногое":
                    TentNumbUpDown = new NumericUpDown();
                    TentNumbUpDown.Location = new Point(14, 344);
                    TentNumbUpDown.Size = new Size(SizeW, SizeH);
                    Label TentNumbLabel = new Label();
                    TentNumbLabel.Location = new Point(14, 328);
                    TentNumbLabel.AutoSize = true;
                    TentNumbLabel.Text = "Количество щупалец";
                    CustomControls2.Add(TentNumbUpDown);
                    CustomControls2.Add(TentNumbLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Морской еж":
                    RayLengthUpDown = new NumericUpDown();
                    RayLengthUpDown.Location = new Point(14, 344);
                    RayLengthUpDown.Size = new Size(SizeW, SizeH);
                    Label RayLengthLabel = new Label();
                    RayLengthLabel.Location = new Point(14, 328);
                    RayLengthLabel.AutoSize = true;
                    RayLengthLabel.Text = "Длина лучей (см)";
                    CustomControls2.Add(RayLengthUpDown);
                    CustomControls2.Add(RayLengthLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Морская звезда":
                    StarValueTextBox = new TextBox();
                    StarValueTextBox.Location = new Point(14, 344);
                    StarValueTextBox.Size = new Size(SizeW, SizeH);
                    Label StarValueLabel = new Label();
                    StarValueLabel.Location = new Point(14, 328);
                    StarValueLabel.AutoSize = true;
                    StarValueLabel.Text = "Размер звезды (см)";
                    CustomControls2.Add(StarValueTextBox);
                    CustomControls2.Add(StarValueLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Земноводное":
                    TailTextBox = new TextBox();
                    TailTextBox.Location = new Point(14, 383);
                    TailTextBox.Size = new Size(SizeW, SizeH);
                    Label TailLabel = new Label();
                    TailLabel.Location = new Point(14, 367);
                    TailLabel.AutoSize = true;
                    TailLabel.Text = "Наличие хвоста";
                    CustomControls2.Add(TailTextBox);
                    CustomControls2.Add(TailLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Птица":
                    WingsLengthUpDown = new NumericUpDown();
                    WingsLengthUpDown.Location = new Point(14, 383);
                    WingsLengthUpDown.Size = new Size(SizeW, SizeH);
                    Label WingsLengthLabel = new Label();
                    WingsLengthLabel.Location = new Point(14, 367);
                    WingsLengthLabel.AutoSize = true;
                    WingsLengthLabel.Text = "Размах крыльев (м)";
                    CustomControls2.Add(WingsLengthUpDown);
                    CustomControls2.Add(WingsLengthLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Рыба":
                    ScaleTextBox = new TextBox();
                    ScaleTextBox.Location = new Point(14, 383);
                    ScaleTextBox.Size = new Size(SizeW, SizeH);
                    Label ScaleLabel = new Label();
                    ScaleLabel.Location = new Point(14, 367);
                    ScaleLabel.AutoSize = true;
                    ScaleLabel.Text = "Тип чешуи";
                    CustomControls2.Add(ScaleTextBox);
                    CustomControls2.Add(ScaleLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Млекопитающее":
                    FurTextBox = new TextBox();
                    FurTextBox.Location = new Point(14, 383);
                    FurTextBox.Size = new Size(SizeW, SizeH);
                    Label FurLabel = new Label();
                    FurLabel.Location = new Point(14, 367);
                    FurLabel.AutoSize = true;
                    FurLabel.Text = "Тип шерсти";
                    CustomControls2.Add(FurTextBox);
                    CustomControls2.Add(FurLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Пресмыкающееся":
                    CoverTextBox = new TextBox();
                    CoverTextBox.Location = new Point(14, 383);
                    CoverTextBox.Size = new Size(SizeW, SizeH);
                    Label CoverLabel = new Label();
                    CoverLabel.Location = new Point(14, 367);
                    CoverLabel.AutoSize = true;
                    CoverLabel.Text = "Тип покрова";
                    CustomControls2.Add(CoverTextBox);
                    CustomControls2.Add(CoverLabel);
                    foreach (Control c in CustomControls2)
                    {
                        this.Controls.Add(c);
                    }
                    break;
            }
        }

        private void AnimalKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in CustomControls1)
            {
                this.Controls.Remove(c);
            }
            CustomControls1.Clear();
            foreach (Control c in CustomControls2)
            {
                this.Controls.Remove(c);
            }
            CustomControls2.Clear();
            switch ((string)AnimalKindComboBox.SelectedItem)
            {
                case "Кишечнополостное":
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Медуза");
                    AnimalTypeComboBox.Items.Add("Коралл");
                    ReproductionTextBox = new TextBox();
                    ReproductionTextBox.Location = new Point(14, 306);
                    ReproductionTextBox.Size = new Size(SizeW, SizeH);
                    Label ReproductionLabel = new Label();
                    ReproductionLabel.Location = new Point(14, 289);
                    ReproductionLabel.AutoSize = true;
                    ReproductionLabel.Text = "Тип размножения";
                    CustomControls1.Add(ReproductionTextBox);
                    CustomControls1.Add(ReproductionLabel);
                    foreach(Control c in CustomControls1)
                    {
                        this.Controls.Add (c);
                    }
                    break;
                case "Членистоногое":
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Насекомое");
                    AnimalTypeComboBox.Items.Add("Паукообразное");
                    AnimalTypeComboBox.Items.Add("Ракообразное");
                    WingsTextBox = new TextBox();
                    WingsTextBox.Location = new Point(14, 306);
                    WingsTextBox.Size = new Size(SizeW, SizeH);
                    Label WingsLabel = new Label();
                    WingsLabel.Location = new Point(14, 289);
                    WingsLabel.AutoSize = true;
                    WingsLabel.Text = "Наличие крыльев";
                    CustomControls1.Add(WingsLabel);
                    CustomControls1.Add(WingsTextBox);
                    foreach (Control c in CustomControls1)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Моллюск":
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Двустворчатое");
                    AnimalTypeComboBox.Items.Add("Головоногое");
                    HeartsUpDown = new NumericUpDown();
                    HeartsUpDown.Location = new Point(14, 306);
                    HeartsUpDown.Size = new Size(SizeW, SizeH);
                    Label HeartsLabel = new Label();
                    HeartsLabel.Location = new Point(14, 289);
                    HeartsLabel.AutoSize = true;
                    HeartsLabel.Text = "Количество предсердий";
                    CustomControls1.Add(HeartsUpDown);
                    CustomControls1.Add(HeartsLabel);
                    foreach (Control c in CustomControls1)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Иглокожое":
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Морской еж");
                    AnimalTypeComboBox.Items.Add("Морская звезда");
                    RowsCountUpDown = new NumericUpDown();
                    RowsCountUpDown.Location = new Point(14, 306);
                    RowsCountUpDown.Size = new Size(SizeW, SizeH);
                    Label RowsLabel = new Label();
                    RowsLabel.Location = new Point(14, 289);
                    RowsLabel.AutoSize = true;
                    RowsLabel.Text = "Количество лучей";
                    CustomControls1.Add(RowsCountUpDown);
                    CustomControls1.Add(RowsLabel);
                    foreach (Control c in CustomControls1)
                    {
                        this.Controls.Add(c);
                    }
                    break;
                case "Хордовое":
                    AnimalTypeComboBox.Items.Clear();
                    AnimalTypeComboBox.Items.Add("Земноводное");
                    AnimalTypeComboBox.Items.Add("Птица");
                    AnimalTypeComboBox.Items.Add("Рыба");
                    AnimalTypeComboBox.Items.Add("Млекопитающее");
                    AnimalTypeComboBox.Items.Add("Пресмыкающееся");
                    SkullTextBox = new TextBox();
                    SkullTextBox.Location = new Point(14, 306);
                    SkullTextBox.Size = new Size(SizeW, SizeH);
                    Label SkullLabel = new Label();
                    SkullLabel.Location = new Point(14, 289);
                    SkullLabel.AutoSize = true;
                    SkullLabel.Text = "Наличие крыльев";
                    BreathTextBox = new TextBox();
                    BreathTextBox.Location = new Point(14, 344);
                    BreathTextBox.Size = new Size(SizeW, SizeH);
                    Label BreathLabel = new Label();
                    BreathLabel.Location = new Point(14, 328);
                    BreathLabel.AutoSize = true;
                    BreathLabel.Text = "Органы дыхания";
                    CustomControls1.Add(SkullTextBox);
                    CustomControls1.Add(SkullLabel);
                    CustomControls1.Add(BreathTextBox);
                    CustomControls1.Add(BreathLabel);
                    foreach (Control c in CustomControls1)
                    {
                        this.Controls.Add(c);
                    }
                    break;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnimalTypeComboBox.SelectedItem == null)
                {
                    throw new Exception("Не выбран вид животного!");
                }
                if (Form1.Animals.Exists(x => x.Name == NameTextBox.Text))
                    throw new Exception("Животное с таким именем уже существует!");
                if(String.IsNullOrWhiteSpace(this.NameTextBox.Text) || String.IsNullOrEmpty(this.NameTextBox.Text))
                {
                    throw new Exception("Вы не ввели название животного!");
                }
                switch ((string)AnimalTypeComboBox.SelectedItem)
                {
                    case "Медуза":
                        Jellyfish jellyfish = new Jellyfish(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.ReproductionTextBox.Text, (double)this.TentLengthUpDown.Value);
                        Form1.Animals.Add(jellyfish);
                        break;
                    case "Коралл":
                        Corals corals = new Corals(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.ReproductionTextBox.Text, this.ColorTextBox.Text);
                        Form1.Animals.Add(corals);
                        break;
                    case "Насекомое":
                        Insects insects = new Insects(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.WingsTextBox.Text, (double)this.FacetsNumbUpDown.Value);
                        Form1.Animals.Add(insects);
                        break;
                    case "Паукообразное":
                        Spiders spiders = new Spiders(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.WingsTextBox.Text, (double)this.EyesNumbUpDown.Value);
                        Form1.Animals.Add(spiders);
                        break;
                    case "Ракообразное":
                        Crustaceans crustaceans = new Crustaceans(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.WingsTextBox.Text, (double)this.SegmentsNumbUpDown.Value);
                        Form1.Animals.Add(crustaceans);
                        break;
                    case "Двустворчатое":
                        Bivalvias bivalvias = new Bivalvias(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, (int)this.HeartsUpDown.Value, this.PatternTextBox.Text);
                        Form1.Animals.Add(bivalvias);
                        break;
                    case "Головоногое":
                        Cephalopods cephalopods = new Cephalopods(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, (int)this.HeartsUpDown.Value, (int)this.TentNumbUpDown.Value);
                        Form1.Animals.Add(cephalopods);
                        break;
                    case "Морской еж":
                        SeaUrchins seaurchins = new SeaUrchins(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, (int)this.RowsCountUpDown.Value, (int)this.RayLengthUpDown.Value);
                        Form1.Animals.Add(seaurchins);
                        break;
                    case "Морская звезда":
                        Starfish starfish = new Starfish(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, (int)this.RowsCountUpDown.Value, this.StarValueTextBox.Text);
                        Form1.Animals.Add(starfish);
                        break;
                    case "Земноводное":
                        Amphibians amphibians = new Amphibians(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.SkullTextBox.Text, this.BreathTextBox.Text, this.TailTextBox.Text);
                        Form1.Animals.Add(amphibians);
                        break;
                    case "Птица":
                        Birds birds = new Birds(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.SkullTextBox.Text, this.BreathTextBox.Text, (double)this.WingsLengthUpDown.Value);
                        Form1.Animals.Add(birds);
                        break;
                    case "Рыба":
                        Fish fish = new Fish(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.SkullTextBox.Text, this.BreathTextBox.Text, this.ScaleTextBox.Text);
                        Form1.Animals.Add(fish);
                        break;
                    case "Млекопитающее":
                        Mammals mammals = new Mammals(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.SkullTextBox.Text, this.BreathTextBox.Text, this.FurTextBox.Text);
                        Form1.Animals.Add(mammals);
                        break;
                    case "Пресмыкающееся":
                        Reptiles reptiles = new Reptiles(NameTextBox.Text, LatNameTextBox.Text, (int)LifeTimeUpDown.Value, (int)PregnancyUpDown.Value, (int)ProgenyUpDown.Value, this.SkullTextBox.Text, this.BreathTextBox.Text, this.CoverTextBox.Text);
                        Form1.Animals.Add(reptiles);
                        break;
                    //default:
                        //throw new NotSelectedException("Не выбран вид животного!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelAdButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
