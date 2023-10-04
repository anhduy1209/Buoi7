using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siem
{
    class TinhToan
    {
        private float a, b;

        public float B
        {
            get { return b; }
            set { b = value; }
        }

        public float A
        {
            get { return a; }
            set { a = value; }
        }
        public double Cong()
        {
            return a + b;
        }
        public double Tru()
        {
            return a - b;
        }
        public double Nhan()
        {
            return a * b;
        }
        public double Chia()
        {
            return a / b;
        }
        public TinhToan()
        {

        }
        public TinhToan(float a,float b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
