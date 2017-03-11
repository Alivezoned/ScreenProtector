using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTogetherApps.Apps
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            timer1.Start();

            panel_bottom.BackColor = Color.FromArgb(30,30,30);
            panel_right.BackColor = Color.FromArgb(30,30,30);
        }

        private System.Drawing.Point MouseDownLocation;
        private System.Drawing.Point RightPanel;
        private System.Drawing.Point BottomPanel;

        private Boolean ShowOnTop = false;

        //------------------------------------------------------------
        // Right Form Drag MouseDown
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                RightPanel = e.Location;
            }
        }

        // Right Form Drag MouseMove
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Width > 200)
                {
                    this.Width = e.X + this.Right - this.Left;
                    txt_width.Text = this.Width.ToString();
                }
            }
        }

        // Bottom Form Drag MouseDown
        private void panel_bottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                BottomPanel = e.Location;
            }
        }
        // Bottom Form Drag MouseMove
        private void panel_bottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Height > 230)
                {
                    this.Height = e.Y + this.Bottom - this.Top;
                    txt_height.Text = this.Height.ToString();
                }
            }
        }



        //-------------------------------------------------------------


        // Move Form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        // Move Form
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        // Minimise Application Button
        private void btn_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Close Application Button
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Shows Form on Top
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width < 200)
            {
                this.Width = 210;
            }

            if (this.Height < 250)
            {
                this.Height = 260;
            }

            if (ShowOnTop)
            {
                this.TopMost = true;
                btn_showontop.BackColor = Color.FromArgb(70, 200, 70);
                btn_showontop.ForeColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                this.TopMost = false;
                btn_showontop.BackColor = Color.FromArgb(200, 70, 70);
                btn_showontop.ForeColor = Color.FromArgb(20, 20, 20);
            }
        }

        private void btn_showontop_Click(object sender, EventArgs e)
        {
            if (ShowOnTop)
            {
                ShowOnTop = false;
            }
            else
            {
                ShowOnTop = true;
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                String h = txt_height.Text.ToString().Trim();
                String w = txt_width.Text.ToString().Trim();

                int height = int.Parse(h);
                int width = int.Parse(w);

                if (height > 250 && height < 760)
                {
                    this.Height = height;
                }

                if (width > 250 && width < 1360)
                {
                    this.Width = width;
                }
                
            }
            catch (Exception ex)
            {
            }
        }




    }
}
