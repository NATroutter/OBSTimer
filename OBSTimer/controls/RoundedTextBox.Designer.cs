namespace CustomControls {
    partial class RoundedTextBox {
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
            this.textField = new TextBox();
            SuspendLayout();
            // 
            // textField
            // 
            this.textField.BackColor = Color.FromArgb(66, 69, 73);
            this.textField.BorderStyle = BorderStyle.None;
            this.textField.Dock = DockStyle.Fill;
            this.textField.Font = new Font("Segoe UI", 9F);
            this.textField.ForeColor = Color.FromArgb(242, 243, 245);
            this.textField.Location = new Point(10, 10);
            this.textField.Margin = new Padding(20);
            this.textField.Name = "textField";
            this.textField.Size = new Size(211, 16);
            this.textField.TabIndex = 3;
            this.textField.TextChanged += textField_TextChanged;
            // 
            // RoundedTextBox
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.textField);
            this.MaximumSize = new Size(1000, 36);
            this.MinimumSize = new Size(0, 36);
            this.Name = "RoundedTextBox";
            this.Padding = new Padding(10);
            this.Size = new Size(231, 36);
            Load += onLoad;
            Click += onClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textField;
    }
}
