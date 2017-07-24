using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace MainForm
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        /// 
        static Mutex mutex = new Mutex(true, "OranC2{a74ccfd2-00aa-4f43-8e4d-d2d0f46dfe8d}");

        [STAThread]
        static void Main(string[] args)
        {





            if (args.Length > 0)
            {
                if (args[0].Equals("BatchMode"))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new Form1(true));

                }

            }
            else
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("only one instance at a time");
                }
            }


        }
    }
}
