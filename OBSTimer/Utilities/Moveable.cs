using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSTimer {
    public class Moveable {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        public Moveable(Form form, List<Control> controls) {
            controls.ForEach((control)=> {
                control.MouseDown += (sender, e) => {
                    _dragging = true;
                    _start_point = new Point(e.X, e.Y);
                };

                control.MouseUp += (sender, e) => {
                    _dragging = false;
                };

                control.MouseMove += (sender, e) => {
                    if (_dragging) {
                        Point p = form.PointToScreen(e.Location);
                        form.Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
                    }
                };
            });
        }
    }
}
