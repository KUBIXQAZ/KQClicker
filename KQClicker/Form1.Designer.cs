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
            this.exit_b = new System.Windows.Forms.Button();
            this.minimize_b = new System.Windows.Forms.Button();
            this.app_title = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.cps_left_title = new System.Windows.Forms.Label();
            this.left_toggle = new System.Windows.Forms.Button();
            this.display_cps_left = new System.Windows.Forms.Label();
            this.bind_left = new System.Windows.Forms.Button();
            this.title_panel_left = new System.Windows.Forms.Panel();
            this.title_left = new System.Windows.Forms.Label();
            this.left_cps_trackBar = new System.Windows.Forms.TrackBar();
            this.conf_panel = new System.Windows.Forms.Panel();
            this.panel_advanced = new System.Windows.Forms.Panel();
            this.auto_turnonoff_clicker_b_r = new System.Windows.Forms.Button();
            this.auto_turnonoff_clicker_b_l = new System.Windows.Forms.Button();
            this.advanced2_right_text = new System.Windows.Forms.Label();
            this.advanced2_left_text = new System.Windows.Forms.Label();
            this.advanced_settings_title_1 = new System.Windows.Forms.Label();
            this.title_panel_advanced = new System.Windows.Forms.Panel();
            this.title_advanced = new System.Windows.Forms.Label();
            this.panel_simple = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.right_toggle = new System.Windows.Forms.Button();
            this.display_cps_right = new System.Windows.Forms.Label();
            this.cps_right_title = new System.Windows.Forms.Label();
            this.right_cps_trackBar = new System.Windows.Forms.TrackBar();
            this.bind_right = new System.Windows.Forms.Button();
            this.title_panel_right = new System.Windows.Forms.Panel();
            this.title_right = new System.Windows.Forms.Label();
            this.right_clicker_b = new System.Windows.Forms.Button();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.conf_clicker = new System.Windows.Forms.Button();
            this.bar.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.title_panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_cps_trackBar)).BeginInit();
            this.conf_panel.SuspendLayout();
            this.panel_advanced.SuspendLayout();
            this.title_panel_advanced.SuspendLayout();
            this.panel_simple.SuspendLayout();
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
            this.bar.Controls.Add(this.exit_b);
            this.bar.Controls.Add(this.minimize_b);
            this.bar.Controls.Add(this.app_title);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(676, 39);
            this.bar.TabIndex = 2;
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
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_left.Controls.Add(this.cps_left_title);
            this.panel_left.Controls.Add(this.left_toggle);
            this.panel_left.Controls.Add(this.display_cps_left);
            this.panel_left.Controls.Add(this.bind_left);
            this.panel_left.Controls.Add(this.title_panel_left);
            this.panel_left.Controls.Add(this.left_cps_trackBar);
            this.panel_left.Controls.Add(this.left_clicker_b);
            this.panel_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_left.Location = new System.Drawing.Point(19, 16);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(638, 175);
            this.panel_left.TabIndex = 3;
            // 
            // cps_left_title
            // 
            this.cps_left_title.AutoSize = true;
            this.cps_left_title.Location = new System.Drawing.Point(30, 62);
            this.cps_left_title.Name = "cps_left_title";
            this.cps_left_title.Size = new System.Drawing.Size(210, 22);
            this.cps_left_title.TabIndex = 17;
            this.cps_left_title.Text = "CPS - Clicks Per Second";
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
            this.left_toggle.Text = "TOGGLE";
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
            // conf_panel
            // 
            this.conf_panel.Controls.Add(this.panel_advanced);
            this.conf_panel.Enabled = false;
            this.conf_panel.Location = new System.Drawing.Point(0, 0);
            this.conf_panel.Name = "conf_panel";
            this.conf_panel.Size = new System.Drawing.Size(676, 389);
            this.conf_panel.TabIndex = 16;
            this.conf_panel.Visible = false;
            // 
            // panel_advanced
            // 
            this.panel_advanced.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_advanced.Controls.Add(this.auto_turnonoff_clicker_b_r);
            this.panel_advanced.Controls.Add(this.auto_turnonoff_clicker_b_l);
            this.panel_advanced.Controls.Add(this.advanced2_right_text);
            this.panel_advanced.Controls.Add(this.advanced2_left_text);
            this.panel_advanced.Controls.Add(this.advanced_settings_title_1);
            this.panel_advanced.Controls.Add(this.title_panel_advanced);
            this.panel_advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_advanced.Location = new System.Drawing.Point(20, 16);
            this.panel_advanced.Name = "panel_advanced";
            this.panel_advanced.Size = new System.Drawing.Size(638, 365);
            this.panel_advanced.TabIndex = 16;
            // 
            // auto_turnonoff_clicker_b_r
            // 
            this.auto_turnonoff_clicker_b_r.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.auto_turnonoff_clicker_b_r.FlatAppearance.BorderSize = 0;
            this.auto_turnonoff_clicker_b_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_turnonoff_clicker_b_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.auto_turnonoff_clicker_b_r.Location = new System.Drawing.Point(20, 155);
            this.auto_turnonoff_clicker_b_r.Name = "auto_turnonoff_clicker_b_r";
            this.auto_turnonoff_clicker_b_r.Size = new System.Drawing.Size(136, 28);
            this.auto_turnonoff_clicker_b_r.TabIndex = 17;
            this.auto_turnonoff_clicker_b_r.TabStop = false;
            this.auto_turnonoff_clicker_b_r.Text = "DISABLED";
            this.auto_turnonoff_clicker_b_r.UseVisualStyleBackColor = false;
            this.auto_turnonoff_clicker_b_r.Click += new System.EventHandler(this.auto_turnonoff_clicker_b_r_Click);
            // 
            // auto_turnonoff_clicker_b_l
            // 
            this.auto_turnonoff_clicker_b_l.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.auto_turnonoff_clicker_b_l.FlatAppearance.BorderSize = 0;
            this.auto_turnonoff_clicker_b_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_turnonoff_clicker_b_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.auto_turnonoff_clicker_b_l.Location = new System.Drawing.Point(20, 121);
            this.auto_turnonoff_clicker_b_l.Name = "auto_turnonoff_clicker_b_l";
            this.auto_turnonoff_clicker_b_l.Size = new System.Drawing.Size(136, 28);
            this.auto_turnonoff_clicker_b_l.TabIndex = 16;
            this.auto_turnonoff_clicker_b_l.TabStop = false;
            this.auto_turnonoff_clicker_b_l.Text = "DISABLED";
            this.auto_turnonoff_clicker_b_l.UseVisualStyleBackColor = false;
            this.auto_turnonoff_clicker_b_l.Click += new System.EventHandler(this.auto_turnonoff_clicker_b_l_Click);
            // 
            // advanced2_right_text
            // 
            this.advanced2_right_text.AutoSize = true;
            this.advanced2_right_text.Location = new System.Drawing.Point(157, 159);
            this.advanced2_right_text.Name = "advanced2_right_text";
            this.advanced2_right_text.Size = new System.Drawing.Size(66, 22);
            this.advanced2_right_text.TabIndex = 19;
            this.advanced2_right_text.Text = "RIGHT";
            // 
            // advanced2_left_text
            // 
            this.advanced2_left_text.AutoSize = true;
            this.advanced2_left_text.Location = new System.Drawing.Point(157, 126);
            this.advanced2_left_text.Name = "advanced2_left_text";
            this.advanced2_left_text.Size = new System.Drawing.Size(55, 22);
            this.advanced2_left_text.TabIndex = 18;
            this.advanced2_left_text.Text = "LEFT";
            // 
            // advanced_settings_title_1
            // 
            this.advanced_settings_title_1.AutoSize = true;
            this.advanced_settings_title_1.Location = new System.Drawing.Point(20, 96);
            this.advanced_settings_title_1.Name = "advanced_settings_title_1";
            this.advanced_settings_title_1.Size = new System.Drawing.Size(231, 22);
            this.advanced_settings_title_1.TabIndex = 12;
            this.advanced_settings_title_1.Text = "AUTO TURN ON CLICKER";
            // 
            // title_panel_advanced
            // 
            this.title_panel_advanced.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_panel_advanced.Controls.Add(this.title_advanced);
            this.title_panel_advanced.Location = new System.Drawing.Point(0, 0);
            this.title_panel_advanced.Name = "title_panel_advanced";
            this.title_panel_advanced.Size = new System.Drawing.Size(638, 39);
            this.title_panel_advanced.TabIndex = 6;
            // 
            // title_advanced
            // 
            this.title_advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_advanced.Location = new System.Drawing.Point(3, 4);
            this.title_advanced.Name = "title_advanced";
            this.title_advanced.Size = new System.Drawing.Size(172, 31);
            this.title_advanced.TabIndex = 4;
            this.title_advanced.Text = "ADVANCED";
            // 
            // panel_simple
            // 
            this.panel_simple.Controls.Add(this.conf_panel);
            this.panel_simple.Controls.Add(this.panel_left);
            this.panel_simple.Controls.Add(this.panel_right);
            this.panel_simple.Location = new System.Drawing.Point(0, 38);
            this.panel_simple.Name = "panel_simple";
            this.panel_simple.Size = new System.Drawing.Size(676, 389);
            this.panel_simple.TabIndex = 17;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_right.Controls.Add(this.right_toggle);
            this.panel_right.Controls.Add(this.display_cps_right);
            this.panel_right.Controls.Add(this.cps_right_title);
            this.panel_right.Controls.Add(this.right_cps_trackBar);
            this.panel_right.Controls.Add(this.bind_right);
            this.panel_right.Controls.Add(this.title_panel_right);
            this.panel_right.Controls.Add(this.right_clicker_b);
            this.panel_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_right.Location = new System.Drawing.Point(19, 206);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(638, 175);
            this.panel_right.TabIndex = 11;
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
            this.right_toggle.Text = "TOGGLE";
            this.right_toggle.UseVisualStyleBackColor = false;
            this.right_toggle.Click += new System.EventHandler(this.right_toggle_Click);
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
            // cps_right_title
            // 
            this.cps_right_title.AutoSize = true;
            this.cps_right_title.Location = new System.Drawing.Point(30, 62);
            this.cps_right_title.Name = "cps_right_title";
            this.cps_right_title.Size = new System.Drawing.Size(210, 22);
            this.cps_right_title.TabIndex = 16;
            this.cps_right_title.Text = "CPS - Clicks Per Second";
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
            this.bind_right.Text = "BIND: F+RMB";
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
            // conf_clicker
            // 
            this.conf_clicker.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.conf_clicker.FlatAppearance.BorderSize = 0;
            this.conf_clicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conf_clicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.conf_clicker.Location = new System.Drawing.Point(19, 433);
            this.conf_clicker.Name = "conf_clicker";
            this.conf_clicker.Size = new System.Drawing.Size(638, 31);
            this.conf_clicker.TabIndex = 16;
            this.conf_clicker.TabStop = false;
            this.conf_clicker.Text = "CONFIGURE CLICKER";
            this.conf_clicker.UseVisualStyleBackColor = false;
            this.conf_clicker.Click += new System.EventHandler(this.conf_clicker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.panel_simple);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.conf_clicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.title_panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_cps_trackBar)).EndInit();
            this.conf_panel.ResumeLayout(false);
            this.panel_advanced.ResumeLayout(false);
            this.panel_advanced.PerformLayout();
            this.title_panel_advanced.ResumeLayout(false);
            this.panel_simple.ResumeLayout(false);
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
        private System.Windows.Forms.Label display_cps_left;
        private System.Windows.Forms.Label cps_right_title;
        private System.Windows.Forms.TrackBar right_cps_trackBar;
        private System.Windows.Forms.Label display_cps_right;
        private System.Windows.Forms.Button left_toggle;
        private System.Windows.Forms.Button right_toggle;
        private System.Windows.Forms.Button conf_clicker;
        private System.Windows.Forms.Panel conf_panel;
        private System.Windows.Forms.Panel title_panel_advanced;
        private System.Windows.Forms.Label title_advanced;
        private System.Windows.Forms.Panel panel_advanced;
        private System.Windows.Forms.Panel panel_simple;
        private System.Windows.Forms.Label advanced_settings_title_1;
        private System.Windows.Forms.Button auto_turnonoff_clicker_b_r;
        private System.Windows.Forms.Button auto_turnonoff_clicker_b_l;
        private System.Windows.Forms.Label advanced2_right_text;
        private System.Windows.Forms.Label advanced2_left_text;
        private System.Windows.Forms.Label cps_left_title;
    }
}

