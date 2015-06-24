using Phychips.Helper;
using Phychips.Rcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Phychips.Arete
{
    public partial class FormAretePop2 : Form, IRcpEvent2
    {
        private int nTagCnt = 0;
        private int battery;
        private bool plugged = false;

        public int max_tag = 0;
        public int max_time = 0;
        public int repeat_cycle = 0;
        public bool speakerBeep = false;
        public bool readAfterPlugging = false;
        public bool displayRssi = false;
        public int encoding_type = 0;
        
        public List<TagVO> listTagVO = new List<TagVO>();
        
        public FormAretePop2()
        {
            InitializeComponent();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new Font("Arial", 10);

            {
                this.Location = new Point(Properties.Settings.Default.uiX, Properties.Settings.Default.uiY);
                Properties.Settings.Default.uiWidth = this.Size.Width;
                Properties.Settings.Default.uiHeight = this.Size.Height;
            }
            
            this.listViewEPC.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;            
            resetUI();
        }
        
        private void Form_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                this.StartPosition = FormStartPosition.Manual;
                onResume();    
            }
        }
        
        private void onResume()
        {
            RcpApi2.Instance.setOnRcpEventListener(this);

            max_tag = Properties.Settings.Default.max_tag;            
            max_time = Properties.Settings.Default.max_time;
            repeat_cycle = Properties.Settings.Default.repeat_cycle;
            speakerBeep = Properties.Settings.Default.speakerBeep;
            readAfterPlugging = Properties.Settings.Default.readAfterPlugging;
            
            bool newDisplayRssi = Properties.Settings.Default.displayRSSI;
            int new_encoding_type = Properties.Settings.Default.encodingType;
            
            if (this.displayRssi != newDisplayRssi || this.encoding_type != new_encoding_type)
            {                
                this.displayRssi = newDisplayRssi;
                this.encoding_type = new_encoding_type;
                resetUI();
            }

            if(RcpApi2.Instance.isOpened())
            {                
                plugged = true;
                RcpApi2.Instance.getBatteryState();
            }
            else if (RcpApi2.Instance.isOpenable())
            {
                plugged = true;
                if (RcpApi2.Instance.open())
                {
                    this.toggleButton.Checked = true;
                    RcpApi2.Instance.getBatteryState();
                }
            }
            else
            {
                plugged = false;
            }               

            diplayPlug();
        }
        
        private void diplayPlug()
        {
            if (plugged)
            {
                this.labelPlug.Text = "Plugged";
            }
            else
            {
                this.labelPlug.Text = "Unplugged";                
            }            
        }
                
        public void onPlugged(bool plug, string port)
        {         

            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onPlugged(plug, port);
                }));
                return;
            }

            //System.Console.WriteLine("Plug = " + plug + " Port = " + port);

            if (this.readAfterPlugging && plug)
            {
                System.Threading.Thread.Sleep(1000);

                if (RcpApi2.Instance.open())
                {
                    this.toggleButton.Checked = true;

                    System.Threading.Thread.Sleep(100);

                    if(!displayRssi)
                        RcpApi2.Instance.startReadTags(max_tag, max_time, repeat_cycle);
                    else
                        RcpApi2.Instance.startReadTagsWithRssi(max_tag, max_time, repeat_cycle);
                }
            }
            
            if (!plug)
            {
                if (RcpApi2.Instance.isOpened())
                {
                    RcpApi2.Instance.close();
                }
                this.toggleButton.Checked = false;
            }

            plugged = plug;
            diplayPlug();            
        }
        
        public void onResetReceived()
        {
            this.labelPlug.Text = "Connected";            
        }

        public void onSuccessReceived(byte[] data, int commandCode)
        {
            
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
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onTagReceived(pcEpc);
                }));
                return;
            }

            if(speakerBeep)
                SystemSounds.Beep.Play();

            //int epcStart = 6;
            int epcStart = this.getEpcStartPos(pcEpc);
            bool bDisplayed = false;
            int index;
            
            StringBuilder hsb = new StringBuilder();

            for (int i = 0; i < pcEpc.Length; i++)
            {
                try
                {
                    //hsb.Append(pcEpc[i].ToString("X2") + " ");
                    hsb.Append(pcEpc[i].ToString("X02"));
                }
                catch
                {
                    break;
                }
            }

            for (index = 0; index < listTagVO.Count; index++)
            {
                if (BitConverter.ToString(listTagVO[index].Epc).Replace("-", string.Empty) 
                    == hsb.ToString().Substring(epcStart * 2))
                {
                    bDisplayed = true;
                    break;
                }
            }

            string timeStamp =
                        DateTime.Now.Year.ToString("0000") + "/"
                    + DateTime.Now.Month.ToString("00") + "/"
                    + DateTime.Now.Day.ToString("00")
                    + " "
                    + DateTime.Now.Hour.ToString("00") + ":"
                    + DateTime.Now.Minute.ToString("00") + ":"
                    + DateTime.Now.Second.ToString("00");

            System.Console.WriteLine(timeStamp);



            if (!bDisplayed)
            {
                nTagCnt++;
                setTagCount();

                //ListViewItem lvt = new ListViewItem(hsb.ToString().Substring(0, epcStart - 1));
                ListViewItem lvt = null;

                if(encoding_type == EpcConverter.HEX_STRING)
                {
                    lvt = new ListViewItem(hsb.ToString().Substring(0, epcStart * 2));
                    lvt.SubItems.Add(hsb.ToString().Substring(epcStart * 2));
                }
                else
                {
                    string str = EpcConverter.toString(encoding_type, pcEpc);
                    bool addNew = true;

                    if (encoding_type == EpcConverter.EAN13)
                    {
                        for(int i = 0; i < listViewEPC.Items.Count; i++)
                        {
                            if (listViewEPC.Items[i].SubItems[1].Text == str)
                            {
                                addNew = false;
                                break;
                            }
                        }
                    }

                    if (addNew)
                    {
                        lvt = new ListViewItem("");
                        lvt.SubItems.Add(str);
                    }
                    
                }
                lvt.SubItems.Add("1");
                lvt.Font = new Font("Courier New", 8);                
                listViewEPC.Items.Add(lvt);

                {
                    byte[] epc = new byte[pcEpc.Length - epcStart];
                    Array.Copy(pcEpc, epcStart, epc, 0, epc.Length);
                    listTagVO.Add(new TagVO(epc, timeStamp)); 
                }
            }
            else if (encoding_type != EpcConverter.EAN13)
            {
                int bItemCount = int.Parse(listViewEPC.Items[index].SubItems[2].Text) + 1;
                listViewEPC.Items[index].SubItems[2].Text = bItemCount.ToString();
                listTagVO[index].TimeStamp = timeStamp;
            }
        }

        public void onTagWithTidReceived(byte[] pcEpc, byte[] tid)
        {
            throw new NotImplementedException();
        }

        public void onTagWithRssiReceived(byte[] pcEpc, int rssi)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onTagWithRssiReceived(pcEpc,rssi);
                }));
                return;
            }

            if (speakerBeep)
                SystemSounds.Beep.Play();

            //int epcStart = 6;
            int epcStart = this.getEpcStartPos(pcEpc);
            bool bDisplayed = false;
            int index;

            StringBuilder hsb = new StringBuilder();

            for (int i = 0; i < pcEpc.Length; i++)
            {
                try
                {
                    //hsb.Append(pcEpc[i].ToString("X2") + " ");
                    hsb.Append(pcEpc[i].ToString("X02"));
                }
                catch
                {
                    break;
                }
            }

            for (index = 0; index < listTagVO.Count; index++)
            {
                if (BitConverter.ToString(listTagVO[index].Epc).Replace("-", string.Empty)
                    == hsb.ToString().Substring(epcStart * 2))
                {
                    bDisplayed = true;
                    break;
                }
            }

            string timeStamp =
                        DateTime.Now.Year.ToString("0000") + "/"
                    + DateTime.Now.Month.ToString("00") + "/"
                    + DateTime.Now.Day.ToString("00")
                    + " "
                    + DateTime.Now.Hour.ToString("00") + ":"
                    + DateTime.Now.Minute.ToString("00") + ":"
                    + DateTime.Now.Second.ToString("00");

            System.Console.WriteLine(timeStamp);

            if (!bDisplayed)
            {
                nTagCnt++;
                setTagCount();

                ListViewItem lvt = null;

                if (encoding_type == EpcConverter.HEX_STRING)
                {
                    lvt = new ListViewItem(hsb.ToString().Substring(0, epcStart * 2));
                    lvt.SubItems.Add(hsb.ToString().Substring(epcStart * 2));
                }
                else
                {
                    string str = EpcConverter.toString(encoding_type, pcEpc);

                    lvt = new ListViewItem("");
                    lvt.SubItems.Add(str);
                }

                lvt.SubItems.Add(rssi.ToString());
                lvt.Font = new Font("Courier New", 8);
                listViewEPC.Items.Add(lvt);

                {
                    byte[] epc = new byte[pcEpc.Length - epcStart];
                    Array.Copy(pcEpc, epcStart, epc, 0, epc.Length);
                    listTagVO.Add(new TagVO(epc, timeStamp));
                }
            }
            else
            {
                
                listViewEPC.Items[index].SubItems[2].Text = rssi.ToString();
                listTagVO[index].TimeStamp = timeStamp;
            }
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
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onBatteryStateReceived(dest);
                }));
                return;
            }

            if (dest.Length < 3)
	            return;

	            int adc = dest[0] & 0xff;
	            int adcMin = dest[1] & 0xff;
	            int adcMax = dest[2] & 0xff;

	            if (adcMin == adcMax)
	            {
	                adcMax += 1;
	            }

	    	if (battery > 100)
	            battery = 100;
	        else if (battery < 0)
	            battery = 0;
            
		    this.labelBattery.Text = battery.ToString() + "%";
		    this.labelPlug.Text = "Connected";
        }

        public void onSessionReceived(int session)
        {
            throw new NotImplementedException();
        }
        
        private void buttonRead_Click(object sender, EventArgs e)
        {
            if(RcpApi2.Instance.isOpened())
            {
                if (!this.displayRssi)
                {
                    RcpApi2.Instance.startReadTags(max_tag, max_time, repeat_cycle);
                }
                else
                {
                    RcpApi2.Instance.startReadTagsWithRssi(max_tag, max_time, repeat_cycle);
                }
            }
            else
            {
                MessageBox.Show("Not opened yet");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (RcpApi2.Instance.isOpened())
		    {
		        RcpApi2.Instance.stopReadTags();
		    }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetUI();
        }
        
        private void setTagCount()
        {            
            labelTags.Text = nTagCnt.ToString() + " tags";
        }
        
        private void resetUI()
        {
            nTagCnt = 0;
            setTagCount();
            listTagVO.Clear();
            this.listViewEPC.Items.Clear();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            //System.Console.WriteLine(" buttonMore_Click plugged = " + plugged);

            if (!plugged || !RcpApi2.Instance.isOpened())
            {
                MessageBox.Show("Not opened yet");
                return;
            }

            RcpApi2.Instance.stopReadTags();

            FormMore form = new FormMore();
            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X, this.Location.Y);

            form.ListTagVO = listTagVO;

            form.Show();
            this.Hide();
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if(this.toggleButton.Checked)
            {
                if(!RcpApi2.Instance.open())
                {
                    this.toggleButton.Checked = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);

                    RcpApi2.Instance.getBatteryState();
                }
            }
            else
            {
                RcpApi2.Instance.close();
                diplayPlug();
            }
        }

        private void FormAretePop2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(RcpApi2.Instance.isOpened())
            {
                RcpApi2.Instance.stopReadTags();
                RcpApi2.Instance.close();
            }            
        }

        private void listViewEPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewEPC.SelectedIndices.Count > 0 
                && this.listViewEPC.SelectedIndices[0] >= 0)
            {

                if (encoding_type == EpcConverter.HEX_STRING)
                {
                    RcpApi2.Instance.stopReadTags();

                    int sel = this.listViewEPC.SelectedIndices[0];

                    FormAccess form = new FormAccess();
                    form.Tag = this;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(this.Location.X, this.Location.Y);

                    form.Target = listTagVO[sel];

                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Not possible when encoding type is not HEX.");             
                }
            }
            this.listViewEPC.SelectedIndices.Clear();
        }

        private int getEpcStartPos(byte[] pcEpc)
        {
            int epcStart = 2;

            if ((pcEpc[0] & 0x02) == 0x02)
            {
                if ((pcEpc[0] & 0x08) == 0x08)
                {   
                    epcStart = 6; // PC + XPC_W1 + XPC_W2
                }
                else
                {
                    
                    epcStart = 4; // PC + XPC_W1
                }
            }
            
            return epcStart;
        }



        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }

    public class TagVO
    {
        private byte[] epc;
        private string timeStamp;

        public TagVO(byte[] tag, string timeStamp)
        {
            this.epc = (byte[]) tag.Clone();
            this.timeStamp = timeStamp;
        }

        public byte[] Epc
        {
            get { return epc; }
            set { epc = value; }
        }
        
        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
    }
}
