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
using LekarList.LekarClass;
using System.Xml;

namespace LekarList
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();

        }

        /*новые классы для иерархии*/
        public static List<Medication> MedList = new List<Medication>();
        public static void ParentNodesMed();
        public string ErrorMess = "Нельзя изменять главный уровень!";

        private void MainWindows_Load_1(object sender, EventArgs e)
        {
            /*Тестовые данные для списка*/
            AnatomGroup anatom1 = new AnatomGroup("Препараты, влияющие на пищеварительный тракт и обмен веществ","A",0, 0);
            TherapGroup therap1 = new TherapGroup("Стоматологические препараты", "A01", 1, 1);
            PharmaGroup pharma1 = new PharmaGroup("Препараты для профилактики кариеса", "A01A", 2, 2);
            //ChemGroup chem1 = new ChemGroup("A", "01", "A", "A", 3, 3);

            AnatomGroup anatom2 = new AnatomGroup("Препараты, влияющие на кроветворение и кровь","B",0, 3);
            TherapGroup therap2 = new TherapGroup("Антикоагулянты", "B01", 1, 4);
           // PharmaGroup pharma2 = new PharmaGroup("B", "01", "A", 2, 8);

            MedList.Add(anatom1);
            MedList.Add(therap1);
            MedList.Add(anatom2);
            MedList.Add(therap2);

            ParentNodesMed();
        }
        #region TREENODE

        public static void ParentNodesMed()
        {
            int i;

            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            for (i = 0; i < MedList.Count(); i++)
            {
                if (MedList[i].Level == 0)
                {
                    treeView1.Nodes.Add(MedList[i].MedicName, MedList[i].MedicName);
                    treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = MedList[i];
                }
            }
            for (i = 0; i < treeView1.Nodes.Count; i++)
            {
                ChildNodesMed(treeView1.Nodes[i]);
                MedList[i].Child++;
            }
            treeView1.EndUpdate();
            treeView1.Refresh();
        }
        private void ChildNodesMed(TreeNode treeNode)
        {
            Medication parentRed = (Medication)treeNode.Tag;
            for (int i = parentRed.Index + 1; i < MedList.Count; i++)
            {
                if (MedList[i].Level == (parentRed.Level + 1))
                {
                    treeNode.Nodes.Add(MedList[i].MedicName, MedList[i].MedicName);
                    treeNode.Nodes[treeNode.Nodes.Count - 1].Tag = MedList[i];
                    ChildNodesMed(treeNode.Nodes[treeNode.Nodes.Count - 1]);
                }
                if (MedList[i].Level <= treeNode.Level) break;
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
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

            var index = MedList.FindIndex(x => x.MedicName.Contains(node.Text));
            DataDescriptionGrid.Rows[0].Cells[1].Value = MedList[index].MedicName;
            DataDescriptionGrid.Rows[1].Cells[1].Value = MedList[index].Index; //индекс это номер элемента в списке
            DataDescriptionGrid.Rows[2].Cells[1].Value = MedList[index].Child; //индекс это номер элемента в списке
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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
            var index = MedList.FindIndex(x => x.MedicName.Contains(DataDescriptionGrid.Rows[0].Cells[1].Value.ToString()));
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
            /*
            int level;
            string CodeSG;
            string line;
            string ANMG;
            string THSG;
            string PHSG;
            string CHSG;
            string CHST;

            MedList = new List<Medication>();
            for (int i = 0; i < LBdata.Items.Count; i++)
            {
                line = LBdata.Items[i].ToString();
                Medication result;
                Regex regex = new Regex("(^[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}$)|(^[A-Z]{1}[0-9]{2}[A-Z]{1}[A-Z]{1}[0-9]{2}$)");
                Match match = regex.Match(line);
                if (match.Success)
                {

                    switch (line.Length)
                    {
                        case 1:
                            level = 0;
                            ANMG = "Препараты, влияющие на пищеварительный тракт и обмен веществ";
                            CodeSG = line.Substring(0, 1);
                            result = MedList.Find(x => x.MedicName.Contains(ANMG));
                            if (result == null)
                            {
                                MedList.Add(new AnatomGroup(ANMG, CodeSG, level, i));
                            }

                            break;
                        case 3:
                            level = 1;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            CodeSG = ANMG + THSG;
                            result = MedList.Find(x => x.MedicName.Contains(CodeSG));
                            if (result == null)
                            {
                                MedList.Add(new TherapGroup(ANMG, THSG, level, i));
                            }

                            break;
                        case 4:
                            level = 2;
                            ANMG = line.Substring(0, 1);
                            THSG = line.Substring(1, 2);
                            PHSG = line.Substring(3, 1);
                            CodeSG = ANMG + THSG + PHSG;
                            result = MedList.Find(x => x.MedicName.Contains(CodeSG));
                            if (result == null)
                            {
                                MedList.Add(new PharmaGroup(PHSG, CodeSG, level, i));
                            }
                            break;
                        //case 5:
                        //    level = 3;
                        //    ANMG = line.Substring(0, 1);
                        //    THSG = line.Substring(1, 2);
                        //    PHSG = line.Substring(3, 1);
                        //    CHSG = line.Substring(4, 1);
                        //    result = MedList.Find(x => x.MedicName.Contains(ANMG + THSG + PHSG + CHSG));
                        //    if (result == null)
                        //    {
                        //        LKLIST.Add(new LekarListClass(ANMG, THSG, PHSG, CHSG, level, i));
                        //    }
                        //    break;
                        //case 7:
                        //    level = 4;
                        //    ANMG = line.Substring(0, 1);
                        //    THSG = line.Substring(1, 2);
                        //    PHSG = line.Substring(3, 1);
                        //    CHSG = line.Substring(4, 1);
                        //    CHST = line.Substring(5, 2);
                        //    result = LKLIST.Find(x => x.ShowText.Contains(ANMG + THSG + PHSG + CHSG + CHST));
                        //    if (result == null)
                        //    {
                        //        LKLIST.Add(new LekarListClass(ANMG, THSG, PHSG, CHSG, CHST, level, i));
                        //    }
                        //    break;
                    }
                }
                else
                {
                    ANMG = "ОШИБКА";
                    MedList.Add(new AnatomGroup(ANMG,"Ошибка",0, i));
                }
            }
            ParentNodesMed();*/
            Forms.AddForm NewForm = new Forms.AddForm();
            NewForm.MedList = MedList;
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
                var index = MedList.FindIndex(x => x.Index.Equals(DataDescriptionGrid.Rows[1].Cells[1].Value));
                MedList[index].MedicName = DataDescriptionGrid.Rows[0].Cells[1].Value.ToString();
                //LKLIST.Sort();
                ParentNodesMed();
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
            var index = MedList.FindIndex(x => x.Index.Equals(DataDescriptionGrid.Rows[1].Cells[1].Value));
            if (MedList[index].Child > 0)
            {
                MessageBox.Show("Нельзя удалять корни!");
            }
            else
            {
                MedList.RemoveAt(index);
            }

            //LKLIST.Sort();
            ParentNodesMed();
        }


        #endregion

        
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedList.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Kurbatova\\source\\repos\\LekarList\\LekarList\\lekar.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string AnatomicalMainGroup = node.Attributes[0].Value;
                string Code = " ";
                int level = int.Parse(node["Level"].InnerText);
                int index = int.Parse(node["Index"].InnerText);
                MedList.Add(new AnatomGroup(AnatomicalMainGroup, Code, level, index));
            }
            ParentNodesMed();
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



        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
 }

