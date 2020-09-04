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
            LDL.Text = LDL.Text.Substring(1, LDL.Text.Length - 1) + LDL.Text.Substring(0, 1);
        }

        private void LDL_Click(object sender, EventArgs e)
        {
            Form sim = new Form2();
            Form frm1 = new Form1();
            sim.Owner = this;
            sim.Show();
            frm1.Close();//load simulation
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form set1 = new Settings.City();
            set1.Owner = this;
            set1.Show();
        }
    }

    }


