namespace LMS
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.issueButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.userMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memberControl = new MemberControl.MemberControl();
            this.bookControl = new BookControl.BookControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.issueControl = new IssueControl.IssueControl();
            this.panel1.SuspendLayout();
            this.userMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.issueButton);
            this.panel1.Controls.Add(this.memberButton);
            this.panel1.Controls.Add(this.bookButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 107);
            this.panel1.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(702, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 27);
            this.minimizeButton.TabIndex = 14;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(729, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(29, 27);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Teal;
            this.sidePanel.Location = new System.Drawing.Point(166, 97);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(130, 10);
            this.sidePanel.TabIndex = 2;
            // 
            // issueButton
            // 
            this.issueButton.FlatAppearance.BorderSize = 0;
            this.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueButton.Image = ((System.Drawing.Image)(resources.GetObject("issueButton.Image")));
            this.issueButton.Location = new System.Drawing.Point(426, 0);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(130, 100);
            this.issueButton.TabIndex = 12;
            this.issueButton.Text = "Issue";
            this.issueButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.FlatAppearance.BorderSize = 0;
            this.memberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberButton.Image = ((System.Drawing.Image)(resources.GetObject("memberButton.Image")));
            this.memberButton.Location = new System.Drawing.Point(296, 0);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(130, 100);
            this.memberButton.TabIndex = 11;
            this.memberButton.Text = "Member";
            this.memberButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.FlatAppearance.BorderSize = 0;
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Image = ((System.Drawing.Image)(resources.GetObject("bookButton.Image")));
            this.bookButton.Location = new System.Drawing.Point(166, 0);
            this.bookButton.Margin = new System.Windows.Forms.Padding(0);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(130, 100);
            this.bookButton.TabIndex = 10;
            this.bookButton.Text = "Books";
            this.bookButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // userButton
            // 
            this.userButton.ContextMenuStrip = this.userMenuStrip;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(621, 7);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 9;
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
            this.userMenuStrip.Size = new System.Drawing.Size(124, 48);
            this.userMenuStrip.TabStop = true;
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.issueControl);
            this.panel2.Controls.Add(this.memberControl);
            this.panel2.Controls.Add(this.bookControl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 493);
            this.panel2.TabIndex = 1;
            // 
            // memberControl
            // 
            this.memberControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberControl.Location = new System.Drawing.Point(0, 0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(761, 493);
            this.memberControl.TabIndex = 2;
            // 
            // bookControl
            // 
            this.bookControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookControl.Location = new System.Drawing.Point(0, 0);
            this.bookControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookControl.Name = "bookControl";
            this.bookControl.Size = new System.Drawing.Size(761, 493);
            this.bookControl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(270, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System under development process! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(422, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to LMS";
            // 
            // issueControl
            // 
            this.issueControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueControl.Location = new System.Drawing.Point(0, 0);
            this.issueControl.Name = "issueControl";
            this.issueControl.Size = new System.Drawing.Size(761, 493);
            this.issueControl.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.userMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;
        private BookControl.BookControl bookControl;
        private MemberControl.MemberControl memberControl;
        private IssueControl.IssueControl issueControl;
    }
}