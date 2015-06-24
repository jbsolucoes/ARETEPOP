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
    public partial class FormReadWrite : Form, IRcpEvent2
    {
        private TagVO target;

        public TagVO Target
        {
            get { return target; }
            set { target = value; }
        }

        public FormReadWrite()
        {
            InitializeComponent();
        }

        private int mode = 0;
        private int memory = 0;
        
        public int Mode
        {
            get { return mode; }
            set 
            { 
                switch(value)
                {
                    case 0:
                        this.labelMode.Text = "Read";
                        custSegButtonRead.Checked = true;
                        custSegButtonWrite.Checked = false;
                        textBoxWordLength.Enabled = true;
                        break;
                    case 1:
                        this.labelMode.Text = "Write";
                        custSegButtonRead.Checked = false;
                        custSegButtonWrite.Checked = true;
                        textBoxWordLength.Enabled = false;
                        break;
                }
                mode = value; 
            }
        }


        public int Memory
        {
            get { return memory; }
            set 
            { 
                switch(value)
                {
                    case 0:
                        this.custSegButtonRFU.Checked = true;
                        this.custSegButtonEPC.Checked = false;
                        this.custSegButtonTID.Checked = false;
                        this.custSegButtonUSER.Checked = false;
                        break;
                    case 1:
                        this.custSegButtonRFU.Checked = false;
                        this.custSegButtonEPC.Checked = true;
                        this.custSegButtonTID.Checked = false;
                        this.custSegButtonUSER.Checked = false;
                        break;
                    case 2:
                        this.custSegButtonRFU.Checked = false;
                        this.custSegButtonEPC.Checked = false;
                        this.custSegButtonTID.Checked = true;
                        this.custSegButtonUSER.Checked = false;
                        break;
                    case 3:
                        this.custSegButtonRFU.Checked = false;
                        this.custSegButtonEPC.Checked = false;
                        this.custSegButtonTID.Checked = false;
                        this.custSegButtonUSER.Checked = true;
                        break;
                }
                memory = value; 
            }
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
            this.textBoxTarget.Text = new ByteBuilder(target.Epc).ToString();
            RcpApi2.Instance.setOnRcpEventListener(this);
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

        private void custSegButtonRead_Click(object sender, EventArgs e)
        {            
            this.Mode = 0;
        }

        private void custSegButtonWrite_Click(object sender, EventArgs e)
        {            
            this.Mode = 1;
        }

        private void custSegButtonRFU_Click(object sender, EventArgs e)
        {
            this.Memory = 0;
        }

        private void custSegButtonEPC_Click(object sender, EventArgs e)
        {
            this.Memory = 1;
        }

        private void custSegButtonTID_Click(object sender, EventArgs e)
        {
            this.Memory = 2;
        }

        private void custSegButtonUSER_Click(object sender, EventArgs e)
        {
            this.Memory = 3;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {            
            int startAddress;
            int dataLength;
            long ap;
            byte[] data = null;

            try
            {               
                startAddress = Convert.ToInt32(textBoxStartAddress.Text, 16);                    
                dataLength = UInt16.Parse(textBoxWordLength.Text);                
                ap = Convert.ToUInt32(textBoxAccessPassword.Text, 16);                
                if (textBoxData.Text.Length > 0)
                    data = StringHelper.ArgStringHexToByte(textBoxData.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(mode == 0)
            {
                RcpApi2.Instance.readFromTagMemory(ap, target.Epc, memory, startAddress, dataLength);
            }
            else
            {
                RcpApi2.Instance.writeToTagMemory(ap, target.Epc, memory, startAddress, data);
            }
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
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onTagMemoryReceived(data);
                }));
                return;
            }

            this.textBoxData.Text = StringHelper.ArgByteToStringByte(data).Replace(" ","");
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
            //throw new NotImplementedException();
        }


        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }
}
