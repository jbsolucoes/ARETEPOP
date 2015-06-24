using Phychips.Helper;
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
    public partial class FormAccess : Form
    {
        private TagVO target;
        
        public TagVO Target
        {
            get { return target; }
            set { target = value; }
        }
        
        public FormAccess()
        {
            InitializeComponent();
        }
        
        private void Form_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Arial", 10);
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
            if (target == null)
                this.Close();

            this.ActiveControl = this.label1;

            System.Console.WriteLine(new ByteBuilder(target.Epc).ToString());
            System.Console.WriteLine(target.TimeStamp);
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
        
        /*
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);
            form.Show();
            this.Hide();
        }
        */
        
        private void buttonReadWrite_Click(object sender, EventArgs e)
        {
            FormReadWrite form = new FormReadWrite();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Target = target;

            form.Show();
            this.Hide();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            FormLock form = new FormLock();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Target = target;

            form.Show();
            this.Hide();
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            FormKill form = new FormKill();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Target = target;

            form.Show();
            this.Hide();
        }


        
        

    }
}
