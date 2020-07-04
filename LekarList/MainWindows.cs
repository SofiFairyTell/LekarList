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
            LekarListClass lekarList = new LekarListClass();
            List<LekarListClass> LKLIST = new List<LekarListClass>();
            // Пример добавления узлов дерева, объект treeView1 создан в редакторе форм
            treeView1.Nodes.Add("Parent");
            treeView1.Nodes[0].Nodes.Add("Child 1");
            treeView1.Nodes[0].Nodes.Add("Child 2");
            //textBox1.Text = 
            LKLIST.Add(lekarList);
            treeView1.Nodes.Add(LKLIST[0].ToString());

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

