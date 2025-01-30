namespace OBSTimer.controls {
    partial class RoundedButton {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label = new Label();
            SuspendLayout();
            // 
            // buttonText
            // 
            this.label.BackColor = Color.Transparent;
            this.label.Dock = DockStyle.Fill;
            this.label.ForeColor = Color.FromArgb(242, 243, 245);
            this.label.Location = new Point(10, 10);
            this.label.Name = "buttonText";
            this.label.Size = new Size(225, 30);
            this.label.TabIndex = 0;
            this.label.Text = "button";
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoundedButton
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.MaximumSize = new Size(1000, 50);
            this.MinimumSize = new Size(0, 36);
            this.Name = "RoundedButton";
            this.Padding = new Padding(10);
            this.Size = new Size(245, 50);
            Load += RoundedButton_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label;
    }
}
