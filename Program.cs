using System;
using System.Windows.Forms;

namespace MakeASnakeGame
{
    static class Program
    {
        /// <summary>
        /// النقطة الرئيسية للبرنامج.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}