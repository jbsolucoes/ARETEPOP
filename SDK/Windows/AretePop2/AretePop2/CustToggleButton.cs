//!-------------------------------------------------------------------
//! Copyright (C) 2015 PHYCHIPS
//!
//! @file   toggleButton.cs	
//! @brief 	custom toggle button class
//! 
//! $Id: toggleButton.cs 3549 2015-04-15 06:36:16Z jsyi $			
//!-------------------------------------------------------------------
//! History
//!-------------------------------------------------------------------
//! 2015/04/15	jsyi	initial release

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phychips.Arete
{
    public class CustToggleButton : Button
    {
        private bool mChecked = false;
        private Image imageOn = Phychips.Arete.Properties.Resources.toggle_switch_on;
        private Image imageOff = Phychips.Arete.Properties.Resources.toggle_switch_off;

        [Category("Property Changed")]                
        public bool Checked
        {
            get { return mChecked; }
            set 
            { 
                mChecked = value;
                if (mChecked)
                {
                    this.BackgroundImage = imageOn;
                }
                else
                {
                    this.BackgroundImage = imageOff;
                }
            }
        }

        protected override void InitLayout()
        {            
            base.InitLayout();
            this.Text = "";
            this.Size = new Size(imageOn.Width, imageOn.Height);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundImage = imageOff;
            this.BackgroundImageLayout = ImageLayout.Center;
            //this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {   
            base.OnResize(e);
            this.Size = new Size(imageOn.Width, imageOn.Height);            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Text = "";
        }


        protected override void OnClick(EventArgs e)
        {   
            if (!mChecked)
            {
                this.Checked = true;
                //this.BackgroundImage = imageOn;
            }
            else
            {
                this.Checked = false;
                //this.BackgroundImage = imageOff;
            }
            base.OnClick(e);
        }
    }
}
