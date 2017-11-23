namespace AutoTest
{
    partial class AutoTestMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTestMain));
            this.close_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.comodoLogo_panel = new System.Windows.Forms.Panel();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.settings_label = new System.Windows.Forms.Label();
            this.settingsLogo_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.rightBg_panel = new System.Windows.Forms.Panel();
            this.log_listBox = new System.Windows.Forms.ListBox();
            this.leftBg_panel = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.testStatus_label = new System.Windows.Forms.Label();
            this.runBg_panel = new System.Windows.Forms.Panel();
            this.run_button = new System.Windows.Forms.Button();
            this.testBg_panel = new System.Windows.Forms.Panel();
            this.test_button = new System.Windows.Forms.Button();
            this.testCases_listBox = new System.Windows.Forms.ListBox();
            this.runId_label = new System.Windows.Forms.Label();
            this.executionId_label = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.rightBg_panel.SuspendLayout();
            this.leftBg_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.runBg_panel.SuspendLayout();
            this.testBg_panel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Black;
            this.close_button.BackgroundImage = global::AutoTest.Properties.Resources.close;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.Black;
            this.close_button.Location = new System.Drawing.Point(867, 9);
            this.close_button.Margin = new System.Windows.Forms.Padding(0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(29, 29);
            this.close_button.TabIndex = 2;
            this.close_button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Black;
            this.top_panel.Controls.Add(this.comodoLogo_panel);
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Controls.Add(this.close_button);
            this.top_panel.Location = new System.Drawing.Point(0, -5);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(900, 40);
            this.top_panel.TabIndex = 3;
            // 
            // comodoLogo_panel
            // 
            this.comodoLogo_panel.BackgroundImage = global::AutoTest.Properties.Resources.comodo_title;
            this.comodoLogo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.comodoLogo_panel.Location = new System.Drawing.Point(32, 4);
            this.comodoLogo_panel.Name = "comodoLogo_panel";
            this.comodoLogo_panel.Size = new System.Drawing.Size(167, 40);
            this.comodoLogo_panel.TabIndex = 0;
            // 
            // formTitle_label
            // 
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.formTitle_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.formTitle_label.Location = new System.Drawing.Point(197, 10);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(171, 28);
            this.formTitle_label.TabIndex = 3;
            this.formTitle_label.Text = "Automation Test";
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.Black;
            this.bottom_panel.Controls.Add(this.info_label);
            this.bottom_panel.Controls.Add(this.settings_label);
            this.bottom_panel.Controls.Add(this.settingsLogo_panel);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 465);
            this.bottom_panel.Margin = new System.Windows.Forms.Padding(0);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(900, 35);
            this.bottom_panel.TabIndex = 1;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.Color.White;
            this.info_label.Location = new System.Drawing.Point(12, 9);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(212, 17);
            this.info_label.TabIndex = 0;
            this.info_label.Text = "Copyright Comodo Creators, 2017";
            // 
            // settings_label
            // 
            this.settings_label.AutoSize = true;
            this.settings_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.settings_label.Location = new System.Drawing.Point(799, 7);
            this.settings_label.Name = "settings_label";
            this.settings_label.Size = new System.Drawing.Size(66, 20);
            this.settings_label.TabIndex = 0;
            this.settings_label.Text = "settings";
            this.settings_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // settingsLogo_panel
            // 
            this.settingsLogo_panel.BackgroundImage = global::AutoTest.Properties.Resources.settings;
            this.settingsLogo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsLogo_panel.Location = new System.Drawing.Point(867, 3);
            this.settingsLogo_panel.Name = "settingsLogo_panel";
            this.settingsLogo_panel.Size = new System.Drawing.Size(29, 29);
            this.settingsLogo_panel.TabIndex = 0;
            // 
            // main_panel
            // 
            this.main_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.main_panel.BackColor = System.Drawing.Color.Black;
            this.main_panel.BackgroundImage = global::AutoTest.Properties.Resources.comodo1;
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel.Controls.Add(this.rightBg_panel);
            this.main_panel.Controls.Add(this.leftBg_panel);
            this.main_panel.ForeColor = System.Drawing.Color.Transparent;
            this.main_panel.Location = new System.Drawing.Point(0, 37);
            this.main_panel.Margin = new System.Windows.Forms.Padding(25);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(900, 426);
            this.main_panel.TabIndex = 6;
            // 
            // rightBg_panel
            // 
            this.rightBg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rightBg_panel.Controls.Add(this.right_panel);
            this.rightBg_panel.Location = new System.Drawing.Point(245, 9);
            this.rightBg_panel.Margin = new System.Windows.Forms.Padding(0);
            this.rightBg_panel.Name = "rightBg_panel";
            this.rightBg_panel.Size = new System.Drawing.Size(648, 404);
            this.rightBg_panel.TabIndex = 2;
            // 
            // log_listBox
            // 
            this.log_listBox.BackColor = System.Drawing.Color.Black;
            this.log_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_listBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_listBox.ForeColor = System.Drawing.Color.White;
            this.log_listBox.FormattingEnabled = true;
            this.log_listBox.ItemHeight = 21;
            this.log_listBox.Location = new System.Drawing.Point(0, 1);
            this.log_listBox.Margin = new System.Windows.Forms.Padding(0);
            this.log_listBox.Name = "log_listBox";
            this.log_listBox.Size = new System.Drawing.Size(645, 399);
            this.log_listBox.TabIndex = 1;
            // 
            // leftBg_panel
            // 
            this.leftBg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.leftBg_panel.Controls.Add(this.left_panel);
            this.leftBg_panel.Location = new System.Drawing.Point(8, 9);
            this.leftBg_panel.Name = "leftBg_panel";
            this.leftBg_panel.Size = new System.Drawing.Size(232, 404);
            this.leftBg_panel.TabIndex = 0;
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.Black;
            this.left_panel.Controls.Add(this.testStatus_label);
            this.left_panel.Controls.Add(this.runBg_panel);
            this.left_panel.Controls.Add(this.testBg_panel);
            this.left_panel.Controls.Add(this.testCases_listBox);
            this.left_panel.Controls.Add(this.runId_label);
            this.left_panel.Controls.Add(this.executionId_label);
            this.left_panel.Location = new System.Drawing.Point(2, 2);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(229, 401);
            this.left_panel.TabIndex = 1;
            // 
            // testStatus_label
            // 
            this.testStatus_label.AutoSize = true;
            this.testStatus_label.BackColor = System.Drawing.Color.Transparent;
            this.testStatus_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testStatus_label.ForeColor = System.Drawing.Color.Gray;
            this.testStatus_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testStatus_label.Location = new System.Drawing.Point(4, 354);
            this.testStatus_label.Margin = new System.Windows.Forms.Padding(0);
            this.testStatus_label.Name = "testStatus_label";
            this.testStatus_label.Size = new System.Drawing.Size(30, 46);
            this.testStatus_label.TabIndex = 1;
            this.testStatus_label.Text = "•";
            this.testStatus_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runBg_panel
            // 
            this.runBg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.runBg_panel.Controls.Add(this.run_button);
            this.runBg_panel.Location = new System.Drawing.Point(117, 359);
            this.runBg_panel.Name = "runBg_panel";
            this.runBg_panel.Size = new System.Drawing.Size(85, 35);
            this.runBg_panel.TabIndex = 2;
            // 
            // run_button
            // 
            this.run_button.BackColor = System.Drawing.Color.Black;
            this.run_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.run_button.FlatAppearance.BorderSize = 0;
            this.run_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.run_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.run_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.ForeColor = System.Drawing.Color.White;
            this.run_button.Location = new System.Drawing.Point(1, 1);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(83, 33);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "RUN";
            this.run_button.UseVisualStyleBackColor = false;
            this.run_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // testBg_panel
            // 
            this.testBg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.testBg_panel.Controls.Add(this.test_button);
            this.testBg_panel.Location = new System.Drawing.Point(34, 359);
            this.testBg_panel.Name = "testBg_panel";
            this.testBg_panel.Size = new System.Drawing.Size(71, 35);
            this.testBg_panel.TabIndex = 1;
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.Color.Black;
            this.test_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.test_button.FlatAppearance.BorderSize = 0;
            this.test_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.test_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.test_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_button.ForeColor = System.Drawing.Color.White;
            this.test_button.Location = new System.Drawing.Point(1, 1);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(69, 33);
            this.test_button.TabIndex = 1;
            this.test_button.Text = "test";
            this.test_button.UseVisualStyleBackColor = false;
            // 
            // testCases_listBox
            // 
            this.testCases_listBox.BackColor = System.Drawing.Color.Black;
            this.testCases_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testCases_listBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCases_listBox.ForeColor = System.Drawing.Color.White;
            this.testCases_listBox.FormattingEnabled = true;
            this.testCases_listBox.ItemHeight = 21;
            this.testCases_listBox.Location = new System.Drawing.Point(26, 31);
            this.testCases_listBox.Name = "testCases_listBox";
            this.testCases_listBox.Size = new System.Drawing.Size(170, 315);
            this.testCases_listBox.TabIndex = 1;
            // 
            // runId_label
            // 
            this.runId_label.AutoSize = true;
            this.runId_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runId_label.Location = new System.Drawing.Point(114, 5);
            this.runId_label.Name = "runId_label";
            this.runId_label.Size = new System.Drawing.Size(82, 25);
            this.runId_label.TabIndex = 1;
            this.runId_label.Text = "0000000";
            this.runId_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // executionId_label
            // 
            this.executionId_label.AutoSize = true;
            this.executionId_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionId_label.Location = new System.Drawing.Point(30, 7);
            this.executionId_label.Name = "executionId_label";
            this.executionId_label.Size = new System.Drawing.Size(78, 21);
            this.executionId_label.TabIndex = 1;
            this.executionId_label.Text = "RUN ID : ";
            this.executionId_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.executionId_label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // right_panel
            // 
            this.right_panel.BackColor = System.Drawing.Color.Black;
            this.right_panel.Controls.Add(this.log_listBox);
            this.right_panel.Location = new System.Drawing.Point(1, 1);
            this.right_panel.Margin = new System.Windows.Forms.Padding(0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(646, 402);
            this.right_panel.TabIndex = 3;
            // 
            // AutoTestMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::AutoTest.Properties.Resources.comodo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoTestMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Test";
            this.TopMost = true;
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.rightBg_panel.ResumeLayout(false);
            this.leftBg_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.runBg_panel.ResumeLayout(false);
            this.testBg_panel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel comodoLogo_panel;
        private System.Windows.Forms.Panel settingsLogo_panel;
        private System.Windows.Forms.Label settings_label;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Panel leftBg_panel;
        private System.Windows.Forms.Panel left_panel;
        protected System.Windows.Forms.Label executionId_label;
        private System.Windows.Forms.ListBox testCases_listBox;
        private System.Windows.Forms.Label runId_label;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Panel runBg_panel;
        private System.Windows.Forms.Panel testBg_panel;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Label testStatus_label;
        private System.Windows.Forms.Panel rightBg_panel;
        private System.Windows.Forms.ListBox log_listBox;
        private System.Windows.Forms.Panel right_panel;
    }
}

