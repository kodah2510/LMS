namespace LMS
{
    partial class NormalMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalMemberForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addToBagButton = new System.Windows.Forms.Button();
            this.borrowBook = new System.Windows.Forms.Button();
            this.usernameButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 33);
            this.textBox1.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(27, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(49, 35);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // addToBagButton
            // 
            this.addToBagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToBagButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBagButton.Image = ((System.Drawing.Image)(resources.GetObject("addToBagButton.Image")));
            this.addToBagButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToBagButton.Location = new System.Drawing.Point(428, 54);
            this.addToBagButton.Name = "addToBagButton";
            this.addToBagButton.Size = new System.Drawing.Size(173, 41);
            this.addToBagButton.TabIndex = 3;
            this.addToBagButton.Text = "Add to bag";
            this.addToBagButton.UseVisualStyleBackColor = true;
            // 
            // borrowBook
            // 
            this.borrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBook.Image = ((System.Drawing.Image)(resources.GetObject("borrowBook.Image")));
            this.borrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBook.Location = new System.Drawing.Point(428, 101);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(173, 41);
            this.borrowBook.TabIndex = 4;
            this.borrowBook.Text = "Borrow Books";
            this.borrowBook.UseVisualStyleBackColor = true;
            // 
            // usernameButton
            // 
            this.usernameButton.FlatAppearance.BorderSize = 0;
            this.usernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameButton.Location = new System.Drawing.Point(466, 12);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(75, 23);
            this.usernameButton.TabIndex = 5;
            this.usernameButton.Text = "username";
            this.usernameButton.UseVisualStyleBackColor = true;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(547, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 23);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(578, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(25, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NormalMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 305);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.usernameButton);
            this.Controls.Add(this.borrowBook);
            this.Controls.Add(this.addToBagButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NormalMemberForm";
            this.Text = "NormalMemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addToBagButton;
        private System.Windows.Forms.Button borrowBook;
        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}