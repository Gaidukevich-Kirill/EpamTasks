using System;
using System.Collections.Generic;
using System.Text;
using Task3.Colors;

namespace Task3.Figures
{
    public abstract class Figure //: IEquatable<Figure>
    {
        public double Side { get; set; }

        public abstract double Perimeter
        {
            get;
        }

        public abstract double Area
        {
            get;
        }

        /*public string Color
        {
            get
            {
                return Colors.Color.WithoutColor(string);
            }

            set
            {
                value = Colors.Color.WithoutColor;
            }
        }*/

        /*public bool Equals(Figure other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Side.Equals(other.Side);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Figure)obj);
        }

        public override int GetHashCode()
        {
            return Side.GetHashCode();
        }*/
    }
}
