using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Indexers
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return X;
                }
                else if (index == 1)
                {
                    return Y;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return String.Format("Vector: X={0}, Y={1}", X, Y);
        }
    }
}
