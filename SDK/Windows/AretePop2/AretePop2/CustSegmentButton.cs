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
    public class CustSegButton : Button
    {
        private bool mChecked = false;
        
        [Category("Property Changed")]                
        public bool Checked
        {
            get { return mChecked; }
            set 
            { 
                mChecked = value;
                if (mChecked)
                {
                    this.BackColor = Color.FromArgb(4, 131, 255);
                    this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                }
                else
                {
                    this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    this.ForeColor = Color.FromArgb(4, 131, 255);
                }
            }
        }

        protected override void InitLayout()
        {            
            base.InitLayout();
            
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.FromArgb(4, 131, 255);
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        /*
        protected override void OnClick(EventArgs e)
        {   
            if (!mChecked)
            {
                this.Checked = true;
                //this.BackgroundImage = imageOn;
            }
            //else
            //{
            //    this.Checked = false;
            //    //this.BackgroundImage = imageOff;
            //}
            base.OnClick(e);
        }
        */
    }
}
