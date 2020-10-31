using LekarClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace LekarList.Forms
{
    public partial class AddForm : Form
    {
       // List<LekarListClass> LKLIST;
      //  private BindingList <LekarListClass> ListLekar = new BindingList<LekarListClass>();
        public AddForm()
        {
            InitializeComponent();
            //dataGridView1.Rows[0].Cells[0].Value = LKLIST[0].ShowText;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            List<string> ANMG = new List<string>();
            ANMG.AddRange(new string[]
            {
                "Код A: Препараты, влияющие на пищеварительный тракт и обмен веществ",
                "Код B: Препараты, влияющие на кроветворение и кровь",
                "Код C: Препараты для лечения заболеваний сердечно-сосудистой системы",
                "Код D: Препараты для лечения заболеваний кожи",
                "Код G: Препараты для лечения заболеваний урогенитальных органов и половые гормоны"
            });
            foreach (var str in ANMG)
            {
                AnatomComboBox.Items.Add(str);
            }
           

            }

        private void TherapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> THSG_A = new List<string>();
            switch (AnatomComboBox.SelectedItem)
            {
                
                case 0:
                    
                    THSG_A.AddRange(new string[]
                    {
                        "АТХ код А01 — Стоматологические препараты",
                        "АТХ код A02 — Препараты для лечения заболеваний, связанных с нарушением кислотности",
                        "АТХ код A03 — Препараты для лечения функциональных расстройств ЖКТ",
                        "АТХ код A04 — Противорвотные препараты",
                        "АТХ код A05 — Препараты для лечения заболеваний печени и желчевыводящих путей"
                    });
                    foreach (var str in THSG_A)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    break;
                case 1:
                    THSG_A.AddRange(new string[]
                    {
                        "АТХ код B01 — Антикоагулянты",
                        "АТХ код B02 — Гемостатические препараты",
                        "АТХ код B03 — Антианемические препараты",
                        "АТХ код B05 — Плазмозамещающие и перфузионные растворы",
                        "АТХ код B06 — Прочие гематологические препараты"
                    });
                    foreach (var str in THSG_A)
                    {
                        TherapComboBox.Items.Add(str);
                    }
                    break;
                default:
                    break;
            }
        }




    }

     
}
