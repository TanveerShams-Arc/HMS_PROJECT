using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace HMS_UI.CustomControls
{
    public class LeftArrowButton : Control
    {
        public event EventHandler? ArrowClicked;

        private Color _arrowColor = Color.Black;
        private Color _hoverColor = Color.Gray;
        private bool _isHovered = false;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ArrowColor
        {
            get => _arrowColor;
            set { _arrowColor = value; Invalidate(); }
        }

        public LeftArrowButton()
        {
            this.Size = new Size(50, 50);
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Beige;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fillColor = _isHovered ? _hoverColor : _arrowColor;

            int padding = 2;
            Point[] arrowPoints =
            {
                new Point(this.Width - padding, padding),
                new Point(padding, this.Height / 2),
                new Point(this.Width - padding, this.Height - padding)
            };

            using (SolidBrush brush = new SolidBrush(fillColor))
            {
                g.FillPolygon(brush, arrowPoints);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ArrowClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
