using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Event
{
    public class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set {
                x = value;
                OnPointChanged();
            }
        }

        public double Y
        {
            get { return y; }
            set {
                y = value;
                OnPointChanged();
            }
        }

        public event EventHandler PointChanged;

        public void OnPointChanged()
        {
            if (PointChanged != null)
            {
                PointChanged(this, EventArgs.Empty);
            }
        }
    }
}
