namespace Presentation_Layer.UI.PanelUI
{
    partial class PanelAddProduct
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.categoryTableGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchCategoryButton = new FontAwesome.Sharp.IconButton();
            this.foreignCategoryOriginRadioButton = new System.Windows.Forms.RadioButton();
            this.localCategoryOriginRadioButton = new System.Windows.Forms.RadioButton();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryNameComboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.productTableGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.categoryNameComboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTableGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 711);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(0, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 369);
            this.panel4.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.categoryTableGridView);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(514, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 342);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category Table";
            // 
            // categoryTableGridView
            // 
            this.categoryTableGridView.AllowUserToAddRows = false;
            this.categoryTableGridView.AllowUserToDeleteRows = false;
            this.categoryTableGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryTableGridView.Location = new System.Drawing.Point(21, 51);
            this.categoryTableGridView.Name = "categoryTableGridView";
            this.categoryTableGridView.ReadOnly = true;
            this.categoryTableGridView.RowHeadersWidth = 51;
            this.categoryTableGridView.RowTemplate.Height = 24;
            this.categoryTableGridView.Size = new System.Drawing.Size(434, 250);
            this.categoryTableGridView.TabIndex = 0;
            this.categoryTableGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryTableGridView_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.searchCategoryButton);
            this.groupBox2.Controls.Add(this.foreignCategoryOriginRadioButton);
            this.groupBox2.Controls.Add(this.localCategoryOriginRadioButton);
            this.groupBox2.Controls.Add(this.addCategoryButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.taxTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.categoryNameComboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 342);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(273, 304);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 32);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // searchCategoryButton
            // 
            this.searchCategoryButton.FlatAppearance.BorderSize = 0;
            this.searchCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCategoryButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.searchCategoryButton.IconChar = FontAwesome.Sharp.IconChar.Trailer;
            this.searchCategoryButton.IconColor = System.Drawing.Color.Black;
            this.searchCategoryButton.IconSize = 40;
            this.searchCategoryButton.Location = new System.Drawing.Point(356, 88);
            this.searchCategoryButton.Name = "searchCategoryButton";
            this.searchCategoryButton.Rotation = 0D;
            this.searchCategoryButton.Size = new System.Drawing.Size(48, 40);
            this.searchCategoryButton.TabIndex = 19;
            this.searchCategoryButton.UseVisualStyleBackColor = true;
            this.searchCategoryButton.Click += new System.EventHandler(this.searchCategoryButton_Click);
            // 
            // foreignCategoryOriginRadioButton
            // 
            this.foreignCategoryOriginRadioButton.AutoSize = true;
            this.foreignCategoryOriginRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreignCategoryOriginRadioButton.Location = new System.Drawing.Point(150, 175);
            this.foreignCategoryOriginRadioButton.Name = "foreignCategoryOriginRadioButton";
            this.foreignCategoryOriginRadioButton.Size = new System.Drawing.Size(102, 32);
            this.foreignCategoryOriginRadioButton.TabIndex = 18;
            this.foreignCategoryOriginRadioButton.TabStop = true;
            this.foreignCategoryOriginRadioButton.Text = "Foreign";
            this.foreignCategoryOriginRadioButton.UseVisualStyleBackColor = true;
            // 
            // localCategoryOriginRadioButton
            // 
            this.localCategoryOriginRadioButton.AutoSize = true;
            this.localCategoryOriginRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localCategoryOriginRadioButton.Location = new System.Drawing.Point(41, 175);
            this.localCategoryOriginRadioButton.Name = "localCategoryOriginRadioButton";
            this.localCategoryOriginRadioButton.Size = new System.Drawing.Size(79, 32);
            this.localCategoryOriginRadioButton.TabIndex = 17;
            this.localCategoryOriginRadioButton.TabStop = true;
            this.localCategoryOriginRadioButton.Text = "Local";
            this.localCategoryOriginRadioButton.UseVisualStyleBackColor = true;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCategoryButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.Location = new System.Drawing.Point(375, 304);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(95, 32);
            this.addCategoryButton.TabIndex = 14;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Category Origin:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(41, 262);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(211, 34);
            this.taxTextBox.TabIndex = 11;
            this.taxTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax:";
            // 
            // categoryNameComboBox2
            // 
            this.categoryNameComboBox2.FormattingEnabled = true;
            this.categoryNameComboBox2.Location = new System.Drawing.Point(41, 91);
            this.categoryNameComboBox2.Name = "categoryNameComboBox2";
            this.categoryNameComboBox2.Size = new System.Drawing.Size(299, 36);
            this.categoryNameComboBox2.TabIndex = 9;
            this.categoryNameComboBox2.Click += new System.EventHandler(this.categoryNameComboBox2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category Name:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 344);
            this.panel3.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.confirmButton);
            this.groupBox4.Controls.Add(this.productTableGridView);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(514, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 332);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Table";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(335, 283);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(120, 43);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // productTableGridView
            // 
            this.productTableGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTableGridView.Location = new System.Drawing.Point(21, 51);
            this.productTableGridView.Name = "productTableGridView";
            this.productTableGridView.RowHeadersWidth = 51;
            this.productTableGridView.RowTemplate.Height = 24;
            this.productTableGridView.Size = new System.Drawing.Size(434, 226);
            this.productTableGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.unitComboBox);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.categoryNameComboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(19, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "K.G.",
            "Litre",
            "Piece"});
            this.unitComboBox.Location = new System.Drawing.Point(41, 269);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(216, 36);
            this.unitComboBox.TabIndex = 8;
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(356, 273);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(95, 32);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // categoryNameComboBox1
            // 
            this.categoryNameComboBox1.FormattingEnabled = true;
            this.categoryNameComboBox1.Location = new System.Drawing.Point(41, 170);
            this.categoryNameComboBox1.Name = "categoryNameComboBox1";
            this.categoryNameComboBox1.Size = new System.Drawing.Size(299, 36);
            this.categoryNameComboBox1.TabIndex = 7;
            this.categoryNameComboBox1.Click += new System.EventHandler(this.categoryNameComboBox1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(41, 79);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(299, 34);
            this.productNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "ADD PRODUCT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 53);
            this.panel1.TabIndex = 0;
            // 
            // PanelAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 764);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PanelAddProduct";
            this.Text = "PanelAddProduct";
            this.Load += new System.EventHandler(this.PanelAddProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTableGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox categoryNameComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryNameComboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton foreignCategoryOriginRadioButton;
        private System.Windows.Forms.RadioButton localCategoryOriginRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView categoryTableGridView;
        private FontAwesome.Sharp.IconButton searchCategoryButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView productTableGridView;
        private System.Windows.Forms.Button updateButton;
    }
}