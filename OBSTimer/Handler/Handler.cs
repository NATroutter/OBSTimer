
using Timer = System.Windows.Forms.Timer;

namespace OBSTimer {
    public class Handler {

        //Event Declarations
        public delegate void DataChangedDelegate(object sender, HandlerData data);
        public event DataChangedDelegate? DataChangedEvent;

        //Variables
        private HandlerData data { get; }
        private Timer timer = new Timer();

        //Statics
        private static SettingsData settings = Main.settings.data;

        public Handler(string name) {
            this.data = new HandlerData(name);

            this.timer.Tick += (sender, e) => Update();
            this.timer.Interval = 1000;
        }

        public void Start() {
            WriteStart();
            Update();
            timer.Start();
        }

        public void Update() {
            WriteCurrent();
            DataChangedEvent?.Invoke(this, data);
        }

        public void WriteStart() {
            
            if (settings.useLatestFile) {
                File.WriteAllText(data.latest.start, data.getStartTimeFormated());
            }
            if (settings.useNamedFile) {
                File.WriteAllText(data.named.start, data.getStartTimeFormated());
            }
        }
        public void WriteCurrent() {
            if (settings.useLatestFile) {
                File.WriteAllText(data.latest.current, data.getPassedTimeFormated());
                File.WriteAllText(data.latest.name, data.getPassedTimeFormated());
            }
            if (settings.useNamedFile) {
                File.WriteAllText(data.named.current, data.getPassedTimeFormated());
                //File.WriteAllText(data.named.name, data.getPassedTimeFormated()); Disabled because this is pointless to have!
            }
        }

    }

}
