namespace Presentation_Layer.UI.Dialog
{
    partial class ReturnDialog
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
            this.customerPhonenumber = new System.Windows.Forms.Label();
            this.numberTextbbox = new System.Windows.Forms.TextBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerPhonenumber
            // 
            this.customerPhonenumber.AutoSize = true;
            this.customerPhonenumber.Location = new System.Drawing.Point(87, 90);
            this.customerPhonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerPhonenumber.Name = "customerPhonenumber";
            this.customerPhonenumber.Size = new System.Drawing.Size(143, 25);
            this.customerPhonenumber.TabIndex = 0;
            this.customerPhonenumber.Text = "Phone Number";
            this.customerPhonenumber.Click += new System.EventHandler(this.customerPhonenumber_Click);
            // 
            // numberTextbbox
            // 
            this.numberTextbbox.Location = new System.Drawing.Point(238, 90);
            this.numberTextbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberTextbbox.Name = "numberTextbbox";
            this.numberTextbbox.Size = new System.Drawing.Size(242, 30);
            this.numberTextbbox.TabIndex = 1;
            // 
            // okbutton
            // 
            this.okbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutton.Location = new System.Drawing.Point(407, 155);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 31);
            this.okbutton.TabIndex = 2;
            this.okbutton.Text = "Ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(279, 155);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(106, 31);
            this.cancelbutton.TabIndex = 3;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Customer\'s Number";
            // 
            // ReturnDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.numberTextbbox);
            this.Controls.Add(this.customerPhonenumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReturnDialog";
            this.Text = "ReturnDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerPhonenumber;
        private System.Windows.Forms.TextBox numberTextbbox;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label1;
    }
}