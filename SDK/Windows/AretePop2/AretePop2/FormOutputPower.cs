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
    public partial class FormOutputPower : Form, IRcpEvent2
    {
        private int minPower = 0;
        private int maxPower = 0;
        private int powerLevel = 0;
        private int prevCheckedIndex = -1;

        public int MinPower
        {
            get { return minPower; }
            set { minPower = value; }
        }
        
        public int MaxPower
        {
            get { return maxPower; }
            set { maxPower = value; }
        }
        
        public int PowerLevel
        {
            get { return powerLevel; }
            set { powerLevel = value; }
        }
        
        public FormOutputPower()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Arial", 10);

            this.custListViewImage1.HideScrollBar(CustListViewImage.ScrollBarDirection.SB_HORZ);

            custListViewImage1.RowChecked += RowChecked;
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
            RcpApi2.Instance.setOnRcpEventListener(this);

            for(int i = minPower; i <= maxPower; i += 5)
            {
                string power = (((float)i) / 10.0f).ToString("0.0");                
                custListViewImage1.Items.Add(new ListViewItem(power));
            }
            this.custListViewImage1.Items[(powerLevel - minPower) / 5].Checked = true;
            prevCheckedIndex = (powerLevel - minPower) / 5;
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

        private void buttonMore_Click(object sender, EventArgs e)
        {
            RcpApi2.Instance.setOutputPowerLevel(powerLevel);
        }

        public void RowChecked(object sender, CheckIndexEventArgs e)
        {
            if (prevCheckedIndex < 0)
                return;

            if (prevCheckedIndex != e.CheckedIndex)
            {
                this.custListViewImage1.Checked(prevCheckedIndex, false);

                prevCheckedIndex = e.CheckedIndex;

                this.custListViewImage1.Checked(prevCheckedIndex, true);

                powerLevel = minPower + prevCheckedIndex * 5;
                //System.Console.WriteLine("powerLevel" + powerLevel);
            }            
            else
            {
                this.custListViewImage1.Checked(prevCheckedIndex, true);
            }
        }

        /*
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Only interested in 2nd column.
            if (e.Header != this.columnHeader1)
            {
                e.DrawDefault = true;
                return;
            }

            //e.DrawBackground();
            var imageRect = new Rectangle(e.Bounds.X + e.Bounds.Width - e.Bounds.Height, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            e.Graphics.DrawImage(Phychips.PR9200.Properties.Resources.toggle_switch_on, imageRect);
        }
        */




        public void onPlugged(bool plug, string port)
        {
            throw new NotImplementedException();
        }

        public void onResetReceived()
        {
            throw new NotImplementedException();
        }

        public void onSuccessReceived(byte[] data, int commandCode)
        {
            //throw new NotImplementedException();
        }

        public void onFailureReceived(byte[] errCode)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onFailureReceived(errCode);
                }));
                return;
            }

            MessageBox.Show("Error code: " + new ByteBuilder(errCode).ToString()); 
        }

        public void onTagReceived(byte[] pcEpc)
        {
            throw new NotImplementedException();
        }

        public void onTagWithTidReceived(byte[] pcEpc, byte[] tid)
        {
            throw new NotImplementedException();
        }

        public void onTagWithRssiReceived(byte[] pcEpc, int rssi)
        {
            throw new NotImplementedException();
        }

        public void onReaderInfoReceived(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void onRegionReceived(int region)
        {
            throw new NotImplementedException();
        }

        public void onSelectParamReceived(byte[] selParam)
        {
            throw new NotImplementedException();
        }

        public void onQueryParamReceived(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void onChannelReceived(int channel, int channelOffset)
        {
            throw new NotImplementedException();
        }

        public void onFhLbtReceived(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void onTxPowerLevelReceived(int data)
        {
            throw new NotImplementedException();
        }

        public void onTagMemoryReceived(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void onTagMemoryLongReceived(byte[] dest)
        {
            throw new NotImplementedException();
        }

        public void onBatteryStateReceived(byte[] dest)
        {
            //throw new NotImplementedException();
        }

        public void onSessionReceived(int session)
        {
            throw new NotImplementedException();
        }





        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }
}
