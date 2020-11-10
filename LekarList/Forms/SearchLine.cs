using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LekarList;

namespace LekarList.Forms
{
    public partial class SearchLine : Form
    {
        public SearchLine()
        {
            InitializeComponent();
        }
       // private bool Button_click = false;

        public void OkButton_SearchLine_Click(object sender, EventArgs e)
        {
            //Button_click = true;
            string SearchText = this.TextBox_SearchLine.Text;

            if (SearchText == "")

            {
                SearLineToolTip.Show("Поле не может быть пустым!",TextBox_SearchLine, 10000);
                return;
            };
            //передаем введенную строку на глобальную форму
            //return search string in main form
            LekarList.MainWindows.searchline = SearchText;
            this.Close();

        }
    }
    
}
