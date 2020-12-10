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
            if(AnatomComboBox.ToString()!=null)
            {
                CodeTextBox.Text = "A";
            }
            int index = MedList.Count();//пока для последнего элеммента в списке так
            AnatomGroup anatom = new AnatomGroup(AnatomComboBox.Text,CodeTextBox.Text,DescriptionBox.Text,0,index);
            MedList.Add(anatom);
            MainWindows.MedList = MedList;
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            List<string> ANMG = new List<string>();
            ANMG.AddRange(new string[]
           {
                "Препараты, влияющие на пищеварительный тракт и обмен веществ",
                "Препараты, влияющие на кроветворение и кровь",
                "Препараты для лечения заболеваний сердечно-сосудистой системы",
                "Препараты для лечения заболеваний кожи",
                "Препараты для лечения заболеваний урогенитальных органов и половые гормоны"
           });
            foreach (var str in ANMG)
            {
                AnatomComboBox.Items.Add(str);
            }
            Code.Clear();
            Code.AddRange(new string[] { "A", "B", "C", "D", "G" });
        }
       private void AnatomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> THSG_A = new List<string>();
            
            switch ((string)AnatomComboBox.SelectedItem)
            {
                case "Препараты, влияющие на пищеварительный тракт и обмен веществ":
                    TherapComboBox.Items.Clear();
                    THSG_A.AddRange(new string[]
                    {
                        "Стоматологические препараты",
                        "Препараты для лечения заболеваний, связанных с нарушением кислотности",
                        "Препараты для лечения функциональных расстройств ЖКТ",
                        "Противорвотные препараты",
                        "Препараты для лечения заболеваний печени и желчевыводящих путей"
                    });
                    CodeSG = "A01";
                    Code.Clear();
                    Code.AddRange(new string[] { "A01", "A02", "A03", "A04", "A05" });
                    foreach (var str in THSG_A)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    break;
                case "Препараты, влияющие на кроветворение и кровь":
                    TherapComboBox.Items.Clear();
                    THSG_A.AddRange(new string[]
                    {
                        "Антикоагулянты",
                        "Гемостатические препараты",
                        "Антианемические препараты",
                        "Плазмозамещающие и перфузионные растворы",
                        "Прочие гематологические препараты"
                    });
                    foreach (var str in THSG_A)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    CodeSG = "B";
                    Code.Clear();
                    Code.AddRange(new string[] { "B01", "B02", "B03", "B05", "B06" });
                    break;
                default:
                    TherapComboBox.Items.Clear();
                    break;
            }

        }
        private void TherapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> PHSG = new List<string>();
            switch ((string)TherapComboBox.SelectedItem)
            {
               case "Стоматологические препараты":
                    PharmaComboBox.Items.Clear();
                    PHSG.AddRange(new string[]
                    {
                        "Препараты для профилактики кариеса",
                        "Противомикробные препараты для местного лечения заболеваний",
                        "Глюкокортикостероиды для местного лечения заболеваний полости рта",
                        "Прочие препараты для лечения заболеваний полости рта ",
                    });
                    foreach (var str in PHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code.Clear();
                    Code.AddRange(new string[] { "A01AA", "A02AB", "A03AC", "A04AD"});
                    break;
                case "Антикоагулянты":
                    PharmaComboBox.Items.Clear();
                    PHSG.AddRange(new string[]
                    {
                        "Антагонисты витамина К",
                        "Гепарин и его производные",
                        "Ингибиторы агрегации тромбоцитов (исключая гепарин)",
                        "Ферментные препараты",
                        "Прямые ингибиторы тромбина",
                        "Прямые ингибиторы фактора Xa",
                        "Прочие антикоагулянты"
                    });
                    foreach (var str in PHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code.Clear();
                    Code.AddRange(new string[] { "B01AA", "B01AB", "B01AC", "B01AD", "B01AE","B01AF","B01AX" });
                    break;
                default:
                    PharmaComboBox.Items.Clear();
                    break;
            }
           
        }

 
    }

     
}
