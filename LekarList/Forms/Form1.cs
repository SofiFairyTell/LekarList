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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            /*to do*/
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            /*to do*/
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            /*to do*/
        }

        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void panel1_DragLeave(object sender, EventArgs e)
        {

        }

        void panel1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
