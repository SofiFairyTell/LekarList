using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            
            LekarListClass lekarList0 = new LekarListClass("A", 0, 0);
            LekarListClass lekarList1 = new LekarListClass("A", "01", 1,1);
            LekarListClass lekarList2 = new LekarListClass("A", "01", "A", 2, 2);
            LekarListClass lekarList3 = new LekarListClass("A", "01", "A","A", 3, 3);
            LekarListClass lekarList4 = new LekarListClass("A", "01", "A", "A","01", 4, 4);
            LekarListClass lekarList4a = new LekarListClass("A", "01", "A", "A", "02", 4, 5);

            LekarListClass lekarListB0 = new LekarListClass("B", 0, 6);
            LekarListClass lekarListB1 = new LekarListClass("B", "01", 1, 7);
            LekarListClass lekarListB2 = new LekarListClass("B", "01", "A", 2, 8);
            LKLIST = new List<LekarListClass>();

            LKLIST.Add(lekarList0);
            LKLIST.Add(lekarList1);
            LKLIST.Add(lekarList2);
            LKLIST.Add(lekarList3);
            LKLIST.Add(lekarList4);
            LKLIST.Add(lekarList4a);
        
            LKLIST.Add(lekarListB0);
            LKLIST.Add(lekarListB1);
            LKLIST.Add(lekarListB2);

            ParentNodes();

        }
        #region TREENODE

        public void ParentNodes()
        {
            int i;
           
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            for (i=0;i<LKLIST.Count();i++)
            {
                if (LKLIST[i].Level == 0)
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
        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string line;
            string ANMG;
            string THSG;
            string PHSG;
            string CHSG;
            string CHST;
            LKLIST = new List<LekarListClass>();
            for (int i = 0; i < LBdata.Items.Count; i++)
            {
                line = LBdata.Items[i].ToString();

                Regex regex = new Regex("(^[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}[0-9]{2}$)");
                Match match = regex.Match(line);
             if (match.Success)
                {
                    ANMG = line.Substring(0, 1);
                    //THSG = line.Substring(1, 2);
                    LekarListClass result = LKLIST.Find(x => x.ShowText.Contains(ANMG));
                    if (result == null)
                    {
                        LKLIST.Add(new LekarListClass(ANMG, 0, i));
                        //LKLIST.Add(new LekarListClass(ANMG, THSG, 1, i));
                    }

                    //LKLIST.Add(new LekarListClass(ANMG, 0, i));
                    // LKLIST.Add(new LekarListClass(ANMG, THSG, 1, i));
                }
             else
                {
                    ANMG = "ОШИБКА";
                    
                    LKLIST.Add(new LekarListClass(ANMG, 0, i));
                }


                
                //    
                //while (match.Success)
                //{
                //    ANMG = line.Substring(0, 1);
                //    LKLIST.Add(new LekarListClass(ANMG, 0, i));
                //    match = match.NextMatch();
                //}
                //if (line.Substring(0,1) == " ")
                //{
                //    MessageBox.Show("!");
                //}
                //else
                //{
                //    ANMG = line.Substring(0, 1);
                //    LKLIST.Add(new LekarListClass(ANMG, 0, i));
                //}
                //LKLIST.Add(new LekarListClass());
            }
            ParentNodes();
        }
    }
 }

