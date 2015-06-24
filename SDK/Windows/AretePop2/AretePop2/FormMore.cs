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
    public partial class FormMore : Form
    {
        private List<TagVO> listTagVO;

        public List<TagVO> ListTagVO
        {
            get { return listTagVO; }
            set { listTagVO = value; }
        }
            
        public FormMore()
        {
            InitializeComponent();
        }
        
        private void FormMore_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Arial", 10);
        }

        private void FormMore_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.StartPosition = FormStartPosition.Manual;
                onResume();
            }
        }
        
        private void onResume()
        {

        }

        private void FormMore_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (Form)Tag;
            form.Show();                         
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);
            form.Show();
            this.Hide();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);
            form.Show();
            this.Hide();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if(listTagVO.Count <= 0)
            {
                MessageBox.Show("No tag to export");
                return;
            }

            StringBuilder sb = new StringBuilder();
                        
            for (int i = 0; i < listTagVO.Count; i++)
            {
                TagVO vo = listTagVO[i];

                sb.Append(i.ToString());
                sb.Append(",");
                sb.Append(vo.TimeStamp);
                sb.Append(",");
                sb.Append(BitConverter.ToString(vo.Epc).Replace("-", string.Empty));
                sb.Append("\r\n");
            }
            
            SaveFileDialog sfd = new SaveFileDialog();            
            sfd.DefaultExt = "csv";
            sfd.Filter = "CSV (*.csv)|*.csv|All Files(*.*)|*.*";
            sfd.FilterIndex = 0;
            sfd.RestoreDirectory = true;

            String time = DateTime.Now.Year.ToString("0000")
                + DateTime.Now.Month.ToString("00")
                + DateTime.Now.Day.ToString("00")
                + DateTime.Now.Hour.ToString("00")
                + DateTime.Now.Minute.ToString("00")
                + DateTime.Now.Second.ToString("00");

            sfd.FileName = "tags_" + time + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter stringWriter = new System.IO.StreamWriter(sfd.FileName);
                stringWriter.Write(sb.ToString());
                stringWriter.Flush();
                stringWriter.Close();
            }            
        }


        
        

    }
}
