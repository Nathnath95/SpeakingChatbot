namespace Chavatar
{
    partial class Form2
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
            this.signupbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupbutton
            // 
            this.signupbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbutton.ForeColor = System.Drawing.Color.Transparent;
            this.signupbutton.Location = new System.Drawing.Point(681, 315);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(391, 77);
            this.signupbutton.TabIndex = 1;
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.ForeColor = System.Drawing.Color.Transparent;
            this.loginbutton.Location = new System.Drawing.Point(271, 311);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(335, 81);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chavatar.Properties.Resources.start2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.signupbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button loginbutton;
    }
}