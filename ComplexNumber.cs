using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComplex
{
    public struct ComplexNumber
    {
        public decimal ImagPart { get; set; }
        public decimal RealPart { get; set; }
        public ComplexNumber(decimal realPart,decimal imagPart)
        {
            ImagPart = imagPart;
            RealPart = realPart;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return String.Format("{0} + {1}i", RealPart, ImagPart);
        }
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1.Equals(c2));
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2) 
        {
            return (new ComplexNumber(c1.RealPart + c2.RealPart, c1.ImagPart + c2.ImagPart));
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2) 
        {
            return (new ComplexNumber(c1.RealPart - c2.RealPart, c1.ImagPart - c2.ImagPart));
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)  // operator *
        {
            
            return (new ComplexNumber((c1.RealPart * c2.RealPart) - (c1.ImagPart * c2.ImagPart), (c1.ImagPart * c2.RealPart) + (c2.ImagPart * c1.RealPart)));
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            decimal denominator = (c2.RealPart * c2.RealPart) + (c2.ImagPart * c2.ImagPart);
            var numerator = new ComplexNumber((c1.RealPart * c2.RealPart) + (c1.ImagPart * c2.ImagPart), (c1.ImagPart * c2.RealPart) - (c2.ImagPart * c1.RealPart));
            return (new ComplexNumber(numerator.RealPart/denominator,numerator.ImagPart/denominator));
        }
    }
}
