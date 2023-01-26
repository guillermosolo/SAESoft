using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SAESoft.Utilitarios
{
    public class toggleSwitch : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onTogglecolor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offTogglecolor = Color.Gainsboro;
        private Color ondisabledColor = Color.Gray;
        private Color offdisabledColor = Color.Gray;
        private bool solidStyle = true;


        //Properties
        public Color OnBackColor
        {
            get => onBackColor;
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnTogglecolor
        {
            get => onTogglecolor;
            set
            {
                onTogglecolor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get => offBackColor;
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffTogglecolor
        {
            get => offTogglecolor;
            set
            {
                offTogglecolor = value;
                this.Invalidate();
            }
        }

        public Color OnDisabledcolor
        {
            get => ondisabledColor;
            set
            {
                ondisabledColor = value;
                this.Invalidate();
            }
        }

        public Color OffDisabledColor
        {
            get => offdisabledColor;
            set
            {
                offdisabledColor = value;
                this.Invalidate();
            }
        }
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => solidStyle;
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
            }
        }

        //Constructor
        public toggleSwitch()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Enabled)
            {
                if (this.Checked)
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                    pevent.Graphics.FillEllipse(new SolidBrush(onTogglecolor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                }
                else
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                    pevent.Graphics.FillEllipse(new SolidBrush(offTogglecolor), new Rectangle(2, 2, toggleSize, toggleSize));
                }
            }
            else
            {
                if (this.Checked)
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(ondisabledColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(ondisabledColor, 2), GetFigurePath());
                    pevent.Graphics.FillEllipse(new SolidBrush(ondisabledColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                }
                else
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(offdisabledColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(offdisabledColor, 2), GetFigurePath());
                    pevent.Graphics.FillEllipse(new SolidBrush(offdisabledColor), new Rectangle(2, 2, toggleSize, toggleSize));
                }
            }

        }

    }
}
