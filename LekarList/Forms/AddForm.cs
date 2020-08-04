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
        List<LekarListClass> LKLIST;
        private BindingList <LekarListClass> ListLekar = new BindingList<LekarListClass>();
        public AddForm()
        {
            InitializeComponent();
            dataGridView1.Rows[0].Cells[0].Value = LKLIST[0].ShowText;
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
