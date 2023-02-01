

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trace3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = SpaceTrack.StartDrawSpaceTrack(@"C:\Users\hp\Downloads\head(1).txt", -5);
            if (a is null)
            {
                global::System.Console.WriteLine("返回为空");
                Console.ReadLine();
            }
            a.Save(@".\a.jpg");
        }
    }
}
