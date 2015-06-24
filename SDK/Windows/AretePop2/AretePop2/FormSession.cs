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
    public partial class FormSession : Form, IRcpEvent2
    {
        private int prevCheckedIndex = -1;

        public FormSession()
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
            RcpApi2.Instance.setOnRcpEventListener(this);
            RcpApi2.Instance.getSession();
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
            RcpApi2.Instance.setSession(prevCheckedIndex);
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
            if (session >= this.custListViewImage1.Items.Count)
                return;

            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    onSessionReceived(session);
                }));
                return;
            }

            this.custListViewImage1.Items[session].Checked = true;
            prevCheckedIndex = session;
        }






        public void onGenericTransportReceived(int bitLength, byte[] dest)
        {
            throw new NotImplementedException();
        }
    }
}
