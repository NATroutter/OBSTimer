namespace OBSTimer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.nameLabel = new Label();
            this.passedLabel = new Label();
            this.startLabel = new Label();
            this.useLatestFile = new CheckBox();
            this.useNamedFile = new CheckBox();
            this.groupBox1 = new GroupBox();
            this.groupBox2 = new GroupBox();
            this.startHidden = new CheckBox();
            this.panel1 = new Panel();
            this.panel3 = new Panel();
            this.AppName = new Label();
            this.AppLogo = new PictureBox();
            this.panel2 = new Panel();
            this.minimizeButton = new Button();
            this.closeButton = new Button();
            this.copyright = new Label();
            this.author = new Label();
            this.authorLink = new LinkLabel();
            this.source = new Label();
            this.sourceLink = new LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.AppLogo).BeginInit();
            this.panel2.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = Color.Transparent;
            this.nameLabel.Font = new Font("Arial", 15.75F);
            this.nameLabel.ForeColor = Color.FromArgb(242, 243, 245);
            this.nameLabel.Location = new Point(6, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new Size(112, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ???";
            // 
            // passedLabel
            // 
            this.passedLabel.AutoSize = true;
            this.passedLabel.BackColor = Color.Transparent;
            this.passedLabel.Font = new Font("Arial", 15.75F);
            this.passedLabel.ForeColor = Color.FromArgb(242, 243, 245);
            this.passedLabel.Location = new Point(6, 70);
            this.passedLabel.Name = "passedLabel";
            this.passedLabel.Size = new Size(129, 24);
            this.passedLabel.TabIndex = 1;
            this.passedLabel.Text = "Passed: ???";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = Color.Transparent;
            this.startLabel.Font = new Font("Arial", 15.75F);
            this.startLabel.ForeColor = Color.FromArgb(242, 243, 245);
            this.startLabel.Location = new Point(6, 46);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new Size(126, 24);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Started: ???";
            // 
            // useLatestFile
            // 
            this.useLatestFile.AutoSize = true;
            this.useLatestFile.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.useLatestFile.ForeColor = Color.FromArgb(242, 243, 245);
            this.useLatestFile.Location = new Point(7, 23);
            this.useLatestFile.Margin = new Padding(3, 2, 3, 2);
            this.useLatestFile.Name = "useLatestFile";
            this.useLatestFile.Size = new Size(122, 20);
            this.useLatestFile.TabIndex = 1;
            this.useLatestFile.Text = "Use latest file";
            this.useLatestFile.UseVisualStyleBackColor = true;
            this.useLatestFile.CheckedChanged += useLatestFile_CheckedChanged;
            // 
            // useNamedFile
            // 
            this.useNamedFile.AutoSize = true;
            this.useNamedFile.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.useNamedFile.ForeColor = Color.FromArgb(242, 243, 245);
            this.useNamedFile.Location = new Point(7, 47);
            this.useNamedFile.Margin = new Padding(3, 2, 3, 2);
            this.useNamedFile.Name = "useNamedFile";
            this.useNamedFile.Size = new Size(130, 20);
            this.useNamedFile.TabIndex = 2;
            this.useNamedFile.Text = "Use named file";
            this.useNamedFile.UseVisualStyleBackColor = true;
            this.useNamedFile.CheckedChanged += useNamedFile_CheckedChanged;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.passedLabel);
            this.groupBox1.Controls.Add(this.startLabel);
            this.groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.ForeColor = Color.FromArgb(242, 243, 245);
            this.groupBox1.Location = new Point(5, 31);
            this.groupBox1.Margin = new Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(3, 2, 3, 2);
            this.groupBox1.Size = new Size(324, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startHidden);
            this.groupBox2.Controls.Add(this.useLatestFile);
            this.groupBox2.Controls.Add(this.useNamedFile);
            this.groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.ForeColor = Color.FromArgb(242, 243, 245);
            this.groupBox2.Location = new Point(5, 135);
            this.groupBox2.Margin = new Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(3, 2, 3, 2);
            this.groupBox2.Size = new Size(324, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // startHidden
            // 
            this.startHidden.AutoSize = true;
            this.startHidden.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.startHidden.ForeColor = Color.FromArgb(242, 243, 245);
            this.startHidden.Location = new Point(7, 71);
            this.startHidden.Margin = new Padding(3, 2, 3, 2);
            this.startHidden.Name = "startHidden";
            this.startHidden.Size = new Size(113, 20);
            this.startHidden.TabIndex = 3;
            this.startHidden.Text = "Start Hidden";
            this.startHidden.UseVisualStyleBackColor = true;
            this.startHidden.CheckedChanged += startHidden_CheckedChanged;
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(40, 43, 48);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Margin = new Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Padding(5);
            this.panel1.Size = new Size(337, 29);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AppName);
            this.panel3.Controls.Add(this.AppLogo);
            this.panel3.Dock = DockStyle.Left;
            this.panel3.Location = new Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(149, 19);
            this.panel3.TabIndex = 12;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = Color.Transparent;
            this.AppName.Dock = DockStyle.Right;
            this.AppName.Font = new Font("Arial", 11F);
            this.AppName.ForeColor = Color.FromArgb(242, 243, 245);
            this.AppName.Location = new Point(22, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new Size(127, 17);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "OBSTimer | v1.0.0";
            // 
            // AppLogo
            // 
            this.AppLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.AppLogo.Dock = DockStyle.Left;
            this.AppLogo.Image = (Image)resources.GetObject("AppLogo.Image");
            this.AppLogo.Location = new Point(0, 0);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new Size(20, 19);
            this.AppLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.AppLogo.TabIndex = 11;
            this.AppLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = DockStyle.Right;
            this.panel2.Location = new Point(286, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(46, 19);
            this.panel2.TabIndex = 10;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = Color.FromArgb(218, 114, 114);
            this.minimizeButton.Cursor = Cursors.Hand;
            this.minimizeButton.Dock = DockStyle.Left;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = FlatStyle.Flat;
            this.minimizeButton.Font = new Font("Arial", 7F);
            this.minimizeButton.Location = new Point(0, 0);
            this.minimizeButton.Margin = new Padding(20);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new Size(20, 19);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "🗕";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += minimizeButton_Click;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = Color.FromArgb(218, 114, 114);
            this.closeButton.Cursor = Cursors.Hand;
            this.closeButton.Dock = DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = FlatStyle.Flat;
            this.closeButton.Font = new Font("Arial", 8F);
            this.closeButton.Location = new Point(26, 0);
            this.closeButton.Margin = new Padding(20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new Size(20, 19);
            this.closeButton.TabIndex = 8;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "✖";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += closeButton_Click;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = Color.Transparent;
            this.copyright.Font = new Font("Arial", 10F);
            this.copyright.ForeColor = Color.FromArgb(242, 243, 245);
            this.copyright.Location = new Point(94, 238);
            this.copyright.Name = "copyright";
            this.copyright.Size = new Size(150, 16);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Copyright © OBSTimer";
            this.copyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.BackColor = Color.Transparent;
            this.author.Font = new Font("Arial", 10F);
            this.author.ForeColor = Color.FromArgb(242, 243, 245);
            this.author.Location = new Point(101, 257);
            this.author.Margin = new Padding(0, 3, 0, 0);
            this.author.Name = "author";
            this.author.Size = new Size(53, 16);
            this.author.TabIndex = 8;
            this.author.Text = "Author:";
            this.author.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authorLink
            // 
            this.authorLink.ActiveLinkColor = Color.FromArgb(166, 86, 86);
            this.authorLink.AutoSize = true;
            this.authorLink.Font = new Font("Arial", 12F);
            this.authorLink.LinkBehavior = LinkBehavior.NeverUnderline;
            this.authorLink.LinkColor = Color.FromArgb(218, 114, 114);
            this.authorLink.Location = new Point(154, 255);
            this.authorLink.Margin = new Padding(0, 3, 0, 0);
            this.authorLink.Name = "authorLink";
            this.authorLink.Size = new Size(81, 18);
            this.authorLink.TabIndex = 10;
            this.authorLink.TabStop = true;
            this.authorLink.Text = "NATroutter";
            this.authorLink.VisitedLinkColor = Color.FromArgb(218, 114, 114);
            this.authorLink.LinkClicked += authorLink_LinkClicked;
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.BackColor = Color.Transparent;
            this.source.Font = new Font("Arial", 10F);
            this.source.ForeColor = Color.FromArgb(242, 243, 245);
            this.source.Location = new Point(68, 276);
            this.source.Margin = new Padding(0, 3, 0, 0);
            this.source.Name = "source";
            this.source.Size = new Size(56, 16);
            this.source.TabIndex = 9;
            this.source.Text = "Source:";
            this.source.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sourceLink
            // 
            this.sourceLink.ActiveLinkColor = Color.FromArgb(166, 86, 86);
            this.sourceLink.AutoSize = true;
            this.sourceLink.Font = new Font("Arial", 12F);
            this.sourceLink.LinkBehavior = LinkBehavior.NeverUnderline;
            this.sourceLink.LinkColor = Color.FromArgb(218, 114, 114);
            this.sourceLink.Location = new Point(121, 276);
            this.sourceLink.Margin = new Padding(0, 3, 0, 0);
            this.sourceLink.Name = "sourceLink";
            this.sourceLink.Size = new Size(149, 18);
            this.sourceLink.TabIndex = 11;
            this.sourceLink.TabStop = true;
            this.sourceLink.Text = "git.nat.gg/OBSTimer";
            this.sourceLink.VisitedLinkColor = Color.FromArgb(218, 114, 114);
            this.sourceLink.LinkClicked += sourceLink_LinkClicked;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(9F, 18F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(54, 57, 62);
            this.ClientSize = new Size(337, 302);
            this.Controls.Add(this.sourceLink);
            this.Controls.Add(this.authorLink);
            this.Controls.Add(this.author);
            this.Controls.Add(this.source);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new Font("Arial", 12F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Margin = new Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "OBSTimer";
            Load += Main_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.AppLogo).EndInit();
            this.panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label passedLabel;
        private Label startLabel;
        private CheckBox useLatestFile;
        private CheckBox useNamedFile;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox startHidden;
        private Panel panel1;
        private Button closeButton;
        private Button minimizeButton;
        private Panel panel2;
        private Label AppName;
        private Label copyright;
        private Label author;
        private LinkLabel authorLink;
        private Label source;
        private LinkLabel sourceLink;
        private PictureBox AppLogo;
        private Panel panel3;
    }
}
