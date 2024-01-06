using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПолевойМаксим_основнаяформа
{
    class Class1
    {
        double a; 
        double b; 
        string text; 
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string Calc()
        {
            double x1=0, x2=0;
            if ((a != 0) & (b != 0))
            {
                x1 = 0;
                x2 = -b / a;
                text = "x1= " + x1 + ";"+"\r\n\t"+" x2= " + x2;          
            }
            if (a == 0)
            {
                x1 = -b;
                text = "x= " + x1;
            }
            if (b == 0)
            {
                x1 = 0;
                text = "x= " + x1;
            }
            return (text);
        }
    }
}
