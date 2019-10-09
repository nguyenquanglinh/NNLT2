using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listprocess = Process.GetProcesses();
            userControlProcess1.SetProcess(Listprocess[0]);
            MessageBox.Show("" + Listprocess[0].NonpagedSystemMemorySize64.ToString());
        }
        Process[] Listprocess;
        void GetProcess()
        {
            listView1.View = View.Details;
            Listprocess = Process.GetProcesses();
            listView1.Items.Clear();
            foreach (var pr in Listprocess)
            {
                try
                {
                    var listProces = new ListViewItem() { Text = pr.ProcessName };
                    //listProces.SubItems.Add(new ListViewItem.ListViewSubItem() {  });
                    listView1.Items.Add(listProces);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("can not convert name process: " + ex);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Listprocess.Length != Process.GetProcesses().Length)
                GetProcess();
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("listView1_Click");
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MessageBox.Show("listView1_ColumnClick");
        }
    }
}
