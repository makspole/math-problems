using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПолевойМаксим_основнаяформа
{
    class Classd: Class1
    {
        double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public string Calc2()
        {          
            double x1, x2;
            double D = Math.Pow(B, 2) - 4 * A * c;
            if (D > 0)
            {                
                x1 = (-1 * B + Math.Sqrt(D)) / (2 * A);
                x2 = (-1 * B - Math.Sqrt(D)) / (2 * A);
                Text = "\r\n"+"Уравнение имеет два корня:"+"\r\n"+"x1= " + x1 + ";" + "\r\n" + "x2= " + x2;
            }
            else if (D == 0)
            {
                x1 = (-1 * B) / (2 * A);
               Text = "\r\n" + "Уравнение имеет один корень:" +"\r\n"+"x = " + x1;
            }
            else
                Text = "\r\n" + "Уравнение не имеет корней";
            return (Text);
        }
    }
}
