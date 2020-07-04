using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LekarClass;

namespace LekarList
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }
  
        private void MainWindows_Load_1(object sender, EventArgs e)
        {
            string ANMG;
            string THSG;
            string PHSG;
            string CHSG;
            string CHST;
            LekarListClass lekarList = new LekarListClass("A", "01", "A", "A", "01");
            LekarListClass lekarList2 = new LekarListClass("A", "01", "A", "B", "02");
            List<LekarListClass> LKLIST = new List<LekarListClass>();

            LKLIST.Add(lekarList);
            LKLIST.Add(lekarList2);
            treeView1.Nodes.Add(LKLIST[0].AnatomicalMainGroup);
            treeView1.Nodes[0].Nodes.Add(LKLIST[0].TherapeuticSG);
            treeView1.Nodes[0].Nodes[0].Nodes.Add(LKLIST[0].PharmacologicalSG);
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(LKLIST[0].ChemicalSG);
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[0].Nodes.Add(LKLIST[0].ChemicalSubTance);
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[0].Nodes.Add(LKLIST[1].ChemicalSubTance);


        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Получение выбранного двойным щелчком узла дерева.
            TreeNode node = treeView1.SelectedNode;

            // Вывод окна с текстом данного узла.
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }
    }
 }

