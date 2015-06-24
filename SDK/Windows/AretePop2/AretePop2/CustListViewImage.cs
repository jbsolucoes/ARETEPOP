//!-------------------------------------------------------------------
//! Copyright (C) 2015 PHYCHIPS
//!
//! @file   CustListViewImage.cs	
//! @brief 	custom listview class
//! 
//! $Id: toggleButton.cs 3549 2015-04-15 06:36:16Z jsyi $			
//!-------------------------------------------------------------------
//! History
//!-------------------------------------------------------------------
//! 2015/04/22	jsyi	initial release

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Phychips.Arete
{
    public class CustListViewImage : ListView
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        public enum ScrollBarDirection
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3
        }

        public void HideScrollBar(ScrollBarDirection type)
        {
            ShowScrollBar(this.Handle, (int)type, false);
        }

        private EventHandler<CheckIndexEventArgs> mRowChecked;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler<CheckIndexEventArgs> RowChecked
        {
            remove { mRowChecked -= value; }
            add { mRowChecked += value; }
        }

        private Image mImage;
        private int m_height = 36;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Image Image
        {
            get { return mImage; }
            set { mImage = value; }
        }
        
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int RowHeight
        {
            get { return m_height; }
            set { m_height = value;}
        }

        protected override void InitLayout()
        {
 	        base.InitLayout();

            this.Columns.Add("_", this.Size.Width, HorizontalAlignment.Left);

            ImageList imageListSmall = new ImageList();
            imageListSmall.ImageSize = new Size(1, m_height - 2);
            this.SmallImageList = imageListSmall;

            this.GridLines = true;
            this.HeaderStyle = ColumnHeaderStyle.None;
            this.OwnerDraw = true;
            this.FullRowSelect = true;
            this.View = View.Details;
            this.MultiSelect = true;
        }
                
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            //System.Console.WriteLine("OnSelectedIndexChanged");
            base.OnSelectedIndexChanged(e);

            if (this.SelectedItems.Count <= 0)
                return;

            int selectedIndex = this.SelectedIndices[0];
            if (selectedIndex >= 0)
            {
                if (this.Items[selectedIndex].Checked)
                {                    
                    //this.Items[selectedIndex].Checked = false;
                    this.Checked(selectedIndex, false);
                }
                else
                {
                    //this.Items[selectedIndex].Checked = true;
                    this.Checked(selectedIndex, true);
                }

                onRowChecked(new CheckIndexEventArgs(selectedIndex));

                this.SelectedIndices.Clear();
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            if (this.SelectedItems.Count <= 0)
                return;

            int selectedIndex = this.SelectedIndices[0];
            if (selectedIndex >= 0)
            {
                if (this.Items[selectedIndex].Checked)
                {
                    //this.Items[selectedIndex].Checked = false;
                    this.Checked(selectedIndex, false);
                }
                else
                {
                    //this.Items[selectedIndex].Checked = true;
                    this.Checked(selectedIndex, true);
                }

                onRowChecked(new CheckIndexEventArgs(selectedIndex));
            }
        }

        public void Checked(int index, bool check)
        {
            if (Items.Count - 1 < index)
                return;

            this.Items[index].Checked = check;

            this.RedrawItems(index, index, false);
        }
                
        protected void onRowChecked(CheckIndexEventArgs e)
        {
            if (mRowChecked != null)
                mRowChecked.Invoke(this, e);
        }
        
        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
            base.OnDrawColumnHeader(e);
            
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            base.OnDrawSubItem(e);
            //System.Console.WriteLine("OnDrawSubItem");

            Rectangle rec = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2 + e.Bounds.Height / 2 - e.Item.Font.Height/2 , e.Bounds.Width - 4, e.Bounds.Height - 4);
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine;
            //If a different tabstop than the default is needed, will have to p/invoke DrawTextEx from win32.
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.ListView.Font, rec, e.SubItem.ForeColor, flags);
 
            if (mImage == null || !e.Item.Checked)
                return;
            
            float ratio = (float) mImage.Height / (float) m_height;

            int height =(int)( (float)mImage.Height * ratio);
            int width = (int)( (float)mImage.Width *ratio );
            
            //e.DrawBackground();
            var imageRect = new Rectangle(e.Bounds.X + e.Bounds.Width - width - 10, e.Bounds.Y + e.Bounds.Height/2 - height/2, (int)width, (int)height);
            e.Graphics.DrawImage(mImage, imageRect);
        }
    }

    public class CheckIndexEventArgs : EventArgs
    {
        private int checkedIndex = 0;

        public int CheckedIndex
        {
            get { return checkedIndex; }            
        }

        public CheckIndexEventArgs(int index)
        {
            this.checkedIndex = index;
        }

        
    }
}
