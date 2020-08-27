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
using System.Xml;

namespace LekarList
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
            LoadXML();
        }
        List<LekarListClass> LKLIST;
        public string ErrorMess = "Нельзя изменять главный уровень!";
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
                LKLIST[i].Child++;
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
            DataDescriptionGrid.Rows.Clear();
            DataDescriptionGrid.Columns.Clear();
            DataGridInit();
            DataDescriptionGrid.ReadOnly = true;
            DataDescriptionGrid.Visible = true;
            AddButton.BringToFront();
            MinimButton.Visible = true;
            //AddButton.Location = new Point(AddButton.Location.X - 137, AddButton.Location.Y+ 224);
            //EditButton.Location = new Point(EditButton.Location.X,EditButton.Location.Y + 156);
            //DelButton.Location = new Point(DelButton.Location.X +139 ,DelButton.Location.Y + 52);
            //MinimButton.Location = new Point(EditButton.Location.X, DelButton.Location.Y + 80);

            var index = LKLIST.FindIndex(x => x.ShowText.Contains(node.Text));
            DataDescriptionGrid.Rows[0].Cells[1].Value = LKLIST[index].ShowText;
            DataDescriptionGrid.Rows[1].Cells[1].Value = LKLIST[index].Index; //индекс это номер элемента в списке
            

           // AddButton.Location = new Point(AddButton.Location.X - 199 , AddButton.Location.Y);
        }
        #endregion

        #region DataGrids
        private void DataGridInit()
        {
            DataGridViewCellStyle columnstyle = new DataGridViewCellStyle();
            columnstyle.BackColor = Color.Chocolate;
            columnstyle.Font = new Font("Arial", 11, FontStyle.Regular);
            DataDescriptionGrid.Columns.Add("GroupNameColumn", "");
            DataDescriptionGrid.Columns.Add("DescripColumn", "");
            DataDescriptionGrid.Rows.Add(5);
            DataDescriptionGrid.Rows[0].Cells[0].Value = "Код";
            DataDescriptionGrid.Rows[1].Cells[0].Value = "Группа";
            DataDescriptionGrid.Rows[2].Cells[0].Value = "Название";
            DataDescriptionGrid.Rows[3].Cells[0].Value = "Латинское название";
            DataDescriptionGrid.Rows[4].Cells[0].Value = "Препараты группы";
            DataDescriptionGrid.AllowUserToAddRows = false;
            DataDescriptionGrid.Columns[0].ReadOnly = true;
        }
        private void DataDescriptionGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LButton && DataDescriptionGrid.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = DataDescriptionGrid.Rows[0].Cells[1];
                DataDescriptionGrid.CurrentCell = cell;
                DataDescriptionGrid.BeginEdit(true);
                DataDescriptionGrid.EditMode = DataGridViewEditMode.EditOnEnter;               
            }

        }

        private void DataDescriptionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = LKLIST.FindIndex(x => x.ShowText.Contains(DataDescriptionGrid.Rows[0].Cells[1].Value.ToString()));
            if (e.ColumnIndex == 1)
            {
                DataDescriptionGrid.BeginEdit(true);
                DataDescriptionGrid.ReadOnly = false;
            }
            else
            {
                DataDescriptionGrid.ReadOnly = true;
                //DataDescriptionGrid.EndEdit();
                //if (flag)
                //{
                //     LKLIST[index].ShowText = DataDescriptionGrid.Rows[0].Cells[1].Value.ToString();
                //    ParentNodes();
                //}
                
               
            }
        }

        #endregion

        #region Кнопки
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            int level;
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
                LekarListClass result;
                Regex regex = new Regex("(^[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}[0-9]{2}$)");
                Match match = regex.Match(line);
                if (match.Success)
                {

                    switch (line.Length)
                    {
                        case 1:
                            level = 0;
                            ANMG = line.Substring(0, 1);
                            result = LKLIST.Find(x => x.ShowText.Contains(ANMG));
                            if (result == null)
                            {

                                LKLIST.Add(new LekarListClass(ANMG, level, i));
                            }

                            break;
                        case 3:
                            level = 1;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            result = LKLIST.Find(x => x.ShowText.Contains(ANMG + THSG));
                            if (result == null)
                            {
                                LKLIST.Add(new LekarListClass(ANMG, THSG, level, i));
                            }

                            break;
                        case 4:
                            level = 2;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            PHSG = line.Substring(3, 1);
                            result = LKLIST.Find(x => x.ShowText.Contains(ANMG + THSG + PHSG));
                            if (result == null)
                            {
                                LKLIST.Add(new LekarListClass(ANMG, THSG, PHSG, level, i));
                            }

                            break;
                        case 5:
                            level = 3;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            PHSG = line.Substring(3, 1);
                            CHSG = line.Substring(4, 1);
                            result = LKLIST.Find(x => x.ShowText.Contains(ANMG + THSG + PHSG + CHSG));
                            if (result == null)
                            {
                                LKLIST.Add(new LekarListClass(ANMG, THSG, PHSG, CHSG, level, i));
                            }
                            break;
                        case 7:
                            level = 4;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            PHSG = line.Substring(3, 1);
                            CHSG = line.Substring(4, 1);
                            CHST = line.Substring(5, 2);
                            result = LKLIST.Find(x => x.ShowText.Contains(ANMG + THSG + PHSG + CHSG + CHST));
                            if (result == null)
                            {
                                LKLIST.Add(new LekarListClass(ANMG, THSG, PHSG, CHSG, CHST, level, i));
                            }
                            break;
                    }
                }
                else
                {
                    ANMG = "ОШИБКА";
                    LKLIST.Add(new LekarListClass(ANMG, 0, i));
                }
            }
            ParentNodes();
            Forms.AddForm NewForm = new Forms.AddForm();
            NewForm.Show();
        }

        
        private void SortButton_Click(object sender, EventArgs e)
        {
            LBdata.Sorted = true;
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LBdata.Visible = true;
            SortButton.Visible = true;
            AddButton.Visible = true;
        }
        private bool flag;
        private void EditButton_Click(object sender, EventArgs e)
        {
            //flag = true;

            if (DataDescriptionGrid.Rows[1].Cells[1].Value.ToString() == " ")
            {

                MessageBox.Show(ErrorMess);
            }
            else
            {
                var index = LKLIST.FindIndex(x => x.Index.Equals(DataDescriptionGrid.Rows[1].Cells[1].Value));
                LKLIST[index].ShowText = DataDescriptionGrid.Rows[0].Cells[1].Value.ToString();
                //LKLIST.Sort();
                ParentNodes();
            }


        }
        private void MinimButton_Click(object sender, EventArgs e)
                {
                    MinimButton.Visible = false;
                    DataDescriptionGrid.Rows.Clear();
                    AddButton.BringToFront();
                    
                    //AddButton.Location = new Point(AddButton.Location.X + 137, AddButton.Location.Y - 224);
                    //EditButton.Location = new Point(EditButton.Location.X, EditButton.Location.Y - 156);
                    //DelButton.Location = new Point(DelButton.Location.X - 139, DelButton.Location.Y - 52);
                    // MinimButton.Location = new Point(EditButton.Location.X, DelButton.Location.Y + 80);
                    //MinimButton.Location = new Point(485, 310);
                }

            private void DelButton_Click(object sender, EventArgs e)
                    {
            var index = LKLIST.FindIndex(x => x.Index.Equals(DataDescriptionGrid.Rows[1].Cells[1].Value));
            if (LKLIST[index].Child >0)
            {
                MessageBox.Show("Нельзя удалять корни!");
            }
            else
            {
                LKLIST.RemoveAt(index);
            }
            
            //LKLIST.Sort();
            ParentNodes();
        }



        #endregion

        private void LoadXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Kurbatova\\source\\repos\\LekarList\\LekarList\\lekar.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string AnatomicalMainGroup = node.Attributes[0].Value;
                int level = int.Parse(node["Level"].InnerText);
                int index = int.Parse(node["Index"].InnerText);
                listBox1.Items.Add(new LekarListClass(AnatomicalMainGroup, level, index));
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex !=-1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LKLIST.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Kurbatova\\source\\repos\\LekarList\\LekarList\\lekar.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string AnatomicalMainGroup = node.Attributes[0].Value;
                int level = int.Parse(node["Level"].InnerText);
                int index = int.Parse(node["Index"].InnerText);
                LKLIST.Add(new LekarListClass(AnatomicalMainGroup, level, index));
            }
            ParentNodes();
        }
    }
 }

