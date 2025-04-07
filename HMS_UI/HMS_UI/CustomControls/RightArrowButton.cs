using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace HMS_UI.CustomControls
{
    public class RightArrowButton : Control
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

        public RightArrowButton()
        {
            Size = new Size(50, 50);
            Cursor = Cursors.Hand;
            BackColor = Color.Beige;
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
                new Point(padding, padding),
                new Point(Width - padding, Height / 2),
                new Point(padding, Height - padding)
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
            Invalidate(); // Redraw with hover color
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate(); // Redraw without hover color
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // 🚀 Call the custom event (handle logic in the form)
            ArrowClicked?.Invoke(this, EventArgs.Empty);

            // 🔹 Commented out: You can define the behavior in the form
            // pageNumber++; 
        }
    }
}