using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp
{
    class PanelGradient : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBot { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradient = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBot, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(linearGradient, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
