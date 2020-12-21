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
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace LekarList
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
            
            StatusStrip1Initizlization();
            StatusStrip2Initizlization();

            Animator.Start();
        }
        //Error Message
        public string ErrorMess = "Нельзя изменять главный уровень!";
        public string ErrorMess2 = "Нельзя удалить уровень у которого есть подуровни!";
        public string ErrorMess3 = "Нельзя изменить не открытый узел";
        //Cписки
        public static List<Medication> MedList = new List<Medication>();
        public static List<AnatomGroup> AnatomGroups = new List<AnatomGroup>();
        public static List<TherapGroup> TherapGroups = new List<TherapGroup>();
        public static List<PharmaGroup> PharmaGroups = new List<PharmaGroup>();
        public static List<ChemGroup> ChemGroups  = new List<ChemGroup>();

        //Переменные
        ToolStripLabel timeStartLabel, dateLabel, timeLabel;
        private static ulong timeSec = 0;
        public static string searchline;//this string may be init after entering text in searchForm
        ToolStripMenuItem UpdateMenuItem = new ToolStripMenuItem("Обновить");
        
        private void MainWindows_Load_1(object sender, EventArgs e)
        {
            /*Тестовые данные для списка*/
            AnatomGroup anatom1 = new AnatomGroup("Препараты, влияющие на пищеварительный тракт и обмен веществ","A", 
                                                "Раздел системы буквенно-цифровых кодов Анатомо-терапевтическо-химической классификации," +
                                                "разработанных Всемирной организацией здравоохранения для классификации лекарств и других " +
                                                "медицинских продуктов", 0, 0);
            TherapGroup therap1 = new TherapGroup("Стоматологические препараты", "A01", "Подгруппа А01 является частью группы препаратов A " +
                                                "«Препараты, влияющие на пищеварительный тракт и обмен веществ» ", 1, 1);
            PharmaGroup pharma1 = new PharmaGroup("Препараты для профилактики кариеса", "A01A", 
                                                 "\n\tA01AA01 Фторид натрия, " +
                                                 "\n\tA01AA02 Натрия монофторфосфат," +
                                                 "\n\tA01AA03 Олафлур," +
                                                 "\n\tA01AA04 Фторид олова," +
                                                 "\n\tA01AA30 Комбинации," +
                                                 "\n\tA01AA51 Комбинации фторида натрия",2, 2);
            //ChemGroup chem1 = new ChemGroup("A", "01", "A", "A", 3, 3);

            AnatomGroup anatom2 = new AnatomGroup("Препараты, влияющие на кроветворение и кровь","B"," ",0, 3);
            TherapGroup therap2 = new TherapGroup("Антикоагулянты", "B01"," ", 1, 4);
            // PharmaGroup pharma2 = new PharmaGroup("B", "01", "A", 2, 8);
            MedList.Clear();
            MedList.Add(anatom1);
            MedList.Add(therap1);
            MedList.Add(pharma1);
          //  MedList.Add(anatom2);
            //MedList.Add(therap2);

            //AnatomGroups.Add(anatom1);
           //AnatomGroups.Add(anatom2);
            TherapGroups.Add(therap1);
            //TherapGroups.Add(therap2);
            //PharmaGroups.Add(pharma1);

            contextMenuStrip1.Items.AddRange(new[] { UpdateMenuItem});
            treeView1.ContextMenuStrip = contextMenuStrip1;
            UpdateMenuItem.Click += UpdateMenuItem_Click;

            

            ParentNodesMed();
        }
        void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            // если выделен текст в текстовом поле, то копируем его в буфер
            ParentNodesMed();
        }
        #region Статусы

        // создаем элементы меню

        // добавляем элементы в меню
        //   
        // ассоциируем контекстное меню с текстовым полем
        void Timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        void Timer_Tick2(object sender, EventArgs e)
        {
            timeSec += 1;
            timeStartLabel.Text = timeSec.ToString();
        }
        private void StatusStrip1Initizlization()
        {
            ToolStripLabel infoLabel = new ToolStripLabel()
            {
                Text = "Текущие дата и время:"
            };
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            Timer timer2 = new Timer() { Interval = 1000 };
            timer2.Tick += Timer_Tick2;
            timer.Start();
            timer2.Start();
        }
        private void StatusStrip2Initizlization()
        {
            ToolStripLabel toolStripLabel = new ToolStripLabel();
            ToolStripLabel infoLabel = toolStripLabel;
            infoLabel.Text = "Время работы программы в секундах:";
            timeStartLabel = new ToolStripLabel();
            statusStrip2.Items.Add(infoLabel);
            statusStrip2.Items.Add(timeStartLabel);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        #endregion

        #region TREENODE
        /*--------------Динамическое добавление данных в TreeView-------------------*/
        /*Прим. Пока работает корректно для данных последовательно добавляемых в список: 
         Анатомическая Группа - level = 0, index = 0
         Терапевтическая Группа - level = 1, index = 1
         Фармакологическая Группа - level = 2, index = 2
         Анатомическая Группа - level = 0, index = 3
         Разнесение в списке идет по уровням. Но если изменить порядок записи в список 
         то добавление будет некорректно отображаться. 
         Как исправить?? Искать в файле и сравнивать по коду внутри списка?
         */
        public void ParentNodesMed()
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

        /*--------------------Отображение содержимого класса--------------------------------*/
        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
            
                TreeNode node = treeView1.SelectedNode;// Получение выбранного двойным щелчком узла дерева.
           
                MessageBox.Show(string.Format("You selected: {0}", node.Text)); // Вывод окна с текстом данного узла.

                DataDescriptionGrid.Rows.Clear();
                DataDescriptionGrid.Columns.Clear();
                DataGridInit();
                DataDescriptionGrid.ReadOnly = true;
                DataDescriptionGrid.Visible = true;

                /*----------Кнопки---------------*/
                AddItem.Visible = true;
                EditItem.Visible = true;//для изменения данных в содержимом узла
                DelItem.Visible = true;
                MinimizeItem.Visible = true;//для закрытия информации об узле
                /*---------Кнопки--------------*/

                var index = MedList.FindIndex(x => x.MedicName.Contains(node.Text));
                DataDescriptionGrid.Rows[0].Cells[1].Value = MedList[index].Code;//код группы
                DataDescriptionGrid.Rows[1].Cells[1].Value = MedList[index].MedicName;//название группы/препарата если на его уровне
                DataDescriptionGrid.Rows[2].Cells[1].Value = MedList[index].Description;

                DataDescriptionGrid.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DataDescriptionGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //автоматическое выравнивание текста в колонке
                DataDescriptionGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*--------------------------------------------------------------------------------*/
       
       /*---------функция поиска в дереве. Если ничего не найдено - возвращает null------*/
        public static TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node=null;
            while (StartNode!= null && SearchText != null) 
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode; //node was found
                    break;
                };
                if (StartNode.Nodes.Count != 0) //if node has child
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);//ищем рекурсивно в дочерних
                    if (node != null)
                    {
                        break;
                    };
                };
                StartNode = StartNode.NextNode;
            };
            return node;//вернули результат поиска
        }

        private void StartSearh()
        {
            Forms.SearchLine searchForm = new Forms.SearchLine();
            searchForm.ShowDialog();
            
            TreeNode SelectedNode = SearchNode(searchline, treeView1.Nodes[0]);//пытаемся найти в поле Text
            if (SelectedNode != null )
            {
                //нашли, выделяем...
                this.treeView1.SelectedNode = SelectedNode;
                this.treeView1.SelectedNode.Expand();
                this.treeView1.Select();
            };
        }
       
        private void ПоискToolStripMenuItem_Click(object sender, EventArgs e) //пункт меню
        {
            StartSearh();
        }
        /*----------------------------------------------------------------------------*/

        #endregion

        #region DataGrids
        private void DataGridInit()
        {

            DataDescriptionGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DataGridViewCellStyle columnstyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Chocolate,
                Font = new Font("Arial", 11, FontStyle.Regular),
            };

            DataDescriptionGrid.Columns.Add("GroupNameColumn", "");
            DataDescriptionGrid.Columns.Add("DescripColumn", "");
            DataDescriptionGrid.Rows.Add(3);
            DataDescriptionGrid.Rows[0].Cells[0].Value = "Код: ";
            DataDescriptionGrid.Rows[1].Cells[0].Value = "Группа: ";
            DataDescriptionGrid.Rows[2].Cells[0].Value = "Описание: ";

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
            }
        }

        #endregion

        #region Кнопки

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            Forms.AddForm NewForm = new Forms.AddForm()
            {
                MedList = MedList,
            };
            NewForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
           try
           {
                if (DataDescriptionGrid.Rows[1].Cells[1].Value.ToString() == " ")
                {

                    MessageBox.Show(ErrorMess);
                }
                else
                {
                    var index = MedList.FindIndex(x => x.Code.Equals(DataDescriptionGrid.Rows[0].Cells[1].Value));
                    MedList[index].Description = DataDescriptionGrid.Rows[2].Cells[1].Value.ToString();
                    ParentNodesMed();
                }
           }
            catch (Exception ex)
           {
                MessageBox.Show($"{ErrorMess3}!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        /*--------------------Закрыть открытый для редактирования узел--------------------*/
        private void MinimButton_Click(object sender, EventArgs e)
        {
            MinimizeItem.Visible = false;
            EditItem.Visible = false;
            AddItem.Visible = false;
            DelItem.Visible = false;
            DataDescriptionGrid.Rows.Clear();              
        }
        /*-----------------------------Удаление узла------------------------------------*/
        private void DelButton_Click(object sender, EventArgs e)
        {
            try
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
                    ParentNodesMed();
            }
            catch
            {
                MessageBox.Show(ErrorMess2);
            }
        }

        #endregion     
       

        /*Обработка событий клавиатуры*/
        /*KeyDown events*/
        private void MainWindows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                SaveFile();
            if (e.Control && e.KeyCode == Keys.F)
                StartSearh();
            //if (e.Control && e.KeyCode == Keys.L)
            //    LoadFile();
            //if (e.Control && e.KeyCode == Keys.P)
            //    customControl11_Click(new object(), new EventArgs());
            //if (e.KeyCode == Keys.Delete)
            //    DeleteButton_Click(new object(), new EventArgs());
            //if (e.Control && e.KeyCode == Keys.I)
            //    AboutToolStripMenuItem_Click(new object(), new EventArgs());
            //if (e.KeyCode == Keys.F1)
            //    HelpToolStripMenuItem_Click(new object(), new EventArgs());
        }
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                SaveFile();
            if (e.Control && e.KeyCode == Keys.F)
                StartSearh();
            if (e.KeyCode == Keys.F1)
                ОПрограммеToolStripMenuItem_Click(sender, e);
        }

        /*Сохранение в виде XML файла*/
        private void SaveFile()
        {
            try
            {
                List<Type> types = new List<Type>();
                foreach(Medication med in MedList)
                {
                    Type type = med.GetType();
                    if(!types.Contains(type))
                    {
                        types.Add(type);
                    }
                }
                XmlSerializer serializer = new XmlSerializer(typeof(List<Medication>),types.ToArray());
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "*.xml";
                saveFileDialog1.Filter = "XML files|*.xml";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                {
                    using (FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    { 
                      file.SetLength(0);
                      file.Flush(); //очищает все буферы данного потока и вызывает запись данных буферов в базовое устройство.
                      serializer.Serialize(file, MedList);
                    }
                    MessageBox.Show($"Ваш файл был сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Меню
        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentNodesMed();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана в рамках выполнения курсового проекта\n\nИсходный текст программы в актуальном виде доступен на GitHub");
        }

        private void ПоказатьКнопкиToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddItem.Visible = true;
                EditItem.Visible = true;
                DelItem.Visible = true;
                MinimizeItem.Visible = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                AddItem.Visible = false;
                EditItem.Visible = false;
                DelItem.Visible = false;
                MinimizeItem.Visible = false;
            }
        }

        private void СтатистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AnatGroup, ThGroup, PhGroup, ChGroup;
            AnatGroup = AnatomGroup.Count(MedList);
            ThGroup = TherapGroup.Count(MedList);
            PhGroup = PharmaGroup.Count(MedList);
            ChGroup = ChemGroup.Count(MedList);

            MessageBox.Show(
                $"Количество Анатомических групп\n:{AnatGroup}\n" +
                 $"Количество Терапевтических групп\n:{ThGroup}\n" +
                  $"Количество Фармакологических групп\n:{PhGroup}\n" +
                   $"Количество Химических групп\n:{ChGroup}\n", 

                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void добавитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddButton_Click_1(sender, e);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Файл загружен");
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
              {
                string[] obj = (string[])e.Data.GetData(DataFormats.FileDrop); //выясним сколько файлов
                if (obj.Length >1)
                {
                    MessageBox.Show($"Слишком мгого файлов\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Path.GetExtension(obj[0]) != ".xml")
                    {
                        MessageBox.Show($"Не то расширение файла\nНадо .xml", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MedList.Clear();
                        XmlDocument doc = new XmlDocument();
                        doc.Load(obj[0]);
                        foreach (XmlNode node in doc.DocumentElement)
                        {
                            string AnatomicalMainGroup = node.Attributes[0].Value;
                            string MedicName = node["MedicName"].InnerText;
                            string Code = node["Code"].InnerText;
                            string Description = " ";
                            int level = int.Parse(node["Level"].InnerText);
                            int index = int.Parse(node["Index"].InnerText);
                            MedList.Add(new AnatomGroup(MedicName, Code, Description, level, index));
                        }
                        ParentNodesMed();
                    }

                }
                          
            }

        }


        //End work with current Form
        //завершение работы с текущей формой
        private void ВыходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "*.xml";
            openFileDialog.Filter = "XML files|*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
                MedList.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string AnatomicalMainGroup = node.Attributes[0].Value;
                string MedicName = node["MedicName"].InnerText;
                string Code = node["Code"].InnerText;
                string Description = " ";
                int level = int.Parse(node["Level"].InnerText);
                int index = int.Parse(node["Index"].InnerText);
                MedList.Add(new AnatomGroup(MedicName, Code, Description, level, index));
            }
            ParentNodesMed();
        }
        #endregion
    }
 }


