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

namespace CustomControls {
    public partial class RoundedTextBox : UserControl {

        //Event Declarations
        public delegate void PressEnterDelegate(object sender);
        public event PressEnterDelegate? PressEnter;

        private static Color defaultColor = Color.FromArgb(66, 69, 73);

        private int _margin = 10;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ControlMargin {
            get { return _margin; }
            set {
                _margin = value;
                Invalidate();
            }
        }

        private int _radius = 10;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius {
            get { return _radius; }
            set {
                _radius = value;
                Invalidate();
            }
        }

        private SolidBrush _backgroundBrush = new SolidBrush(defaultColor);

        private Color _backgroundColor = defaultColor;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor {
            get { return _backgroundColor; }
            set {
                _backgroundBrush = new SolidBrush(_backgroundColor = value);
                Invalidate();
            }
        }

        private string _TextContent = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextContent {
            get { return _TextContent; }
            set {
                _TextContent = value;
                Invalidate();
            }
        }
        private Font _Font = new Font(new FontFamily("Segoe UI"), 9, FontStyle.Regular, GraphicsUnit.Point, 1);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font ButtonFont {
            get { return _Font; }
            set {
                _Font = value;
                Invalidate();
            }
        }
        private Color _TextColor = Color.FromArgb(242, 243, 245);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColor {
            get { return _TextColor; }
            set {
                _TextColor = value;
                Invalidate();
            }
        }

        private CharacterCasing _TextCasing = CharacterCasing.Normal;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public CharacterCasing TextCasing {
            get { return _TextCasing; }
            set {
                _TextCasing = value;
                Invalidate();
            }
        }

        public RoundedTextBox() {
            InitializeComponent();
            textField.ContextMenuStrip = new ContextMenuStrip();

            textField.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) {
                    PressEnter?.Invoke(this);
                }
            };
            this.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) {
                    PressEnter?.Invoke(this);
                }
            };

            Adjust();
        }

        public void FocusText() {
            textField.Focus();
        }

        protected override void OnPaint(PaintEventArgs e) {
            Adjust();

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            drawBackground(g);
        }

        private void Adjust() {
            Padding = new Padding(ControlMargin, ControlMargin, ControlMargin, ControlMargin);

            textField.Text = TextContent;
            textField.BackColor = _backgroundColor;
            textField.Font = Font;
            textField.ForeColor = TextColor;
            textField.CharacterCasing = TextCasing;

            MaximumSize = new Size(1000, textField.Height + (ControlMargin * 2));
            MinimumSize = new Size(0, textField.Height + (ControlMargin * 2));
            Height = textField.Height + (ControlMargin * 2);
        }

        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(_backgroundBrush, 0, 0, Width, Height, _radius);

        private void onLoad(object sender, EventArgs e) { }

        private void onClick(object sender, EventArgs e) {
            textField.Focus();
        }

        private void textField_TextChanged(object sender, EventArgs e) {
            TextContent = textField.Text;
        }
    }
}
