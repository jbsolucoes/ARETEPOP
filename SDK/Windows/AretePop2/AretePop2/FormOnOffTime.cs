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
    public partial class FormOnOffTime : Form , IRcpEvent2
    {
        private int onTime = 0;

        public int OnTime
        {
            get { return onTime; }
            set { onTime = value; }
        }
        private int offTime = 0;

        public int OffTime
        {
            get { return offTime; }
            set { offTime = value; }
        }
        private int senseTime = 0;

        public int SenseTime
        {
            get { return senseTime; }
            set { senseTime = value; }
        }

        private int lbtLevel = 0;

        public int LbtLevel
        {
            get { return lbtLevel; }
            set { lbtLevel = value; }
        }


        private int fhEnable = 0;

        public int FhEnable
        {
            get { return fhEnable; }
            set { fhEnable = value; }
        }
        private int lbtEnable = 0;

        public int LbtEnable
        {
            get { return lbtEnable; }
            set { lbtEnable = value; }
        }
        private int cwEnable = 0;

        public int CwEnable
        {
            get { return cwEnable; }
            set { cwEnable = value; }
        }
        
        public FormOnOffTime()
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
           
            this.textBoxOnTime.Text = onTime.ToString();
            this.textBoxOffTime.Text = offTime.ToString();

            RcpApi2.Instance.setOnRcpEventListener(this);
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
                onTime = int.Parse(textBoxOnTime.Text);
                offTime = int.Parse(textBoxOffTime.Text);
                RcpApi2.Instance.setFhLbtParam(onTime, offTime, senseTime, lbtLevel, fhEnable, lbtEnable, cwEnable);
            }
            catch
            {

            }
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
