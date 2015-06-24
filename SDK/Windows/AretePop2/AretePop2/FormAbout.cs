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
    public partial class FormAbout : Form, IRcpEvent2
    {

        public FormAbout()
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
            RcpApi2.Instance.setOnRcpEventListener(this);            
            RcpApi2.Instance.getReaderInfo(0xB1);            
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

        public void onResetReceived()
        {
            //throw new NotImplementedException();
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

            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onReaderInfoReceived(data);
                }));
                return;
            }
            
            if (data.Length > 1 && (data[0] & 0xff) == 0xB1)
            {
                string temp = (new ByteBuilder(data)).ToString();

                int region = (int)(data[1] & 0xff);
                int adc = (int)(data[2] & 0xff);
                int adcMin = (int)(data[3] & 0xff);
                int adcMax = (int)(data[4] & 0xff);

                char[] chars = new char[data.Length];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                try
                {
                    d.GetChars(data, 5, data.Length - 5, chars, 0);
                }
                catch
                {

                }

                string firmware = temp.Substring(50, 8);

                temp = new string(chars);
                string model = temp.Substring(0, 10);
                string serial = temp.Substring(10, 10);
                

                if (adcMin == adcMax)
                {
                    adcMax += 1;
                }

                int battery = (adc - adcMin) * 100 / (adcMax - adcMin);

                if (battery > 100)
                    battery = 100;
                else if (battery < 0)
                    battery = 0;

                System.Reflection.Assembly a = typeof(FormAretePop2).Assembly;
                string version = a.GetName().Version.ToString();

                {
                    this.labelRegion.Text = parseRegion(region);
                    this.labelPid.Text = serial;
                    this.labelModel.Text = model;
                    this.labelBattery.Text = battery.ToString() + "%";
                    this.labelFid.Text = firmware;
                    this.labelAppVersion.Text = version;
                }
            }

        }

        private string parseRegion(int region)
        {
	        string name;
	        switch (region)
	        {
	        case 0x01:
	        case 0x11:
	            name = "KOREA";
	            break;
	        case 0x02:
	        case 0x21:
	        case 0x22:
	        case 0x32:
	            name = "USA";
	            break;
	        case 0x04:
	        case 0x31:
	            name = "EU";
	            break;
	        case 0x08:
	        case 0x41:
	            name = "JAPAN";
	            break;
	        case 0x10:
	        case 0x16:
	        case 0x51:
	        case 0x52:
	            name = "CHINA";
	            break;
	        case 0x71:
	            name = "ASIA";
	            break;
	        default:
	            name = "NONE";
	            break;
	        }

	        return name;
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




        public void onPortOpened(string port)
        {
            //throw new NotImplementedException();
        }

        public void onPortClosed(string port)
        {
            //throw new NotImplementedException();
        }

        public void onPlugged(bool plug, string port)
        {
            throw new NotImplementedException();
        }


        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }
}
