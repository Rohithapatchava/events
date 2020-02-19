using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Program
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new Deleventhandler(Square);
            handler += new Deleventhandler(Circle);
            handler.Invoke();
        }
        
        static void Circle()
            {
                double r = 12.5;
                double ar = Math.PI * r * r;
                Console.WriteLine("area of circle:{0}", ar);
            }

        static void Square()
        {
            double r = 5.9;
            double ar = r * r;
            Console.WriteLine("area of square: {0}", ar);

        }
    }
}
