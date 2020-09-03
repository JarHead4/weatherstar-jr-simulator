using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Timers;
using System.Windows.Forms;

namespace WSJR_sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
         
        private void Wait_Tick(object sender, EventArgs e)
            {
                LabelDate.Text = DateTime.Now.ToString("ddd MMM dd"); //display date
                LabelTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); //display time
            }

        private void LDL_Click(object sender, EventArgs e)
        {
            Form sim = new Form2();
            Form frm1 = new Form1();
            sim.Owner = this;
            sim.Show();
            frm1.Close();//load simulation
        }
    }

    }


