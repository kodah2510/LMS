namespace IssueControl
{
    partial class IssueControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueControl));
            this.issueDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.fineInfoButton = new System.Windows.Forms.Button();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // issueDataGridView
            // 
            this.issueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.issueDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.issueDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.issueDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.issueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.issueDataGridView.Location = new System.Drawing.Point(24, 75);
            this.issueDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.issueDataGridView.Name = "issueDataGridView";
            this.issueDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.issueDataGridView.RowHeadersVisible = false;
            this.issueDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.issueDataGridView.ShowCellErrors = false;
            this.issueDataGridView.Size = new System.Drawing.Size(535, 398);
            this.issueDataGridView.TabIndex = 1;
            this.issueDataGridView.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(22, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(41, 40);
            this.searchButton.TabIndex = 9;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextbox.Location = new System.Drawing.Point(69, 16);
            this.searchTextbox.MaximumSize = new System.Drawing.Size(1000, 300);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(490, 37);
            this.searchTextbox.TabIndex = 8;
            this.searchTextbox.Text = "Search";
            this.searchTextbox.Click += new System.EventHandler(this.searchTextbox_Click);
            this.searchTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextbox_KeyPress);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Book",
            "Member"});
            this.searchComboBox.Location = new System.Drawing.Point(571, 21);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(170, 32);
            this.searchComboBox.TabIndex = 10;
            // 
            // returnBookButton
            // 
            this.returnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookButton.Image = ((System.Drawing.Image)(resources.GetObject("returnBookButton.Image")));
            this.returnBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookButton.Location = new System.Drawing.Point(571, 182);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(170, 47);
            this.returnBookButton.TabIndex = 11;
            this.returnBookButton.Text = "Return Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // fineInfoButton
            // 
            this.fineInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fineInfoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("fineInfoButton.Image")));
            this.fineInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fineInfoButton.Location = new System.Drawing.Point(571, 236);
            this.fineInfoButton.Name = "fineInfoButton";
            this.fineInfoButton.Size = new System.Drawing.Size(170, 47);
            this.fineInfoButton.TabIndex = 12;
            this.fineInfoButton.Text = "Fine Info";
            this.fineInfoButton.UseVisualStyleBackColor = true;
            this.fineInfoButton.Click += new System.EventHandler(this.fineInfoButton_Click);
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBookButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBookButton.Image = ((System.Drawing.Image)(resources.GetObject("borrowBookButton.Image")));
            this.borrowBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBookButton.Location = new System.Drawing.Point(571, 128);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(170, 47);
            this.borrowBookButton.TabIndex = 13;
            this.borrowBookButton.Text = "Borrow Book";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(571, 75);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(170, 46);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // IssueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.borrowBookButton);
            this.Controls.Add(this.fineInfoButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.issueDataGridView);
            this.Name = "IssueControl";
            this.Size = new System.Drawing.Size(761, 493);
            this.Load += new System.EventHandler(this.IssueControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView issueDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button fineInfoButton;
        private System.Windows.Forms.Button borrowBookButton;
        private System.Windows.Forms.Button refreshButton;
    }
}
