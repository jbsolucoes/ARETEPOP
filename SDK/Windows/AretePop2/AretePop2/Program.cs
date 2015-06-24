//!
//! Description
//! 	ARETE POP2 DEMO
//!-------------------------------------------------------------------
//! History
//!-------------------------------------------------------------------
//! 0.1	2015/05/04	Jinsung Yi		Initial Release

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Phychips.Arete
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Thread.CurrentThread.Name == null)
            {
                Thread.CurrentThread.Name = "MainThread";
            }

            Application.Run(new FormAretePop2());
        }
    }
}