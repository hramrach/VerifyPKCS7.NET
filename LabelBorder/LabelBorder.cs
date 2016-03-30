using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LabelBorder
{
    public partial class LabelBorder : Label
    {
        private Color border_color;
        private bool border_chained = true;
        
        public LabelBorder()
        {
            InitializeComponent();
            border_color = SystemPens.ControlText.Color;
        }
        [Description("Color of border drawn around label"), Category("Appearance")]
        public Color BorderColor
        {
            get
            {
                return border_color;
            }
            set
            {
                border_chained = ForeColor.Equals(value);
                if (!border_color.Equals(value))
                {
                    border_color = value;
                    Invalidate();
                }

            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /* the real border is painted outside of control so only attmpt paint if real border is not present */
            if (BorderStyle.Equals(BorderStyle.None) && (Text.Length > 0))
                ControlPaint.DrawBorder(e.Graphics, DisplayRectangle, border_color, ButtonBorderStyle.Solid);

        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            /* presumably you can override ForeColor setter but this works also */
            if (border_chained)
                BorderColor = ForeColor;
        }
    }
}