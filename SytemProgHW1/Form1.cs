using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SytemProgHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processesAll_Click(object sender, EventArgs e)
        {
            foreach (Process item in Process.GetProcesses())
            {
                ListViewItem lvi = new ListViewItem();
                //выводим на экран Id и Name запущенных процессов
                //lvi.Add(item.Id.ToString()+ "; "+item.ProcessName.ToString());
                lvi.Text = "ID процесса: "+item.Id.ToString()+"; Имя процесса: "+item.ProcessName.ToString();
                listView1.Items.Add(lvi);
            }
           
        }
    }
}
