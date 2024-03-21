using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1.Class
{
    class Point : Shape
    {
        private int u;
        private int v;

        public Point() { }
        public Point(int u,int v)
        {
            U = u;
            V = v;
        }

        public int U
        {
            get { return u; }
            set { this.u = value; }
        }
        public int V
        {
            get { return v; }
            set { this.v = value; }
        }
        public override string ToString()
        {
            return string.Format("\nThis is Point Class:\nPoint u = {0} and Point v = {1} ",U,V);
        }
    }

}
