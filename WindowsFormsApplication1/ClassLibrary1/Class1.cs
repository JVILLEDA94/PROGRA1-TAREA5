using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private double d1, d2, resul;

        public double Resul
        {
            get { return resul; }
            set { resul = value; }
        }

        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }

        public Class1()
        {
            this.d1 = 0;
            this.d2 = 0;
        }

        public double CalcularSuma()
        {
            resul = d1 + d2;
            return resul;
        }

        public double CalcularResta()
        {
            resul = d1 - d2;
            return resul;
        }

        public double CalcularMulti()
        {
            resul = d1 * d2;
            return resul;
        }

        public double CalcularDiv()
        {
            resul = d1 / d2;
            return resul;
        }
        
    }
}
