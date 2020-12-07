using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LekarList
{
    public partial class ButtonUI : UserControl
    {
        public ButtonUI()
        {
            //InitializeComponent();
            /*Чтобы не мерцала при перерисовке*/
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(30, 100);
        }

        private void ButtonUI_Load(object sender, EventArgs e)
        {

        }

        ////protected override void OnPaint(PaintEventArgs e)
        ////{
        ////    base.OnPaint(e);
        ////    Graphics graph = e.Graphics;
        ////    graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        ////    graph.Clear(Parent.BackColor);

        ////    Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        ////    graph.DrawRectangle(new Pen(BackColor), rect);

        ////}
    }
}
