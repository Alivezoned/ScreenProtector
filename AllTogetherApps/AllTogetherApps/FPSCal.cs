using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTogetherApps
{
    public partial class FPSCal : Form
    {

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;
        private Timer nTimer = new Timer();

        public FPSCal()
        {
            InitializeComponent();
            nTimer.Tick += DisplayTimeEvent;
            nTimer.Interval = 100; // 1000 ms is one second
            nTimer.Start();
        }

        public void DisplayTimeEvent(object source, EventArgs e)
        {
            label1.Text = CalculateFrameRate().ToString();
        }

        private void FPSCal_Load(object sender, EventArgs e)
        {
            label1.Text = CalculateFrameRate().ToString();
        }


        public static int CalculateFrameRate()
        {  
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }
    }
}
