using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_course
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            textBox1.Text = "\tКобинации клавиш: \r\n F1 - справка\r\n Delete - удалить элемент\r\n CTRL + \r\n     L - загрузить из файла\r\n     S - сохранить в файл\r\n     P - добавить элемент\r\n     I - информация о программе";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
