namespace AllTogetherApps.Apps
{
    partial class Background
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimise = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_showontop = new System.Windows.Forms.Button();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_minimise);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 21);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_minimise
            // 
            this.btn_minimise.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_minimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimise.Location = new System.Drawing.Point(231, 0);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Size = new System.Drawing.Size(27, 21);
            this.btn_minimise.TabIndex = 2;
            this.btn_minimise.Text = "--";
            this.btn_minimise.UseVisualStyleBackColor = false;
            this.btn_minimise.Click += new System.EventHandler(this.btn_minimise_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(258, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 21);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_showontop
            // 
            this.btn_showontop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showontop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showontop.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_showontop.Location = new System.Drawing.Point(12, 27);
            this.btn_showontop.Name = "btn_showontop";
            this.btn_showontop.Size = new System.Drawing.Size(97, 23);
            this.btn_showontop.TabIndex = 1;
            this.btn_showontop.Text = "Show On Top";
            this.btn_showontop.UseVisualStyleBackColor = false;
            this.btn_showontop.Click += new System.EventHandler(this.btn_showontop_Click);
            // 
            // txt_width
            // 
            this.txt_width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_width.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_width.Location = new System.Drawing.Point(12, 106);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 20);
            this.txt_width.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // txt_height
            // 
            this.txt_height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_height.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_height.Location = new System.Drawing.Point(12, 161);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 20);
            this.txt_height.TabIndex = 4;
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.ForeColor = System.Drawing.Color.Gray;
            this.btn_set.Location = new System.Drawing.Point(12, 187);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(100, 23);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(264, 21);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(25, 267);
            this.panel_right.TabIndex = 7;
            this.panel_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel_right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 265);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(264, 23);
            this.panel_bottom.TabIndex = 8;
            this.panel_bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_bottom_MouseDown);
            this.panel_bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_bottom_MouseMove);
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(289, 288);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.btn_showontop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Background";
            this.Text = "Background";
            this.Load += new System.EventHandler(this.Background_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimise;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_showontop;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_bottom;
    }
}