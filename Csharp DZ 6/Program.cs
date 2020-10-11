using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_DZ_6
{
    class Program
    {
        class Rectangle
        {
            private float A;
            private float B;
            public Rectangle()
            {
                A = 0;
                B = 0;
            }
            public Rectangle(float a, float b)
            {
                A = a;
                B = b;
            }
            /// <summary>
            public static Rectangle operator ++(Rectangle s)
            {
                s.A = s.A + 1;
                s.B = s.B + 1;
                return s;
            }
            public static Rectangle operator --(Rectangle s)
            {
                s.A = s.A - 1;
                s.B = s.B - 1;
                return s;
            }
            public static Rectangle operator +(Rectangle p1, Rectangle p2)
            {
                Rectangle p3 = new Rectangle
                {
                    A = p1.A + p2.A,
                    B = p1.B + p2.B
                };
                return p3;
            }
            public static Rectangle operator -(Rectangle p1, Rectangle p2)
            {
                Rectangle p3 = new Rectangle
                {
                    A = p1.A - p2.A,
                    B = p1.B - p2.B
                };
                return p3;
            }
            public static Rectangle operator *(Rectangle p1, Rectangle p2)
            {
                Rectangle p3 = new Rectangle
                {
                    A = p1.A * p2.A,
                    B = p1.B * p2.B
                };
                return p3;
            }
            public static Rectangle operator /(Rectangle p1, Rectangle p2)
            {
                Rectangle p3 = new Rectangle
                {
                    A = p1.A / p2.A,
                    B = p1.B / p2.B
                };
                return p3;
            }
            public override bool Equals(object obj)
            {
                Rectangle point = (Rectangle)obj;
                return this.A == point?.A && B == point?.B;
            }
            public override int GetHashCode()
            {
                var hashCode = 1861411795;
                hashCode = hashCode * -1521134295 + A.GetHashCode();
                hashCode += hashCode * -1521134295 + B.GetHashCode();
                return hashCode;
            }
            public static bool operator ==(Rectangle p1, Rectangle p2)
            {
                return p1.Equals(p2);
            }
            public static bool operator !=(Rectangle p1, Rectangle p2)
            {
                return !(p1 == p2);
            }
            public static bool operator >(Rectangle p1, Rectangle p2)
            {
                return p1.A + p1.B > p2.A + p2.B;
            }
            public static bool operator <(Rectangle p1, Rectangle p2)
            {
                return !(p1 > p2);
            }
            public static bool operator >=(Rectangle p1, Rectangle p2)
            {
                return p1.A + p1.B >= p2.A + p2.B;
            }
            public static bool operator <=(Rectangle p1, Rectangle p2)
            {
                return !(p1 >= p2);
            }
            public static bool operator true(Rectangle p)
            {
                return p.A != 0 || p.B != 0;
            }
            // in pair
            public static bool operator false(Rectangle p)
            {
                return p.A == 0 && p.B == 0;
            }
            /// </summary>
            public static explicit operator Square(Rectangle p)
            {
                return new Square(p.A + p.B);
            }
            public static explicit operator int(Rectangle p)
            {
                return (int)p.A;
            }
        }
        class Square
        {
            private float A;
            public Square()
            {
                A = 0;
            }
            public Square(float a)
            {
                A = a;
            }
            public override string ToString()
            {
                return $"Side A = {A}";
            }
            public static Square operator ++(Square s)
            {
                s.A = s.A + 1;
                return s;
            }
            public static Square operator --(Square s)
            {
                s.A = s.A - 1;
                return s;
            }
            public static Square operator +(Square s)
            {
                Square s1 = new Square
                {
                    A = s.A + s.A
                };
                return s1;
            }
            public static Square operator -(Square s)
            {
                Square s1 = new Square
                {
                    A = s.A - s.A
                };
                return s1;
            }
            public static bool operator ==(Square s1, Square s2)
            {
                return s1.Equals(s2);
            }
            public static bool operator !=(Square s1, Square s2)
            {
                return !(s1 == s2);
            }
            public static bool operator <(Square s1, Square s2)
            {
                return !(s1 > s2);
            }
            public static bool operator >(Square s1, Square s2)
            {
                return s1.A > s2.A;
            }
            public static bool operator >=(Square s1, Square s2)
            {
                return s1.A >= s2.A;
            }
            public static bool operator <=(Square s1, Square s2)
            {
                return !(s1 >= s2);
            }
            public static bool operator true(Square p)
            {
                return p.A != 0;
            }
            // in pair
            public static bool operator false(Square p)
            {
                return p.A == 0;
            }
            public override bool Equals(object obj)
            {
                Square Square = (Square)obj;
                return this.A == Square?.A;
            }
            public override int GetHashCode()
            {
                var hashCode = 1861411795;
                hashCode = hashCode * -1521134295 + A.GetHashCode();
                return hashCode;
            }
            public static implicit operator Rectangle(Square p)
            {
                return new Rectangle(p.A, 0);
            }
            public static explicit operator int(Square p)
            {
                return (int)p.A;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
