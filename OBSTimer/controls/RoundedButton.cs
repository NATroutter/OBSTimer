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

namespace OBSTimer.controls {
    public partial class RoundedButton : UserControl {

        //Event Declarations
        public delegate void ClickDelegate(object sender);
        public event ClickDelegate? ButtonClick;

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

        private SolidBrush _backgroundBrush = new SolidBrush(Color.FromArgb(218, 114, 114));

        private Color _backgroundColor = Color.FromArgb(218, 114, 114);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor {
            get { return _backgroundColor; }
            set {
                _backgroundColor = value;
                _backgroundBrush = new SolidBrush(_backgroundColor = value);
                Invalidate();
            }
        }

        private Color _HoverColor = Color.FromArgb(166, 86, 86);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor {
            get { return _HoverColor; }
            set {
                _HoverColor = value;
                Invalidate();
            }
        }
        private Color _ActiveColor = Color.FromArgb(115, 60, 60);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ActiveColor {
            get { return _ActiveColor; }
            set {
                _ActiveColor = value;
                Invalidate();
            }
        }


        private string _ButtonText = "button";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ButtonText {
            get { return _ButtonText; }
            set {
                _ButtonText = value;
                Invalidate();
            }
        }
        private Font _Font = new Font(new FontFamily("Segoe UI"),9,FontStyle.Regular,GraphicsUnit.Point, 1);
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

        public RoundedButton() {
            InitializeComponent();

            this.MouseEnter += (sender, e) => {
                this._backgroundBrush = new SolidBrush(HoverColor);
                label.BackColor = HoverColor;
                Invalidate();
            };
            this.MouseLeave += (sender, e) => {
                this._backgroundBrush = new SolidBrush(BackgroundColor);
                label.BackColor = BackgroundColor;
                Invalidate();
            };
            this.MouseDown += (sender, e) => {
                if (e.Button != MouseButtons.Left) return;
                this._backgroundBrush = new SolidBrush(ActiveColor);
                label.BackColor = ActiveColor;
                Invalidate();
                ButtonClick?.Invoke(this);
            };
            this.MouseUp += (sender, e) => {
                if (e.Button != MouseButtons.Left) return;
                this._backgroundBrush = new SolidBrush(BackgroundColor);
                label.BackColor = BackgroundColor;
                Invalidate();
            };
            label.MouseEnter += (sender, e) => {
                this._backgroundBrush = new SolidBrush(HoverColor);
                label.BackColor = HoverColor;
                Invalidate();
            };
            label.MouseLeave += (sender, e) => {
                this._backgroundBrush = new SolidBrush(BackgroundColor);
                label.BackColor = BackgroundColor;
                Invalidate();
            };
            label.MouseDown += (sender, e) => {
                if (e.Button != MouseButtons.Left) return;
                this._backgroundBrush = new SolidBrush(ActiveColor);
                label.BackColor = ActiveColor;
                Invalidate();
                ButtonClick?.Invoke(this);
            };
            label.MouseUp += (sender, e) => {
                if (e.Button != MouseButtons.Left) return;
                this._backgroundBrush = new SolidBrush(BackgroundColor);
                label.BackColor = BackgroundColor;
                Invalidate();
            };

            Adjust();
        }

        public void PerformClick() {
            Invalidate();
            ButtonClick?.Invoke(this);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Adjust();
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            drawBackground(g);
        }

        private void Adjust() {
            Padding = new Padding(ControlMargin, ControlMargin, ControlMargin, ControlMargin);
            label.Font = ButtonFont;
            label.ForeColor = TextColor;
            label.Text = ButtonText;

        }

        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(_backgroundBrush, 0, 0, Width, Height, _radius);

        private void RoundedButton_Load(object sender, EventArgs e) {}

       
    }
}
