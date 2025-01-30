using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OBSTimer {
    public class HandlerData {

        //Global Variables
        private string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        //Parameters
        public string name { get; }
        public DateTime startTime;

        public string dataDir { get; }
        public string namedDir { get; }

        public PathType named { get; }
        public PathType latest { get; }

        //PathType class
        public class PathType {
            public string start { get; }
            public string current { get; }
            public string name { get; }
            public PathType(string start, string current, string name) {
                this.start = start;
                this.current = current;
                this.name = name;
            }
        }

        public HandlerData(string name) {
            this.name = name;
            this.startTime = DateTime.Now;

            this.dataDir = Path.Combine(baseDir, "data");
            this.namedDir = Path.Combine(dataDir, "named");

            this.named = new PathType(
                start: Path.Combine(namedDir, name + "_start.txt"),
                current: Path.Combine(namedDir, name + "_current.txt"),
                name: Path.Combine(namedDir, name + "_name.txt")
            );
            this.latest = new PathType(
                start: Path.Combine(dataDir, "start.txt"),
                current: Path.Combine(dataDir, "current.txt"),
                name: Path.Combine(dataDir, "name.txt")
            );

            //Check if directories exits
            if (!Directory.Exists(dataDir)) {
                Directory.CreateDirectory(dataDir);
            }
            if (!Directory.Exists(namedDir)) {
                Directory.CreateDirectory(namedDir);
            }
        }

        public string getStartTimeFormated() {
            return startTime.ToString("HH:mm");
        }

        public TimeSpan getPassedTime() {
            return DateTime.Now.Subtract(startTime);
        }

        public string getPassedTimeFormated() {
            TimeSpan span = getPassedTime();
            return span.Hours + ":" + span.Minutes + ":" + span.Seconds;
        }
    }
}
