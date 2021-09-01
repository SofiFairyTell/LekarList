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
    //кнопка, меняющая цвет при наведении курсора
    public partial class CustomControl1 : Button
    {
        List<Color> colors = new List<Color>
        {
            SystemColors.Control, Color.LightCoral, Color.Salmon, Color.PeachPuff, Color.YellowGreen, Color.LightBlue, Color.MediumPurple, Color.Crimson, Color.Beige
        };
        int CurrentIndex = 0;
        public CustomControl1()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.DarkGray;
            this.MouseEnter += ChangeColor;
            this.BackColor = colors[CurrentIndex];
        }
        private void ChangeColor(object sender, EventArgs e)
        {
            if (CurrentIndex < colors.Count - 1)
                CurrentIndex++;
            else
                CurrentIndex = 0;
            BackColor = colors[CurrentIndex];
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
