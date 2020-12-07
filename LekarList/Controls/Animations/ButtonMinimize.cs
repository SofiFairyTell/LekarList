

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace LekarList
{
    public class ButtonMinimize : Control
    {
        private StringFormat SF = new StringFormat();
        private bool MouseEntered = false;
        private bool MousePressed = false;
        Animation ButtonAnimation = new Animation();

        public ButtonMinimize()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 30);
            BackColor = Color.Coral;
            ForeColor = Color.White;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectNew = new Rectangle(0, 0, (int)ButtonAnimation.Value, Height - 1);

            /*Основной прямоугольника*/
            graphics.DrawRectangle(new Pen(BackColor), rect);
            graphics.FillRectangle(new SolidBrush(BackColor), rect);

            /*Для "шторки"*/
            graphics.DrawRectangle(new Pen(Color.FromArgb(255, Color.White)), rectNew);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, Color.White)), rectNew);

            //if (MouseEntered)
            //{
            //    graphics.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
            //    graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            //}

            if (MousePressed)
            {
                graphics.DrawRectangle(new Pen(Color.FromArgb(40, Color.Black)), rect);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, Color.Black)), rect);
            }
            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            DoCurtainAnimation();
//Invalidate();//для перерисовки кнопки с учетом измененных параметров
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            DoCurtainAnimation();
            // Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
        }

        /*Для анимации*/
        private void DoCurtainAnimation()
        {
            if (MouseEntered == true)
            {
                ButtonAnimation = new Animation("Curtain_" + Handle, Invalidate, ButtonAnimation.Value, Width - 1);
            }
            else
            {
                ButtonAnimation = new Animation("Curtain_" + Handle, Invalidate, ButtonAnimation.Value, 0);
            }

            Animator.Request(ButtonAnimation, true);
        }
    }
}


