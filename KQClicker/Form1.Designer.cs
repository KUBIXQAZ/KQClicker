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
            this.max_random_left = new System.Windows.Forms.TextBox();
            this.min_random_left = new System.Windows.Forms.TextBox();
            this.left_type = new System.Windows.Forms.Button();
            this.title_panel_left = new System.Windows.Forms.Panel();
            this.title_left = new System.Windows.Forms.Label();
            this.cps_input_left = new System.Windows.Forms.TextBox();
            this.cps_left = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.max_random_right = new System.Windows.Forms.TextBox();
            this.min_random_right = new System.Windows.Forms.TextBox();
            this.right_type = new System.Windows.Forms.Button();
            this.title_panel_right = new System.Windows.Forms.Panel();
            this.title_right = new System.Windows.Forms.Label();
            this.cps_input_right = new System.Windows.Forms.TextBox();
            this.cps_right = new System.Windows.Forms.Label();
            this.right_clicker_b = new System.Windows.Forms.Button();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.bar.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.title_panel_left.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.title_panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_clicker_b
            // 
            this.left_clicker_b.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.left_clicker_b.FlatAppearance.BorderSize = 0;
            this.left_clicker_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_clicker_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.left_clicker_b.Location = new System.Drawing.Point(181, 85);
            this.left_clicker_b.Name = "left_clicker_b";
            this.left_clicker_b.Size = new System.Drawing.Size(212, 31);
            this.left_clicker_b.TabIndex = 0;
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
            this.exit_b.UseVisualStyleBackColor = false;
            this.exit_b.Click += new System.EventHandler(this.exit_b_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_left.Controls.Add(this.max_random_left);
            this.panel_left.Controls.Add(this.min_random_left);
            this.panel_left.Controls.Add(this.left_type);
            this.panel_left.Controls.Add(this.title_panel_left);
            this.panel_left.Controls.Add(this.cps_input_left);
            this.panel_left.Controls.Add(this.cps_left);
            this.panel_left.Controls.Add(this.left_clicker_b);
            this.panel_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_left.Location = new System.Drawing.Point(19, 54);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(638, 223);
            this.panel_left.TabIndex = 3;
            // 
            // max_random_left
            // 
            this.max_random_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max_random_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.max_random_left.Location = new System.Drawing.Point(290, 136);
            this.max_random_left.MaxLength = 3;
            this.max_random_left.Name = "max_random_left";
            this.max_random_left.Size = new System.Drawing.Size(103, 31);
            this.max_random_left.TabIndex = 10;
            this.max_random_left.Text = "13";
            this.max_random_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.max_random_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_random_left_KeyPress);
            this.max_random_left.Leave += new System.EventHandler(this.max_random_left_Leave);
            // 
            // min_random_left
            // 
            this.min_random_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_random_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.min_random_left.Location = new System.Drawing.Point(181, 136);
            this.min_random_left.MaxLength = 3;
            this.min_random_left.Name = "min_random_left";
            this.min_random_left.Size = new System.Drawing.Size(103, 31);
            this.min_random_left.TabIndex = 9;
            this.min_random_left.Text = "9";
            this.min_random_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.min_random_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.min_random_left_KeyPress);
            this.min_random_left.Leave += new System.EventHandler(this.min_random_left_Leave);
            // 
            // left_type
            // 
            this.left_type.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.left_type.FlatAppearance.BorderSize = 0;
            this.left_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.left_type.Location = new System.Drawing.Point(29, 136);
            this.left_type.Name = "left_type";
            this.left_type.Size = new System.Drawing.Size(148, 31);
            this.left_type.TabIndex = 8;
            this.left_type.Text = "CONST";
            this.left_type.UseVisualStyleBackColor = false;
            this.left_type.Click += new System.EventHandler(this.left_type_Click);
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
            this.title_left.AutoSize = true;
            this.title_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_left.Location = new System.Drawing.Point(3, 4);
            this.title_left.Name = "title_left";
            this.title_left.Size = new System.Drawing.Size(128, 31);
            this.title_left.TabIndex = 4;
            this.title_left.Text = "LEFT MB";
            // 
            // cps_input_left
            // 
            this.cps_input_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cps_input_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.cps_input_left.Location = new System.Drawing.Point(73, 85);
            this.cps_input_left.MaxLength = 3;
            this.cps_input_left.Name = "cps_input_left";
            this.cps_input_left.Size = new System.Drawing.Size(103, 31);
            this.cps_input_left.TabIndex = 3;
            this.cps_input_left.Text = "10";
            this.cps_input_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cps_input_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cps_input_left_KeyPress);
            this.cps_input_left.Leave += new System.EventHandler(this.cps_input_left_Leave);
            // 
            // cps_left
            // 
            this.cps_left.AutoSize = true;
            this.cps_left.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold);
            this.cps_left.Location = new System.Drawing.Point(23, 85);
            this.cps_left.Name = "cps_left";
            this.cps_left.Size = new System.Drawing.Size(54, 31);
            this.cps_left.TabIndex = 2;
            this.cps_left.Text = "CPS";
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_right.Controls.Add(this.max_random_right);
            this.panel_right.Controls.Add(this.min_random_right);
            this.panel_right.Controls.Add(this.right_type);
            this.panel_right.Controls.Add(this.title_panel_right);
            this.panel_right.Controls.Add(this.cps_input_right);
            this.panel_right.Controls.Add(this.cps_right);
            this.panel_right.Controls.Add(this.right_clicker_b);
            this.panel_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel_right.Location = new System.Drawing.Point(17, 295);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(638, 223);
            this.panel_right.TabIndex = 11;
            // 
            // max_random_right
            // 
            this.max_random_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max_random_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.max_random_right.Location = new System.Drawing.Point(292, 135);
            this.max_random_right.MaxLength = 3;
            this.max_random_right.Name = "max_random_right";
            this.max_random_right.Size = new System.Drawing.Size(103, 31);
            this.max_random_right.TabIndex = 10;
            this.max_random_right.Text = "36";
            this.max_random_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // min_random_right
            // 
            this.min_random_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_random_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.min_random_right.Location = new System.Drawing.Point(183, 135);
            this.min_random_right.MaxLength = 3;
            this.min_random_right.Name = "min_random_right";
            this.min_random_right.Size = new System.Drawing.Size(103, 31);
            this.min_random_right.TabIndex = 9;
            this.min_random_right.Text = "25";
            this.min_random_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // right_type
            // 
            this.right_type.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.right_type.FlatAppearance.BorderSize = 0;
            this.right_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.right_type.Location = new System.Drawing.Point(31, 135);
            this.right_type.Name = "right_type";
            this.right_type.Size = new System.Drawing.Size(148, 31);
            this.right_type.TabIndex = 8;
            this.right_type.Text = "CONST";
            this.right_type.UseVisualStyleBackColor = false;
            this.right_type.Click += new System.EventHandler(this.right_type_Click);
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
            this.title_right.AutoSize = true;
            this.title_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_right.Location = new System.Drawing.Point(3, 4);
            this.title_right.Name = "title_right";
            this.title_right.Size = new System.Drawing.Size(147, 31);
            this.title_right.TabIndex = 4;
            this.title_right.Text = "RIGHT MB";
            // 
            // cps_input_right
            // 
            this.cps_input_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cps_input_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.cps_input_right.Location = new System.Drawing.Point(75, 84);
            this.cps_input_right.MaxLength = 3;
            this.cps_input_right.Name = "cps_input_right";
            this.cps_input_right.Size = new System.Drawing.Size(103, 31);
            this.cps_input_right.TabIndex = 3;
            this.cps_input_right.Text = "30";
            this.cps_input_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cps_right
            // 
            this.cps_right.AutoSize = true;
            this.cps_right.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold);
            this.cps_right.Location = new System.Drawing.Point(25, 84);
            this.cps_right.Name = "cps_right";
            this.cps_right.Size = new System.Drawing.Size(54, 31);
            this.cps_right.TabIndex = 2;
            this.cps_right.Text = "CPS";
            // 
            // right_clicker_b
            // 
            this.right_clicker_b.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.right_clicker_b.FlatAppearance.BorderSize = 0;
            this.right_clicker_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_clicker_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.right_clicker_b.Location = new System.Drawing.Point(183, 84);
            this.right_clicker_b.Name = "right_clicker_b";
            this.right_clicker_b.Size = new System.Drawing.Size(212, 31);
            this.right_clicker_b.TabIndex = 0;
            this.right_clicker_b.Text = "DISABLED";
            this.right_clicker_b.UseVisualStyleBackColor = false;
            this.right_clicker_b.Click += new System.EventHandler(this.right_clicker_b_Click_1);
            // 
            // RightClicker
            // 
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 542);
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
            this.title_panel_left.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.title_panel_right.ResumeLayout(false);
            this.title_panel_right.PerformLayout();
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
        private System.Windows.Forms.Label cps_left;
        private System.Windows.Forms.TextBox cps_input_left;
        private System.Windows.Forms.Label title_left;
        private System.Windows.Forms.Panel title_panel_left;
        private System.Windows.Forms.Button left_type;
        private System.Windows.Forms.TextBox max_random_left;
        private System.Windows.Forms.TextBox min_random_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.TextBox max_random_right;
        private System.Windows.Forms.TextBox min_random_right;
        private System.Windows.Forms.Button right_type;
        private System.Windows.Forms.Panel title_panel_right;
        private System.Windows.Forms.Label title_right;
        private System.Windows.Forms.TextBox cps_input_right;
        private System.Windows.Forms.Label cps_right;
        private System.Windows.Forms.Button right_clicker_b;
        private System.Windows.Forms.Timer RightClicker;
    }
}

