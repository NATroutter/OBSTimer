using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using OBSTimer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace OBSTimer {

    //TODO input form for reason

    public partial class Main : Form {

        public static Settings settings = new Settings();
        private Handler? handler;
        private string[] args = Environment.GetCommandLineArgs();

        private NotifyIcon trayIcon;

        public Main() {
            InitializeComponent();

            //Create System tray menu
            ContextMenuStrip menu = new ContextMenuStrip() {
                Items = {
                    new ToolStripMenuItem("Show", null, (sender,args)=> ShowApp()),
                    new ToolStripMenuItem("Exit", null, (sender,args)=> {
                        if (trayIcon != null) trayIcon.Visible = false;
                        Application.Exit();
                    })
                }
            };

            //Initialize System Tray Icon
            trayIcon = new NotifyIcon() {
                Icon = this.Icon,
                ContextMenuStrip = menu,
                Visible = true,
            };

            //Allow left click to open the menu
            trayIcon.MouseClick += (sender, e) => {
                if (e.Button == MouseButtons.Left) {
                    ShowApp();
                }
            };

            //Initialize controls what can be used to move form around!
            new Moveable(this, new List<Control> {
                panel1,panel2,panel3,AppName,AppLogo
            });

            //Load & Initialize Settings
            settings.load();
            useLatestFile.Checked = settings.data.useLatestFile;
            useNamedFile.Checked = settings.data.useNamedFile;
            startHidden.Checked = settings.data.startHidden;

            string name;

            if (args.Length == 2) {
                name = args[1];
            } else {
                Input input = new Input();
                if (input.ShowDialog() == DialogResult.OK) {
                    name = input.content;
                } else {
                    MessageBox.Show("Invalid Name!", "OBSTimer | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
            }

            handler = new Handler(name);
            handler.DataChangedEvent += (sender, data) => {
                nameLabel.Text = "Name: " + data.name;
                startLabel.Text = "Started: " + data.getStartTimeFormated();
                passedLabel.Text = "Passed: " + data.getPassedTimeFormated();
            };
            handler.Start();

        }

        private void hideApp() {
            ShowInTaskbar = false;
            Hide();
        }
        private void ShowApp() {
            Show();
            ShowInTaskbar = true;
            Focus();
        }

        private void Main_Load(object sender, EventArgs e) {
            if (settings.data.startHidden) {
                hideApp();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            hideApp();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void useLatestFile_CheckedChanged(object sender, EventArgs e) {
            settings.data.useLatestFile = useLatestFile.Checked;
            settings.save();
        }

        private void useNamedFile_CheckedChanged(object sender, EventArgs e) {
            settings.data.useNamedFile = useNamedFile.Checked;
            settings.save();
        }

        private void startHidden_CheckedChanged(object sender, EventArgs e) {
            settings.data.startHidden = startHidden.Checked;
            settings.save();
        }

        private void authorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(new ProcessStartInfo("https://NATroutter.fi") { UseShellExecute = true });
        }

        private void sourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(new ProcessStartInfo("https://git.nat.gg/OBSTimer") { UseShellExecute = true });
        }
    }
}
