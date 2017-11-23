namespace AutoTest
{
    partial class CloseConfirm_form
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
            this.closeConfirmHead_label = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.lower_panel = new System.Windows.Forms.Panel();
            this.no_panel = new System.Windows.Forms.Panel();
            this.no_button = new System.Windows.Forms.Button();
            this.yes_panel = new System.Windows.Forms.Panel();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.lower_panel.SuspendLayout();
            this.no_panel.SuspendLayout();
            this.yes_panel.SuspendLayout();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeConfirmHead_label
            // 
            this.closeConfirmHead_label.AutoSize = true;
            this.closeConfirmHead_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConfirmHead_label.ForeColor = System.Drawing.Color.White;
            this.closeConfirmHead_label.Location = new System.Drawing.Point(1, 7);
            this.closeConfirmHead_label.Name = "closeConfirmHead_label";
            this.closeConfirmHead_label.Size = new System.Drawing.Size(244, 21);
            this.closeConfirmHead_label.TabIndex = 0;
            this.closeConfirmHead_label.Text = "Close the Automation Test Tool?";
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.Color.Black;
            this.yes_button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yes_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.yes_button.FlatAppearance.BorderSize = 0;
            this.yes_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.yes_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.yes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_button.ForeColor = System.Drawing.Color.White;
            this.yes_button.Location = new System.Drawing.Point(1, 1);
            this.yes_button.Margin = new System.Windows.Forms.Padding(0);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(74, 28);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "YES";
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.Yes_button_Click);
            this.yes_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseConfirm_form_KeyDown);
            // 
            // lower_panel
            // 
            this.lower_panel.BackColor = System.Drawing.Color.Black;
            this.lower_panel.Controls.Add(this.no_panel);
            this.lower_panel.Controls.Add(this.yes_panel);
            this.lower_panel.Location = new System.Drawing.Point(2, 38);
            this.lower_panel.Name = "lower_panel";
            this.lower_panel.Size = new System.Drawing.Size(246, 110);
            this.lower_panel.TabIndex = 3;
            // 
            // no_panel
            // 
            this.no_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.no_panel.Controls.Add(this.no_button);
            this.no_panel.Location = new System.Drawing.Point(140, 42);
            this.no_panel.Name = "no_panel";
            this.no_panel.Size = new System.Drawing.Size(76, 30);
            this.no_panel.TabIndex = 5;
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.Color.Black;
            this.no_button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.no_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.no_button.FlatAppearance.BorderSize = 0;
            this.no_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.no_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))));
            this.no_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_button.ForeColor = System.Drawing.Color.White;
            this.no_button.Location = new System.Drawing.Point(1, 1);
            this.no_button.Margin = new System.Windows.Forms.Padding(0);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(74, 28);
            this.no_button.TabIndex = 4;
            this.no_button.Text = "NO";
            this.no_button.UseVisualStyleBackColor = false;
            this.no_button.Click += new System.EventHandler(this.No_button_Click);
            this.no_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseConfirm_form_KeyDown);
            // 
            // yes_panel
            // 
            this.yes_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.yes_panel.Controls.Add(this.yes_button);
            this.yes_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.yes_panel.Location = new System.Drawing.Point(29, 43);
            this.yes_panel.Name = "yes_panel";
            this.yes_panel.Size = new System.Drawing.Size(76, 30);
            this.yes_panel.TabIndex = 3;
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.Black;
            this.upper_panel.Controls.Add(this.closeConfirmHead_label);
            this.upper_panel.Location = new System.Drawing.Point(2, 1);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(246, 36);
            this.upper_panel.TabIndex = 4;
            // 
            // CloseConfirm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.ControlBox = false;
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.lower_panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseConfirm_form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit Auto Test?";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseConfirm_form_KeyDown);
            this.lower_panel.ResumeLayout(false);
            this.no_panel.ResumeLayout(false);
            this.yes_panel.ResumeLayout(false);
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeConfirmHead_label;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Panel lower_panel;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Panel yes_panel;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Panel no_panel;
    }
}