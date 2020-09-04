using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSJR_sim.Settings
{
    public partial class City : Form
    {
        public City()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string text = "An ASOS ID tells the program which airport weather station it should connect to for the weather data. Go on WeatherUnderground to choose the ASOS ID closest to you. WU personal weather stations WILL NOT work.";
            MessageBox.Show(text, "ASOS ID Help");
        }
    }
}
