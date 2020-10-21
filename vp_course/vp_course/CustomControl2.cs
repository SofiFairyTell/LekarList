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
    public partial class CustomControl2 : Button
    {
        List<Color> colors = new List<Color>
        {
            Color.LightCoral, Color.Salmon, Color.PeachPuff, Color.YellowGreen, Color.LightBlue, Color.MediumPurple, Color.Crimson, Color.Beige
        };
        bool thicc = false;
        int StartingWidth;
        int StartingHeight;
        bool FirstTimeHuh = true;
        public CustomControl2()
        {
            this.Click += ChangeSize;
            this.Text = "Нажми на меня :)";
            InitializeComponent();
        }
        private void ChangeSize(object sender, EventArgs e)
        {
            if (thicc)
            {
                thicc = false;
                this.Size = new Size(StartingWidth, StartingHeight);
                this.Text = "Нажми на меня :)";
            }
            else 
            {
                if (FirstTimeHuh)
                {
                    StartingWidth = this.Size.Width;
                    StartingHeight = this.Size.Height;
                    FirstTimeHuh = false;
                }
                thicc = true;
                this.Size = new Size((int)(this.Size.Width * 1.5),(int)(this.Size.Height * 1.5));
                this.Text = "И еще раз! :Р";
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (FirstTimeHuh)
                this.Text = "Нажми на меня :)";
            base.OnPaint(pe);
        }
    }
}
