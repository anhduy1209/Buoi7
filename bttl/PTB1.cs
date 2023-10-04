using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttl
{
    class PTB1
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

        public PTB1()
        {

        }
        public PTB1(float a,float b)
        {
            this.a = a;
            this.b = b;
        }
        public double TinhNghiem()
        {
            return -b / 2*a;
        }
    }
}
