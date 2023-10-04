using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bttl
{
    class PTB2
    {
        private float a, b, c;

        public float C
        {
            get { return c; }
            set { c = value; }
        }

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
        public PTB2()
        {

        }
        public PTB2(float a,float b,float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int TinhNghiem()
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return 1;
            }
            else if (delta == 0)
            {
                
                return 2;
            }
            else
            {
                
                
                return 3;
            }
                
        }
    }
}
