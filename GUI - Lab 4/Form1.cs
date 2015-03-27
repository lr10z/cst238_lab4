using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Lab_4
{
    public partial class Form1 : Form
    {
        private PictureBox pict;
        private DateTime timeOfDay;
        private string time;
        private int[] digits;

        public Form1()
        {
            InitializeComponent();
            pict = new PictureBox();
            numberGenerator = new Random();
            digits = new int[4];

            setupLED();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //get the current time every 4 seconds
            timeOfDay = DateTime.Now;
            time = timeOfDay.Hour.ToString("00") + timeOfDay.Minute.ToString("00");
            digits = time.Select(x => int.Parse(x.ToString())).ToArray();

            clearLED();
            lightLED();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the time
            timeOfDay = DateTime.Now;
            time = timeOfDay.Hour.ToString("00") + timeOfDay.Minute.ToString("00");
            digits = time.Select(x => int.Parse(x.ToString())).ToArray();
            
            lightLED();
        }
    }
}
