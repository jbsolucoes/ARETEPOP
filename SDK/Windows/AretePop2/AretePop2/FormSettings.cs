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
    public partial class FormSettings : Form, IRcpEvent2
    {
        private int beepStatus = 0;
        private int onTime = 0;
        private int offTime = 0;
        private int senseTime = 0;
        private int lbtLevel = 0;
        private int fhEnable = 0;
        private int lbtEnable = 0;
        private int cwEnable = 0;
        private int txPowerLevel = 0;
        private int txMinPower = 0;
        private int txMaxPower = 0;
        private string pad = "   ";

        public FormSettings()
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

            RcpApi2.Instance.getReaderInfo(0xB0);

            this.labelStopCondition.Text
                = Properties.Settings.Default.max_tag.ToString() + "/"
                + Properties.Settings.Default.max_time.ToString() + "/"
                + Properties.Settings.Default.repeat_cycle.ToString() + pad;

            this.toggleButtonSpeakerBeep.Checked = Properties.Settings.Default.speakerBeep;
            this.toggleButtonRssi.Checked = Properties.Settings.Default.displayRSSI;
            this.toggleButtonReadAfterPlugging.Checked = Properties.Settings.Default.readAfterPlugging;

            this.labelEncodingType.Text = EpcConverter.toTypeString(Properties.Settings.Default.encodingType) + pad;        
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();

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

            if (data.Length == 20 && ((data[0] & 0xff) == 0xB0))            
            {
                beepStatus = data[1];
                onTime = data[3] << 8 | data[4];
                offTime = data[5] << 8 | data[6];
                senseTime = data[7] << 8 | data[8];
                lbtLevel = data[9] << 8 | data[10];
                fhEnable = data[11];
                lbtEnable = data[12];                
                cwEnable = data[13];

                txPowerLevel = data[14] << 8 | data[15];
                txMinPower = data[16] << 8 | data[17];
                txMaxPower = data[18] << 8 | data[19];


                this.labelOutputPower.Text = (((float)txPowerLevel) / 10).ToString("0.0") + pad;
                this.labelOnOffTime.Text = onTime.ToString() + "/" + offTime.ToString() + pad;

                if( beepStatus > 0)
                {
                    this.toggleButtonBeep.Checked = true;
                }
                else
                {
                    this.toggleButtonBeep.Checked = false;
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
            this.Close();
        }

        public void onPlugged(bool plug, string port)
        {
            throw new NotImplementedException();
        }

        private void buttonOutputPower_Click(object sender, EventArgs e)
        {
            FormOutputPower form = new FormOutputPower();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);            
                        
            form.MinPower = this.txMinPower;
            form.MaxPower = this.txMaxPower;
            form.PowerLevel = this.txPowerLevel;

            form.Show();
            this.Hide();
        }
        
        private void labelOutputPower_Click(object sender, EventArgs e)
        {
            buttonOutputPower.PerformClick();
        }

        private void buttonOnOffTime_Click(object sender, EventArgs e)
        {
            FormOnOffTime form = new FormOnOffTime();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.OnTime = this.onTime;
            form.OffTime = this.offTime;
            form.SenseTime = this.senseTime;
            form.LbtLevel = this.lbtLevel;
            form.FhEnable = this.fhEnable;
            form.LbtEnable = this.lbtEnable;
            form.CwEnable = this.cwEnable;

            form.Show();
            this.Hide();
        }

        private void labelOnOffTime_Click(object sender, EventArgs e)
        {
            buttonOnOffTime.PerformClick();
        }

        private void buttonStopConditions_Click(object sender, EventArgs e)
        {
            FormStopCondition form = new FormStopCondition();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Show();
            this.Hide();
        }

        private void labelStopCondition_Click(object sender, EventArgs e)
        {
            buttonStopConditions.PerformClick();
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
            FormSession form = new FormSession();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Show();
            this.Hide();
        }

        private void labelSession_Click(object sender, EventArgs e)
        {
            buttonSession.PerformClick();
        }

        private void toggleButtonBeep_Click(object sender, EventArgs e)
        {
            if (toggleButtonBeep.Checked)
            {
                RcpApi2.Instance.setBeep(true);
            }
            else
            {
                RcpApi2.Instance.setBeep(false);
            }
        }

        private void buttonBeep_Click(object sender, EventArgs e)
        {
            toggleButtonBeep.PerformClick();
        }
        
        private void buttonEncoding_Click(object sender, EventArgs e)
        {
            FormEncodingType form = new FormEncodingType();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.Show();
            this.Hide();
        }

        private void labelEncodingType_Click(object sender, EventArgs e)
        {
            buttonEncoding.PerformClick();
        }

        private void toggleButtonSpeakerBeep_Click(object sender, EventArgs e)
        {
            if(this.toggleButtonSpeakerBeep.Checked)
            {
                Properties.Settings.Default.speakerBeep = true;
            }
            else
            {
                Properties.Settings.Default.speakerBeep = false;
            }
        }

        private void buttonSpeakerBeep_Click(object sender, EventArgs e)
        {
            toggleButtonSpeakerBeep.PerformClick();
        }

        private void toggleButtonReadAfterPlugging_Click(object sender, EventArgs e)
        {
            if(this.toggleButtonReadAfterPlugging.Checked)
            {
                Properties.Settings.Default.readAfterPlugging = true;
            }
            else
            {
                Properties.Settings.Default.readAfterPlugging = false;
            }
        }

        private void buttonReadAfterPlugging_Click(object sender, EventArgs e)
        {
            toggleButtonReadAfterPlugging.PerformClick();
        }

        private void buttonRssi_Click(object sender, EventArgs e)
        {
            if(this.toggleButtonRssi.Checked)
            {
                Properties.Settings.Default.displayRSSI = true;
            }
            else
            {
                Properties.Settings.Default.displayRSSI = false;
            }
        }

        private void toggleButtonRssi_Click(object sender, EventArgs e)
        {
            buttonRssi.PerformClick();
        }



        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }
}
