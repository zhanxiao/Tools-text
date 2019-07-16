using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTools_test
{
    class Program
    {
        public delegate void P();
        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        //P p;

        static void Main(string[] args)
        {
            //P p = new P(() =>
            //{
            //    Console.WriteLine("1");
            //});

            Program pro = new Program();
            pro.Func();

            OperatingSystem os = Environment.OSVersion;
            if(os.Platform == PlatformID.Win32Windows || os.Platform == PlatformID.Win32NT)
            {
                MessageBox(IntPtr.Zero, "Hello world!", "Hello world title!", 0);
            }
           

            Console.ReadLine();
        }

        public void Func()
        {
            P p = delegate
            {
                Console.WriteLine(1);
            };

            p += delegate
            {
                Console.WriteLine(2);
            };

            p();
        }
    }
}
