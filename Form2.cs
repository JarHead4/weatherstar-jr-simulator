using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSJR_sim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Wait_Tick(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToString("ddd MMM dd"); //display date
            LabelTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); //display time
        }
    }
}
