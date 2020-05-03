using Colorful;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace ASCIIAtomicClock
{
    class Program
    {
        static void Main(string[] args)
        {
            FigletFont font = FigletFont.Load("standard.flf");
            Figlet figlet = new Figlet(font);

            while (true)
            {
                Console.WriteLine(figlet.ToAscii(DateTime.Now.ToString("hh:mm:ss")), ColorTranslator.FromHtml("#00cc00"));
                Thread.Sleep(65);
                Console.Clear();
            }

        }
    }
}
