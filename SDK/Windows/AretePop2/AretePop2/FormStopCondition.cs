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
    public partial class FormStopCondition : Form
    {
        public FormStopCondition()
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
            this.textBoxTagCount.Text = Properties.Settings.Default.max_tag.ToString();
            this.textBoxElapsedTime.Text = Properties.Settings.Default.max_time.ToString();
            this.textBoxCycle.Text = Properties.Settings.Default.repeat_cycle.ToString();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (Form)Tag;
            form.Show();                         
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.max_tag = int.Parse(this.textBoxTagCount.Text);
                Properties.Settings.Default.max_time = int.Parse(this.textBoxElapsedTime.Text);
                Properties.Settings.Default.repeat_cycle = int.Parse(this.textBoxCycle.Text);

                Properties.Settings.Default.Save();
            }
            catch
            {

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

    }
}
