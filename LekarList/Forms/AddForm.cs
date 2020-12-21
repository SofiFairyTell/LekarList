using LekarClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LekarList.LekarClass;
using System.Windows.Forms;

namespace LekarList.Forms
{
    public partial class AddForm : Form
    {
        string CodeSG;
        List<string> Code = new List<string>();
        public List<Medication>  MedList = new List<Medication>();
        // List<LekarListClass> LKLIST;
        //  private BindingList <LekarListClass> ListLekar = new BindingList<LekarListClass>();
        public AddForm()
        {
            InitializeComponent();
            //dataGridView1.Rows[0].Cells[0].Value = LKLIST[0].ShowText;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnatomComboBox.ToString()!= null && TherapComboBox.ToString()!=null && PharmaComboBox.ToString()!=null && ChemComboBox.ToString()!=null)
                {
                    int index = MedList.Count();//пока для последнего элеммента в списке так
                    AnatomGroup anatom = new AnatomGroup(AnatomComboBox.Text,CodeTextBox.Text,DescriptionBox.Text,0,index);
                    TherapGroup therap = new TherapGroup(TherapComboBox.Text, CodeTextBox.Text, DescriptionBox.Text, 1, index + 1);
                    PharmaGroup pharma = new PharmaGroup(PharmaComboBox.Text, CodeTextBox.Text, DescriptionBox.Text, 2, index + 1);
                    ChemGroup chem = new ChemGroup(ChemComboBox.Text, CodeTextBox.Text, DescriptionBox.Text, 3, index + 1);

                    MedList.Add(anatom);
                    MedList.Add(therap);
                    MedList.Add(pharma);
                    MedList.Add(chem);
            
                    MainWindows.MedList = MedList;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка на форме 'Добавить'!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //if(AnatomComboBox.ToString()!=null)
            //{
            //    CodeTextBox.Text = "A";
            //}
           
        }

        /*---------Списки групп--------------*/
        List<string> ANMG = new List<string>();
        List<string> THSG = new List<string>();
        List<string> PHSG = new List<string>();
        List<string> CHSG = new List<string>();

        /*------------Коды групп--------------*/
        List<string> Code_ANMG = new List<string>();
        List<string> Code_THSG = new List<string>();
        List<string> Code_PHSG = new List<string>();
        List<string> Code_CHSG = new List<string>();

        private void AddForm_Load(object sender, EventArgs e)
        {
            AlimentaryClass alimentary = new AlimentaryClass();
            ANMG = alimentary.Return();
            foreach (var str in ANMG)
            {
                AnatomComboBox.Items.Add(str);
            }
            Code_ANMG.Clear();
            Code_ANMG.AddRange(new string[] { "A", "B", "C", "D", "G" });
        }
       private void AnatomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreparationsClass preparations = new PreparationsClass();

            switch ((string)AnatomComboBox.SelectedItem)
            {
                case "Препараты, влияющие на пищеварительный тракт и обмен веществ":
                    /*Был выбран пункт. Сформируем список для следующего поля*/
                    THSG.Clear();
                    TherapComboBox.Items.Clear();
                    THSG = preparations.Return("Препараты, влияющие на пищеварительный тракт и обмен веществ");
                    Code_THSG.Clear();
                    Code_THSG.AddRange(new string[] { "A01", "A02", "A03", "A04", "A05" });
                        foreach (var str in THSG)
                        {
                            TherapComboBox.Items.Add(str);
                        }
                    break;
                case "Препараты, влияющие на кроветворение и кровь":
                    THSG.Clear();
                    TherapComboBox.Items.Clear();
                    THSG = preparations.Return("Препараты, влияющие на кроветворение и кровь");
                    foreach (var str in THSG)
                    {
                        TherapComboBox.Items.Add(str);
                    }

                    /*Сформируем коды для следуюшего списка*/
                    Code_THSG.Clear();
                    Code_THSG.AddRange(new string[] { "B01", "B02", "B03", "B05", "B06" });

                    break;
                case "Препараты для лечения заболеваний сердечно-сосудистой системы":
                    /*Был выбран пункт. Сформируем список для следующего поля*/
                    THSG.Clear();
                    TherapComboBox.Items.Clear();
                    THSG = preparations.Return("Препараты для лечения заболеваний сердечно-сосудистой системы");
                    Code_THSG.Clear();
                    Code_THSG.AddRange(new string[] { "C01", "C02", "C03", "C04", "C05" });
                    foreach (var str in THSG)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    break;
                default:
                    TherapComboBox.Items.Clear();
                    break;
            }

            /*Динамически меняем отображаемый код анатомической группы*/
            for (int i = 0; i < ANMG.Count; i++)
            {
                if ((string)AnatomComboBox.SelectedItem == ANMG[i])
                {
                    CodeTextBox.Text = Code_ANMG[i];
                }
            }
        }
        private void TherapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PharmaPreparat pharma = new PharmaPreparat();
            switch ((string)TherapComboBox.SelectedItem)
            {
               case "Стоматологические препараты":
                    PharmaComboBox.Items.Clear();
                    PHSG = pharma.Return("Стоматологические препараты");
                    foreach (var str in PHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code_PHSG.Clear();
                    Code_PHSG.AddRange(new string[] { "A01AA", "A02AB", "A03AC", "A04AD"});
                   break;
                case "Антикоагулянты":
                    PharmaComboBox.Items.Clear();
                    PHSG = pharma.Return("Антикоагулянты");
                    foreach (var str in PHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code_PHSG.Clear();
                    Code_PHSG.AddRange(new string[] { "B01AA", "B01AB", "B01AC", "B01AD", "B01AE","B01AF","B01AX" });
                    break;
                default:
                    PharmaComboBox.Items.Clear();
                    break;
            }
            /*Динамически меняем отображаемый код анатомической группы*/
            for (int i = 0; i < THSG.Count; i++)
            {
                if ((string)TherapComboBox.SelectedItem == THSG[i])
                {
                    CodeTextBox.Text = Code_THSG[i];
                }
            }
        }

        

        private void PharmaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChemClass chem = new ChemClass();
            switch ((string)PharmaComboBox.SelectedItem)
            {
                case "Препараты для профилактики кариеса":
                    ChemComboBox.Items.Clear();
                    CHSG = chem.Return("Препараты для профилактики кариеса");
                    foreach (var str in CHSG)
                    {
                        ChemComboBox.Items.Add(str);
                    }
                    Code_CHSG.Clear();
                    Code_CHSG.AddRange(new string[] { "A01AA01", "A01AA02", "A01AA03", "A01AA04", "A01AA30", "A01AA51" });
                    break;
                case "Противомикробные препараты для местного лечения заболеваний":
                    ChemComboBox.Items.Clear();
                    CHSG = chem.Return("Противомикробные препараты для местного лечения заболеваний");
                    foreach (var str in CHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code_CHSG.Clear();
                    Code_CHSG.AddRange(new string[] { "A01AB02", "A01AB03", "A01AB04", "A01AB05", "A01AB06", "A01AB07", "A01AB08", "A01AB09" });
                    break;
                default:
                    PharmaComboBox.Items.Clear();
                    break;
            }
            /*Динамически меняем отображаемый код анатомической группы*/
            for (int i = 0; i < PHSG.Count; i++)
            {
                if ((string)PharmaComboBox.SelectedItem == PHSG[i])
                {
                    CodeTextBox.Text = Code_PHSG[i];
                }
            }
        }
        private void ChemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Динамически меняем отображаемый код анатомической группы*/
            for (int i = 0; i < CHSG.Count; i++)
            {
                if ((string)ChemComboBox.SelectedItem == CHSG[i])
                {
                    CodeTextBox.Text = Code_CHSG[i];
                }
            }
        }

   private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = DialogResult.Cancel;

        }


    }

     
}
