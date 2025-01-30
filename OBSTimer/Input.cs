using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBSTimer {
    public partial class Input : Form {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string content { get; private set; }

        public Input() {
            InitializeComponent();
            DialogResult = DialogResult.None;

            new Moveable(this, new List<Control> {
                panel1,panel2,panel3,AppName,AppLogo
            });

            okButton.ButtonClick += (sender) => {
                content = nameInput.TextContent.Trim();
                if (!String.IsNullOrWhiteSpace(content)) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                } else {
                    MessageBox.Show("Name can not be empty!", "OBSTimer | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            nameInput.PressEnter += (sender) => {
                okButton.PerformClick();
            };
            nameInput.FocusText();
        }

        private void Input_Load(object sender, EventArgs e) {}
    }
}
