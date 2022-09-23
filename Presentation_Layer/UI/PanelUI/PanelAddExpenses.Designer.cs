namespace Presentation_Layer.UI.PanelUI
{
    partial class PanelAddExpenses
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expenseGridView = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.btnStockAdd = new FontAwesome.Sharp.IconButton();
            this.expenseAmmount = new System.Windows.Forms.TextBox();
            this.expenseDetailstextBox = new System.Windows.Forms.TextBox();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deletedButton = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 58);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "ADD EXPENSE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.expenseGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 706);
            this.panel1.TabIndex = 14;
            // 
            // expenseGridView
            // 
            this.expenseGridView.AllowUserToAddRows = false;
            this.expenseGridView.AllowUserToDeleteRows = false;
            this.expenseGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.expenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseGridView.Location = new System.Drawing.Point(0, 321);
            this.expenseGridView.Margin = new System.Windows.Forms.Padding(4);
            this.expenseGridView.Name = "expenseGridView";
            this.expenseGridView.ReadOnly = true;
            this.expenseGridView.RowHeadersWidth = 51;
            this.expenseGridView.RowTemplate.Height = 24;
            this.expenseGridView.Size = new System.Drawing.Size(1010, 107);
            this.expenseGridView.TabIndex = 16;
            this.expenseGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseGridView_CellDoubleClick);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(432, 493);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(137, 37);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Confirm Expenses";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.expenseCategoryComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.expenseAmmount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.expenseDetailstextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.referenceTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65393F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 234);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Category:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expense Details";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Referance No:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expense Amount:";
            // 
            // expenseCategoryComboBox
            // 
            this.expenseCategoryComboBox.FormattingEnabled = true;
            this.expenseCategoryComboBox.Location = new System.Drawing.Point(4, 40);
            this.expenseCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.expenseCategoryComboBox.Name = "expenseCategoryComboBox";
            this.expenseCategoryComboBox.Size = new System.Drawing.Size(268, 33);
            this.expenseCategoryComboBox.TabIndex = 10;
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStockAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStockAdd.IconColor = System.Drawing.Color.Black;
            this.btnStockAdd.IconSize = 16;
            this.btnStockAdd.Location = new System.Drawing.Point(175, 4);
            this.btnStockAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Rotation = 0D;
            this.btnStockAdd.Size = new System.Drawing.Size(124, 39);
            this.btnStockAdd.TabIndex = 14;
            this.btnStockAdd.Text = "Add";
            this.btnStockAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd.Click += new System.EventHandler(this.btnStockAdd_Click);
            // 
            // expenseAmmount
            // 
            this.expenseAmmount.Location = new System.Drawing.Point(3, 137);
            this.expenseAmmount.Name = "expenseAmmount";
            this.expenseAmmount.Size = new System.Drawing.Size(206, 32);
            this.expenseAmmount.TabIndex = 15;
            // 
            // expenseDetailstextBox
            // 
            this.expenseDetailstextBox.Location = new System.Drawing.Point(326, 39);
            this.expenseDetailstextBox.Multiline = true;
            this.expenseDetailstextBox.Name = "expenseDetailstextBox";
            this.expenseDetailstextBox.Size = new System.Drawing.Size(317, 56);
            this.expenseDetailstextBox.TabIndex = 16;
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(649, 39);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(257, 32);
            this.referenceTextBox.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deletedButton);
            this.panel3.Controls.Add(this.btnStockAdd);
            this.panel3.Location = new System.Drawing.Point(326, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 56);
            this.panel3.TabIndex = 18;
            // 
            // deletedButton
            // 
            this.deletedButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deletedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deletedButton.IconColor = System.Drawing.Color.Black;
            this.deletedButton.IconSize = 16;
            this.deletedButton.Location = new System.Drawing.Point(27, 4);
            this.deletedButton.Margin = new System.Windows.Forms.Padding(4);
            this.deletedButton.Name = "deletedButton";
            this.deletedButton.Rotation = 0D;
            this.deletedButton.Size = new System.Drawing.Size(120, 39);
            this.deletedButton.TabIndex = 15;
            this.deletedButton.Text = "Delete";
            this.deletedButton.UseVisualStyleBackColor = true;
            this.deletedButton.Click += new System.EventHandler(this.deletedButton_Click);
            // 
            // PanelAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 764);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelAddExpenses";
            this.Text = "PanelAddExpenses";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView expenseGridView;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expenseCategoryComboBox;
        private FontAwesome.Sharp.IconButton btnStockAdd;
        private System.Windows.Forms.TextBox expenseAmmount;
        private System.Windows.Forms.TextBox expenseDetailstextBox;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton deletedButton;
    }
}