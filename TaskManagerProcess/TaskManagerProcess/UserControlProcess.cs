using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManagerProcess
{
    public partial class UserControlProcess : UserControl
    {
        public UserControlProcess()
        {
            InitializeComponent();
        }
        public void GetProcess()
        {

        }
        public void SetProcess(Process pr)
        {
            txtProcessName.Text = pr.ProcessName;
            //var x=Icon.ExtractAssociatedIcon(pr.MainModule.FileName);
            //iconProcess.DrawToBitmap( x.ToBitmap(),new Rectangle(iconProcess.Location,iconProcess.Size));
            
        }


    }
}
