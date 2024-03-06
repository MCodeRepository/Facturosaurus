using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facturosaurus.Forms.Printing
{
    public class LineSeparator : Control
    {
        private int _thickness = 1;
        private bool _isVertical = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var sz = _isVertical ? Height/2 : Width/2;
            e.Graphics.TranslateTransform(Width/2f, Height/2f);

            using(var pen = new Pen(ForeColor, _thickness))
            {
                if(!_isVertical)
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right, 0);
                    
                }
            }
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }
    }
}
