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

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка на форме 'Добавить'!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            //ANMG.AddRange(new string[]
            //{
            //    "Препараты, влияющие на пищеварительный тракт и обмен веществ",
            //    "Препараты, влияющие на кроветворение и кровь",
            //    "Препараты для лечения заболеваний сердечно-сосудистой системы",
            //    "Препараты для лечения заболеваний кожи",
            //    "Препараты для лечения заболеваний урогенитальных органов и половые гормоны"
            //});
            foreach (var str in ANMG)
            {
                AnatomComboBox.Items.Add(str);
            }

            //  string str2 = "";

            //while (alimentary.Return() != "")
            //{
            //    string str3 = alimentary.Return(str2);
            //    AnatomComboBox.Items.Add(str3);
            //}

            Code_ANMG.Clear();
            Code_ANMG.AddRange(new string[] { "A", "B", "C", "D", "G" });



        }
       private void AnatomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)AnatomComboBox.SelectedItem)
            {
                case "Препараты, влияющие на пищеварительный тракт и обмен веществ":
                    /*Был выбран пункт. Сформируем список для следующего поля*/
                    THSG.Clear();
                    TherapComboBox.Items.Clear();
                    THSG.AddRange(new string[]
                    {
                        "Стоматологические препараты",
                        "Препараты для лечения заболеваний, связанных с нарушением кислотности",
                        "Препараты для лечения функциональных расстройств ЖКТ",
                        "Противорвотные препараты",
                        "Препараты для лечения заболеваний печени и желчевыводящих путей"
                    });

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
                    THSG.AddRange(new string[]
                    {
                        "Антикоагулянты",
                        "Гемостатические препараты",
                        "Антианемические препараты",
                        "Плазмозамещающие и перфузионные растворы",
                        "Прочие гематологические препараты"
                    });
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
                    THSG.AddRange(new string[]
                    {
                        " ",
                        " ",
                        " ",
                        " ",
                        " "
                    });

                    Code_THSG.Clear();
                    Code_THSG.AddRange(new string[] { "A01", "A02", "A03", "A04", "A05" });
                    foreach (var str in THSG)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    break;
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
                    Code_PHSG.Clear();
                    Code_PHSG.AddRange(new string[] { "A01AA", "A02AB", "A03AC", "A04AD"});
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
            switch ((string)PharmaComboBox.SelectedItem)
            {
                case "Препараты для профилактики кариеса":
                    ChemComboBox.Items.Clear();
                    CHSG.AddRange(new string[]
                    {
                        "Фторид натрия",
                        "Натрия монофторфосфат",
                        "Олафур",
                        "Фторид олова",
                        "Комбинации",
                        "Комбинации фторида натрия"                   
                    });
                    foreach (var str in CHSG)
                    {
                        PharmaComboBox.Items.Add(str);
                    }
                    Code_CHSG.Clear();
                    Code_CHSG.AddRange(new string[] { "A01AA01", "A01AA02", "A01AA03", "A01AA04", "A01AA30", "A01AA51" });
                    break;
                case "Противомикробные препараты для местного лечения заболеваний":
                    ChemComboBox.Items.Clear();
                    CHSG.AddRange(new string[]
                    {
                        "Пероксид водорода",
                         "Хлоргексидин",
                         "Амфотерицин",
                         "Полиноксилин",
                         "Домифена бромид",
                         "Оксихинолин",
                        "Неомицин",
                        "Миконазол"
                    });
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
                if ((string)TherapComboBox.SelectedItem == PHSG[i])
                {
                    CodeTextBox.Text = Code_PHSG[i];
                }
            }
        }


   private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = DialogResult.Cancel;

        }

        private void ChemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Динамически меняем отображаемый код анатомической группы*/
            for (int i = 0; i < CHSG.Count; i++)
            {
                if ((string)TherapComboBox.SelectedItem == CHSG[i])
                {
                    CodeTextBox.Text = Code_CHSG[i];
                }
            }
        }
    }

     
}
