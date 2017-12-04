namespace LMS
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.userMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.issueButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.issueControlForUser = new IssueControlForUser.IssueControlForUser();
            this.bookControlForUser = new BookControlForUser.BookControlForUser();
            this.panel1.SuspendLayout();
            this.userMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 53);
            this.panel1.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(623, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 27);
            this.minimizeButton.TabIndex = 17;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(650, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(29, 27);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // userButton
            // 
            this.userButton.ContextMenuStrip = this.userMenuStrip;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(542, 9);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 15;
            this.userButton.Text = "username";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // userMenuStrip
            // 
            this.userMenuStrip.AccessibleName = "";
            this.userMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInfoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.userMenuStrip.Name = "userMenuStrip";
            this.userMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.userMenuStrip.Size = new System.Drawing.Size(153, 70);
            this.userMenuStrip.TabStop = true;
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Library Client";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 409);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.issueControlForUser);
            this.panel4.Controls.Add(this.bookControlForUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(171, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 409);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.sidePanel);
            this.panel3.Controls.Add(this.issueButton);
            this.panel3.Controls.Add(this.bookButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 409);
            this.panel3.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Teal;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 91);
            this.sidePanel.TabIndex = 0;
            // 
            // issueButton
            // 
            this.issueButton.FlatAppearance.BorderSize = 0;
            this.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueButton.Image = ((System.Drawing.Image)(resources.GetObject("issueButton.Image")));
            this.issueButton.Location = new System.Drawing.Point(0, 91);
            this.issueButton.Margin = new System.Windows.Forms.Padding(0);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(171, 91);
            this.issueButton.TabIndex = 13;
            this.issueButton.Text = "Issue";
            this.issueButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.FlatAppearance.BorderSize = 0;
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Image = ((System.Drawing.Image)(resources.GetObject("bookButton.Image")));
            this.bookButton.Location = new System.Drawing.Point(0, 0);
            this.bookButton.Margin = new System.Windows.Forms.Padding(0);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(171, 91);
            this.bookButton.TabIndex = 11;
            this.bookButton.Text = "Books";
            this.bookButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // issueControlForUser
            // 
            this.issueControlForUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueControlForUser.Location = new System.Drawing.Point(0, 0);
            this.issueControlForUser.memberId = 0;
            this.issueControlForUser.Name = "issueControlForUser";
            this.issueControlForUser.Size = new System.Drawing.Size(513, 409);
            this.issueControlForUser.TabIndex = 1;
            // 
            // bookControlForUser
            // 
            this.bookControlForUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookControlForUser.Location = new System.Drawing.Point(0, 0);
            this.bookControlForUser.Name = "bookControlForUser";
            this.bookControlForUser.Size = new System.Drawing.Size(513, 409);
            this.bookControlForUser.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Panel sidePanel;
        private BookControlForUser.BookControlForUser bookControlForUser;
        private IssueControlForUser.IssueControlForUser issueControlForUser;
        private System.Windows.Forms.ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}