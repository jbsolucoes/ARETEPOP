using Phychips.Rcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phychips.Arete
{
    public partial class FormEncodingType : Form
    {
        private int prevCheckedIndex = -1;

        public FormEncodingType()
        {
            InitializeComponent();
        }
        
        private void Form_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Arial", 10);

            this.custListViewImage1.HideScrollBar(CustListViewImage.ScrollBarDirection.SB_BOTH);

            custListViewImage1.RowChecked += RowChecked;
        }

        private void RowChecked(object sender, CheckIndexEventArgs e)
        {
            if (prevCheckedIndex < 0)
                return;

            if (prevCheckedIndex != e.CheckedIndex)
            {
                this.custListViewImage1.Checked(prevCheckedIndex, false);

                prevCheckedIndex = e.CheckedIndex;

                this.custListViewImage1.Checked(prevCheckedIndex, true);
            }
            else
            {
                this.custListViewImage1.Checked(prevCheckedIndex, true);
            }
        }

        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.StartPosition = FormStartPosition.Manual;
                onResume();
            }
        }
        
        private void onResume()
        {
            int sel = Properties.Settings.Default.encodingType;

            this.custListViewImage1.Items[sel].Checked = true;

            prevCheckedIndex = sel;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (Form)Tag;
            form.Show();                         
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void buttonDone_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.encodingType = prevCheckedIndex;

            Properties.Settings.Default.Save();
        }

        
    }
}
