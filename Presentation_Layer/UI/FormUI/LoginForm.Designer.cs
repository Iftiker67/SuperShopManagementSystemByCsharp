namespace Presentation_Layer.UI.FormUI
{
    partial class LoginForm
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
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.fogotPaasLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.loginBox.Controls.Add(this.txtID);
            this.loginBox.Controls.Add(this.fogotPaasLinkLabel);
            this.loginBox.Controls.Add(this.loginButton);
            this.loginBox.Controls.Add(this.txtpass);
            this.loginBox.Controls.Add(this.idLabel);
            this.loginBox.Controls.Add(this.passLabel);
            this.loginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBox.Location = new System.Drawing.Point(33, 28);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBox.Name = "loginBox";
            this.loginBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBox.Size = new System.Drawing.Size(504, 497);
            this.loginBox.TabIndex = 7;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 129);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 34);
            this.txtID.TabIndex = 2;
            // 
            // fogotPaasLinkLabel
            // 
            this.fogotPaasLinkLabel.AutoSize = true;
            this.fogotPaasLinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.fogotPaasLinkLabel.Location = new System.Drawing.Point(202, 353);
            this.fogotPaasLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fogotPaasLinkLabel.Name = "fogotPaasLinkLabel";
            this.fogotPaasLinkLabel.Size = new System.Drawing.Size(130, 28);
            this.fogotPaasLinkLabel.TabIndex = 4;
            this.fogotPaasLinkLabel.TabStop = true;
            this.fogotPaasLinkLabel.Text = "Forgot Pass?";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(207, 289);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 44);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(227, 199);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(177, 34);
            this.txtpass.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.idLabel.Location = new System.Drawing.Point(109, 129);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(111, 23);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Employee ID:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passLabel.Location = new System.Drawing.Point(132, 199);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 23);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(571, 553);
            this.Controls.Add(this.loginBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.LinkLabel fogotPaasLinkLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passLabel;
    }
}