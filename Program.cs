using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestComplex
{
    // vytvoit plnohodnotnu strukturu na komplexne cisla a manipulaciu s nimi

    public class Program
    {
        public static void Main(string[] args)
        {
            var n1 = new ComplexNumber (4,2);
            var n2 = new ComplexNumber (3,-1);
            var n3 = new ComplexNumber (4,2); 
            var n4 = n1;

            Console.WriteLine("Result of addition:{0}", n1+n2+n3);
            Console.WriteLine("Result of multiplication:{0}", n1 * n2);
            Console.WriteLine("Result of substraction:{0}", n1 - n2);
            Console.WriteLine("Result of division:{0}", n1 / n2);
            Console.WriteLine("{0}", n1.Equals(n3));
            Console.WriteLine("{0}", n1 == n3);
            Console.WriteLine("{0}", n1 != n3);
            Console.ReadLine();
        }
        //public struct ComplexNumber
        //{
        //    public int ImagPart { get; set; }
        //    public int RealPart { get; set; }
        //}

        //public static ComplexNumber Addition(ComplexNumber k1, ComplexNumber k2) // operator +
        //{
        //    var result = new ComplexNumber();
        //    result.RealPart = k1.RealPart + k2.RealPart;
        //    result.ImagPart = k1.ImagPart + k2.ImagPart;
        //    return result;
        //}
       
        //public static ComplexNumber Substraction(ComplexNumber k1, ComplexNumber k2) // operator -
        //{
        //    var result = new ComplexNumber();
        //    result.RealPart = k1.RealPart - k2.RealPart;
        //    result.ImagPart = k1.ImagPart - k2.ImagPart;
        //    return result;
        //}
        //public static ComplexNumber Multiplication(ComplexNumber k1, ComplexNumber k2)  // operator *
        //{
        //    var result = new ComplexNumber();
        //    result.RealPart = (k1.RealPart * k2.RealPart) - (k1.ImagPart * k2.ImagPart);
        //    result.ImagPart = ( k1.ImagPart * k2.RealPart) + (k1.ImagPart * k2.RealPart);
        //    return result;
        //}
        //public static ComplexNumber Division(ComplexNumber k1, ComplexNumber k2)
        //{
        //    var result = new ComplexNumber();


        //    result.RealPart = (k1.RealPart * k2.RealPart) - (k1.ImagPart * k2.ImagPart);
        //    result.ImagPart = (k1.ImagPart * k2.RealPart) + (k1.ImagPart * k2.RealPart);
        //    return result;
        //}
    }
}
