using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentLibrary
{
    public class Calc
    {
        protected double S;
        protected double V;
        protected double P;

        public Calc(double s,double v,double p)
        {
            this.S = s;
            this.V = v;
            this.P = p;
        }

        public double sum()
        {
            S = (V * 100) / P;
            return S;
        }

        public double val()
        {
            V = (S / 100) * P;
            return V;
        }

        public double per()
        {
            P = (V * 100) / S;
            return P;
        }

        public void test(double s,double v,double p)
        {
            MessageBox.Show("Class is runnable:"+s+";"+v+";"+p);
        }
    }

    public class Calc2 : Calc  // Наследование
    {
        public Calc2(double s, double v, double p) : base (s,v,p)  // Наследование
        {
            
        }

        public void setsum(Double s)  //Инкапсуляция
        {
            this.S = s;
        }

        public Double getsum()        //Инкапсуляция
        {
            return this.S;
        }

        public void setval(Double v)  //Инкапсуляция
        {
            this.V = v;
        }

        public Double getval()        //Инкапсуляция
        {
            return this.V;
        }

        public void setper(Double p)  //Инкапсуляция
        {
            this.P = p;
        }

        public Double getper()        //Инкапсуляция
        {
            return this.P;
        }


        public void test() // Инкапсуляция
        {
            MessageBox.Show("Override");
        }

    }


}
