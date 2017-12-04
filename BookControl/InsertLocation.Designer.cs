namespace BookControl
{
    partial class InsertLocation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.insertLocationButton = new System.Windows.Forms.Button();
            this.sectionTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shelfTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rowTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 58);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Insert Location";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.insertLocationButton);
            this.panel2.Controls.Add(this.sectionTextbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.shelfTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.colTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rowTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bookIdTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 212);
            this.panel2.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(215, 155);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 35);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // insertLocationButton
            // 
            this.insertLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertLocationButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertLocationButton.Location = new System.Drawing.Point(93, 155);
            this.insertLocationButton.Name = "insertLocationButton";
            this.insertLocationButton.Size = new System.Drawing.Size(116, 35);
            this.insertLocationButton.TabIndex = 22;
            this.insertLocationButton.Text = "Insert";
            this.insertLocationButton.UseVisualStyleBackColor = true;
            this.insertLocationButton.Click += new System.EventHandler(this.insertLocationButton_Click_1);
            // 
            // sectionTextbox
            // 
            this.sectionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTextbox.Location = new System.Drawing.Point(178, 129);
            this.sectionTextbox.Name = "sectionTextbox";
            this.sectionTextbox.Size = new System.Drawing.Size(157, 23);
            this.sectionTextbox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Section";
            // 
            // shelfTextbox
            // 
            this.shelfTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shelfTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfTextbox.Location = new System.Drawing.Point(178, 103);
            this.shelfTextbox.Name = "shelfTextbox";
            this.shelfTextbox.Size = new System.Drawing.Size(157, 23);
            this.shelfTextbox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Shelf";
            // 
            // colTextbox
            // 
            this.colTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTextbox.Location = new System.Drawing.Point(178, 77);
            this.colTextbox.Name = "colTextbox";
            this.colTextbox.Size = new System.Drawing.Size(157, 23);
            this.colTextbox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Col";
            // 
            // rowTextbox
            // 
            this.rowTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTextbox.Location = new System.Drawing.Point(178, 51);
            this.rowTextbox.Name = "rowTextbox";
            this.rowTextbox.Size = new System.Drawing.Size(157, 23);
            this.rowTextbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Row";
            // 
            // bookIdTextbox
            // 
            this.bookIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookIdTextbox.Enabled = false;
            this.bookIdTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdTextbox.Location = new System.Drawing.Point(178, 25);
            this.bookIdTextbox.Name = "bookIdTextbox";
            this.bookIdTextbox.Size = new System.Drawing.Size(157, 23);
            this.bookIdTextbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "BookId";
            // 
            // InsertLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 270);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertLocation";
            this.Load += new System.EventHandler(this.InsertLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button insertLocationButton;
        private System.Windows.Forms.TextBox sectionTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shelfTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rowTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}