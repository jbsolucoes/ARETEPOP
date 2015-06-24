using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phychips.Arete
{
    public class CustLabel : Label
    {
        //private string pad = "   ";

        protected override void InitLayout()
        {
            base.InitLayout();

            this.AutoSize = false;
            this.Image = Phychips.Arete.Properties.Resources.disclosure;
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;            
            this.ForeColor = Color.SteelBlue;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackColor = Color.Transparent;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new System.Drawing.Size(150, 25);
        }

    }
}
