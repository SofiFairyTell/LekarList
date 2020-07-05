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
        List<LekarListClass> LKLIST;
        private void MainWindows_Load_1(object sender, EventArgs e)
        {
            string ANMG;
            string THSG;
            string PHSG;
            string CHSG;
            string CHST;
            LekarListClass lekarList0 = new LekarListClass("A", 0,0);
            LekarListClass lekarList1 = new LekarListClass("A", "01", 1,1);
            LekarListClass lekarList2 = new LekarListClass("A", "01", "A", 2,2);
            LekarListClass lekarListB0 = new LekarListClass("B", 0,3);
            LekarListClass lekarListB1 = new LekarListClass("B", "01", 1,4);
            LekarListClass lekarListB2 = new LekarListClass("B", "01", "A", 2,5);
            LKLIST = new List<LekarListClass>();

            LKLIST.Add(lekarList0);
            LKLIST.Add(lekarList1);
            LKLIST.Add(lekarList2);
            LKLIST.Add(lekarListB0);
            LKLIST.Add(lekarListB1);
            LKLIST.Add(lekarListB2);

            ParentNodes();

        }
        public void ParentNodes()
        {
            int i;
           
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            for (i=0;i<LKLIST.Count();i++)
            {
                if (LKLIST[i].Level ==0)
                {
                    treeView1.Nodes.Add(LKLIST[i].ShowText,LKLIST[i].ShowText);
                    treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = LKLIST[i];
                }
            }
            for(i=0;i<treeView1.Nodes.Count;i++)
            {
                ChildNodes(treeView1.Nodes[i]);
            }
            treeView1.EndUpdate();
            treeView1.Refresh();
        }

        private void ChildNodes(TreeNode treeNode)
        {
            LekarListClass parentRed = (LekarListClass)treeNode.Tag;
            for (int i = parentRed.Index+1;i<LKLIST.Count;i++)
            {
                if(LKLIST[i].Level == (parentRed.Level+1))
                {
                    treeNode.Nodes.Add(LKLIST[i].ShowText, LKLIST[i].ShowText);
                    treeNode.Nodes[treeNode.Nodes.Count - 1].Tag = LKLIST[i];
                    ChildNodes(treeNode.Nodes[treeNode.Nodes.Count - 1]);
                }
                if (LKLIST[i].Level <= treeNode.Level) break;
            }

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

