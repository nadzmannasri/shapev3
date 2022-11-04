using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class square : Ishape
    {
        private double _len;
        public double Len
        {
            get { return _len; }
            set { _len = value; }
        }

        public square()
        {
            _len = 0;
        }

        public square(double len)
        {
            _len = len;
        }

        public double area()
        {
            return _len * _len;
        }

        public double circumference()
        {
            return 4 * _len;
        }
    }
}
