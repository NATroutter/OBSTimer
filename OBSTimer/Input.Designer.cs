namespace OBSTimer {
    partial class Input {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.panel1 = new Panel();
            this.panel3 = new Panel();
            this.AppName = new Label();
            this.AppLogo = new PictureBox();
            this.panel2 = new Panel();
            this.closeButton = new Button();
            this.panel4 = new Panel();
            this.nameInput = new CustomControls.RoundedTextBox();
            this.okButton = new controls.RoundedButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.AppLogo).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            SuspendLayout();
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
            this.panel1.Size = new Size(362, 29);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AppName);
            this.panel3.Controls.Add(this.AppLogo);
            this.panel3.Dock = DockStyle.Left;
            this.panel3.Location = new Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(135, 19);
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
            this.AppName.Size = new Size(113, 17);
            this.AppName.TabIndex = 3;
            this.AppName.Text = "Name for timer?";
            // 
            // AppLogo
            // 
            this.AppLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.AppLogo.Dock = DockStyle.Left;
            this.AppLogo.Image = Properties.Resources.OBSTimer;
            this.AppLogo.Location = new Point(0, 0);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new Size(20, 19);
            this.AppLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.AppLogo.TabIndex = 11;
            this.AppLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = DockStyle.Right;
            this.panel2.Location = new Point(311, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(46, 19);
            this.panel2.TabIndex = 10;
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nameInput);
            this.panel4.Controls.Add(this.okButton);
            this.panel4.Dock = DockStyle.Fill;
            this.panel4.Location = new Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Padding(10);
            this.panel4.Size = new Size(362, 60);
            this.panel4.TabIndex = 10;
            // 
            // nameInput
            // 
            this.nameInput.BackgroundColor = Color.FromArgb(66, 69, 73);
            this.nameInput.ButtonFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.nameInput.ControlMargin = 10;
            this.nameInput.Dock = DockStyle.Left;
            this.nameInput.Location = new Point(10, 10);
            this.nameInput.MaximumSize = new Size(1000, 39);
            this.nameInput.MinimumSize = new Size(0, 39);
            this.nameInput.Name = "nameInput";
            this.nameInput.Padding = new Padding(10);
            this.nameInput.Radius = 10;
            this.nameInput.Size = new Size(259, 39);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextCasing = CharacterCasing.Lower;
            this.nameInput.TextColor = Color.FromArgb(242, 243, 245);
            this.nameInput.TextContent = "";
            // 
            // okButton
            // 
            this.okButton.ActiveColor = Color.FromArgb(115, 60, 60);
            this.okButton.BackgroundColor = Color.FromArgb(218, 114, 114);
            this.okButton.ButtonFont = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.okButton.ButtonText = "OK";
            this.okButton.ControlMargin = 10;
            this.okButton.Cursor = Cursors.Hand;
            this.okButton.Dock = DockStyle.Right;
            this.okButton.HoverColor = Color.FromArgb(166, 86, 86);
            this.okButton.Location = new Point(277, 10);
            this.okButton.MaximumSize = new Size(1000, 50);
            this.okButton.MinimumSize = new Size(0, 36);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new Padding(10);
            this.okButton.Radius = 10;
            this.okButton.Size = new Size(75, 40);
            this.okButton.TabIndex = 0;
            this.okButton.TextColor = Color.FromArgb(242, 243, 245);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new SizeF(9F, 18F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(54, 57, 62);
            this.ClientSize = new Size(362, 89);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new Font("Arial", 12F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Margin = new Padding(4);
            this.MaximizeBox = false;
            this.Name = "Input";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "OBSTimer";
            Load += Input_Load;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.AppLogo).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button closeButton;
        private Panel panel2;
        private Label AppName;
        private PictureBox AppLogo;
        private Panel panel3;
        private Panel panel4;
        private CustomControls.RoundedTextBox nameInput;
        private controls.RoundedButton okButton;
    }
}