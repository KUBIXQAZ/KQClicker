namespace KQClicker
{
    partial class Form1
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
            this.left_clicker_b = new System.Windows.Forms.Button();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.bar = new System.Windows.Forms.Panel();
            this.app_title = new System.Windows.Forms.Label();
            this.minimize_b = new System.Windows.Forms.Button();
            this.exit_b = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.left_toggle = new System.Windows.Forms.Button();
            this.display_cps_left = new System.Windows.Forms.Label();
            this.cps_left = new System.Windows.Forms.Label();
            this.bind_left = new System.Windows.Forms.Button();
            this.title_panel_left = new System.Windows.Forms.Panel();
            this.title_left = new System.Windows.Forms.Label();
            this.left_cps_trackBar = new System.Windows.Forms.TrackBar();
            this.panel_right = new System.Windows.Forms.Panel();
            this.display_cps_right = new System.Windows.Forms.Label();
            this.cps_right = new System.Windows.Forms.Label();
            this.right_cps_trackBar = new System.Windows.Forms.TrackBar();
            this.bind_right = new System.Windows.Forms.Button();
            this.title_panel_right = new System.Windows.Forms.Panel();
            this.title_right = new System.Windows.Forms.Label();
            this.right_clicker_b = new System.Windows.Forms.Button();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.right_toggle = new System.Windows.Forms.Button();
            this.bar.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.title_panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_cps_trackBar)).BeginInit();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.right_cps_trackBar)).BeginInit();
            this.title_panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_clicker_b
            // 
            this.left_clicker_b.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.left_clicker_b.FlatAppearance.BorderSize = 0;
            this.left_clicker_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_clicker_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.left_clicker_b.Location = new System.Drawing.Point(34, 111);
            this.left_clicker_b.Name = "left_clicker_b";
            this.left_clicker_b.Size = new System.Drawing.Size(191, 31);
            this.left_clicker_b.TabIndex = 0;
            this.left_clicker_b.TabStop = false;
            this.left_clicker_b.Text = "DISABLED";
            this.left_clicker_b.UseVisualStyleBackColor = false;
            this.left_clicker_b.Click += new System.EventHandler(this.left_clicker_b_click);
            // 
            // LeftClicker
            // 
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bar.Controls.Add(this.app_title);
            this.bar.Controls.Add(this.minimize_b);
            this.bar.Controls.Add(this.exit_b);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(676, 39);
            this.bar.TabIndex = 2;
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold);
            this.app_title.Location = new System.Drawing.Point(12, 6);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(92, 25);
            this.app_title.TabIndex = 2;
            this.app_title.Text = "KQClicker";
            // 
            // minimize_b
            // 
            this.minimize_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_b.FlatAppearance.BorderSize = 0;
            this.minimize_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_b.Location = new System.Drawing.Point(628, 12);
            this.minimize_b.Name = "minimize_b";
            this.minimize_b.Size = new System.Drawing.Size(15, 15);
            this.minimize_b.TabIndex = 1;
            this.minimize_b.TabStop = false;
            this.minimize_b.UseVisualStyleBackColor = false;
            this.minimize_b.Click += new System.EventHandler(this.minimize_b_Click);
            // 
            // exit_b
            // 
            this.exit_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_b.FlatAppearance.BorderSize = 0;
            this.exit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_b.Location = new System.Drawing.Point(649, 12);
            this.exit_b.Name = "exit_b";
            this.exit_b.Size = new System.Drawing.Size(15, 15);
            this.exit_b.TabIndex = 0;
            this.exit_b.TabStop = false;
            this.exit_b.UseVisualStyleBackColor = false;
            this.exit_b.Click += new System.EventHandler(this.exit_b_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_left.Controls.Add(this.left_toggle);
            this.panel_left.Controls.Add(this.display_cps_left);
            this.panel_left.Controls.Add(this.cps_left);
            this.panel_left.Controls.Add(this.bind_left);
            this.panel_left.Controls.Add(this.title_panel_left);
            this.panel_left.Controls.Add(this.left_cps_trackBar);
            this.panel_left.Controls.Add(this.left_clicker_b);
            this.panel_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_left.Location = new System.Drawing.Point(19, 54);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(638, 175);
            this.panel_left.TabIndex = 3;
            // 
            // left_toggle
            // 
            this.left_toggle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.left_toggle.FlatAppearance.BorderSize = 0;
            this.left_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.left_toggle.Location = new System.Drawing.Point(231, 111);
            this.left_toggle.Name = "left_toggle";
            this.left_toggle.Size = new System.Drawing.Size(174, 31);
            this.left_toggle.TabIndex = 15;
            this.left_toggle.TabStop = false;
            this.left_toggle.Text = "HOLD";
            this.left_toggle.UseVisualStyleBackColor = false;
            this.left_toggle.Click += new System.EventHandler(this.left_toggle_Click);
            // 
            // display_cps_left
            // 
            this.display_cps_left.AutoSize = true;
            this.display_cps_left.Location = new System.Drawing.Point(580, 59);
            this.display_cps_left.Name = "display_cps_left";
            this.display_cps_left.Size = new System.Drawing.Size(30, 22);
            this.display_cps_left.TabIndex = 14;
            this.display_cps_left.Text = "10";
            // 
            // cps_left
            // 
            this.cps_left.AutoSize = true;
            this.cps_left.Location = new System.Drawing.Point(30, 62);
            this.cps_left.Name = "cps_left";
            this.cps_left.Size = new System.Drawing.Size(210, 22);
            this.cps_left.TabIndex = 13;
            this.cps_left.Text = "CPS - Clicks Per Second";
            // 
            // bind_left
            // 
            this.bind_left.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bind_left.FlatAppearance.BorderSize = 0;
            this.bind_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bind_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bind_left.Location = new System.Drawing.Point(411, 111);
            this.bind_left.Name = "bind_left";
            this.bind_left.Size = new System.Drawing.Size(191, 31);
            this.bind_left.TabIndex = 11;
            this.bind_left.TabStop = false;
            this.bind_left.Text = "BIND: R+LMB";
            this.bind_left.UseVisualStyleBackColor = false;
            this.bind_left.Click += new System.EventHandler(this.bind_left_Click);
            this.bind_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bind_left_KeyDown);
            // 
            // title_panel_left
            // 
            this.title_panel_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_panel_left.Controls.Add(this.title_left);
            this.title_panel_left.Location = new System.Drawing.Point(0, 0);
            this.title_panel_left.Name = "title_panel_left";
            this.title_panel_left.Size = new System.Drawing.Size(638, 39);
            this.title_panel_left.TabIndex = 5;
            // 
            // title_left
            // 
            this.title_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_left.Location = new System.Drawing.Point(3, 4);
            this.title_left.Name = "title_left";
            this.title_left.Size = new System.Drawing.Size(147, 31);
            this.title_left.TabIndex = 4;
            this.title_left.Text = "LEFT MB";
            // 
            // left_cps_trackBar
            // 
            this.left_cps_trackBar.AutoSize = false;
            this.left_cps_trackBar.Location = new System.Drawing.Point(25, 81);
            this.left_cps_trackBar.Maximum = 50;
            this.left_cps_trackBar.Minimum = 1;
            this.left_cps_trackBar.Name = "left_cps_trackBar";
            this.left_cps_trackBar.Size = new System.Drawing.Size(585, 24);
            this.left_cps_trackBar.TabIndex = 0;
            this.left_cps_trackBar.TabStop = false;
            this.left_cps_trackBar.TickFrequency = 0;
            this.left_cps_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.left_cps_trackBar.Value = 10;
            this.left_cps_trackBar.Scroll += new System.EventHandler(this.left_cps_trackBar_Scroll);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_right.Controls.Add(this.right_toggle);
            this.panel_right.Controls.Add(this.display_cps_right);
            this.panel_right.Controls.Add(this.cps_right);
            this.panel_right.Controls.Add(this.right_cps_trackBar);
            this.panel_right.Controls.Add(this.bind_right);
            this.panel_right.Controls.Add(this.title_panel_right);
            this.panel_right.Controls.Add(this.right_clicker_b);
            this.panel_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_right.Location = new System.Drawing.Point(19, 244);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(638, 175);
            this.panel_right.TabIndex = 11;
            // 
            // display_cps_right
            // 
            this.display_cps_right.AutoSize = true;
            this.display_cps_right.Location = new System.Drawing.Point(580, 59);
            this.display_cps_right.Name = "display_cps_right";
            this.display_cps_right.Size = new System.Drawing.Size(30, 22);
            this.display_cps_right.TabIndex = 15;
            this.display_cps_right.Text = "30";
            // 
            // cps_right
            // 
            this.cps_right.AutoSize = true;
            this.cps_right.Location = new System.Drawing.Point(30, 62);
            this.cps_right.Name = "cps_right";
            this.cps_right.Size = new System.Drawing.Size(210, 22);
            this.cps_right.TabIndex = 16;
            this.cps_right.Text = "CPS - Clicks Per Second";
            // 
            // right_cps_trackBar
            // 
            this.right_cps_trackBar.AutoSize = false;
            this.right_cps_trackBar.Location = new System.Drawing.Point(25, 81);
            this.right_cps_trackBar.Maximum = 50;
            this.right_cps_trackBar.Minimum = 1;
            this.right_cps_trackBar.Name = "right_cps_trackBar";
            this.right_cps_trackBar.Size = new System.Drawing.Size(585, 24);
            this.right_cps_trackBar.TabIndex = 15;
            this.right_cps_trackBar.TabStop = false;
            this.right_cps_trackBar.TickFrequency = 0;
            this.right_cps_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.right_cps_trackBar.Value = 30;
            this.right_cps_trackBar.Scroll += new System.EventHandler(this.right_cps_trackBar_Scroll);
            // 
            // bind_right
            // 
            this.bind_right.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bind_right.FlatAppearance.BorderSize = 0;
            this.bind_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bind_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bind_right.Location = new System.Drawing.Point(411, 111);
            this.bind_right.Name = "bind_right";
            this.bind_right.Size = new System.Drawing.Size(193, 31);
            this.bind_right.TabIndex = 12;
            this.bind_right.TabStop = false;
            this.bind_right.Text = "BIND: F+LMB";
            this.bind_right.UseVisualStyleBackColor = false;
            this.bind_right.Click += new System.EventHandler(this.bind_right_Click);
            this.bind_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bind_right_KeyDown);
            // 
            // title_panel_right
            // 
            this.title_panel_right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_panel_right.Controls.Add(this.title_right);
            this.title_panel_right.Location = new System.Drawing.Point(0, 0);
            this.title_panel_right.Name = "title_panel_right";
            this.title_panel_right.Size = new System.Drawing.Size(638, 39);
            this.title_panel_right.TabIndex = 5;
            // 
            // title_right
            // 
            this.title_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_right.Location = new System.Drawing.Point(3, 4);
            this.title_right.Name = "title_right";
            this.title_right.Size = new System.Drawing.Size(147, 31);
            this.title_right.TabIndex = 4;
            this.title_right.Text = "RIGHT MB";
            // 
            // right_clicker_b
            // 
            this.right_clicker_b.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.right_clicker_b.FlatAppearance.BorderSize = 0;
            this.right_clicker_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_clicker_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.right_clicker_b.Location = new System.Drawing.Point(34, 111);
            this.right_clicker_b.Name = "right_clicker_b";
            this.right_clicker_b.Size = new System.Drawing.Size(191, 31);
            this.right_clicker_b.TabIndex = 0;
            this.right_clicker_b.TabStop = false;
            this.right_clicker_b.Text = "DISABLED";
            this.right_clicker_b.UseVisualStyleBackColor = false;
            this.right_clicker_b.Click += new System.EventHandler(this.right_clicker_b_Click_1);
            // 
            // RightClicker
            // 
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // right_toggle
            // 
            this.right_toggle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.right_toggle.FlatAppearance.BorderSize = 0;
            this.right_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.right_toggle.Location = new System.Drawing.Point(231, 111);
            this.right_toggle.Name = "right_toggle";
            this.right_toggle.Size = new System.Drawing.Size(174, 31);
            this.right_toggle.TabIndex = 16;
            this.right_toggle.TabStop = false;
            this.right_toggle.Text = "HOLD";
            this.right_toggle.UseVisualStyleBackColor = false;
            this.right_toggle.Click += new System.EventHandler(this.right_toggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 438);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.title_panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_cps_trackBar)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.right_cps_trackBar)).EndInit();
            this.title_panel_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button left_clicker_b;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Button minimize_b;
        private System.Windows.Forms.Button exit_b;
        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label title_left;
        private System.Windows.Forms.Panel title_panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel title_panel_right;
        private System.Windows.Forms.Label title_right;
        private System.Windows.Forms.Button right_clicker_b;
        private System.Windows.Forms.Timer RightClicker;
        private System.Windows.Forms.Button bind_left;
        private System.Windows.Forms.Button bind_right;
        private System.Windows.Forms.TrackBar left_cps_trackBar;
        private System.Windows.Forms.Label cps_left;
        private System.Windows.Forms.Label display_cps_left;
        private System.Windows.Forms.Label cps_right;
        private System.Windows.Forms.TrackBar right_cps_trackBar;
        private System.Windows.Forms.Label display_cps_right;
        private System.Windows.Forms.Button left_toggle;
        private System.Windows.Forms.Button right_toggle;
    }
}

