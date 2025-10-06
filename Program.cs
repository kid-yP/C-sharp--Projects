using System;
using System.Windows.Forms;
// Ensure this is correct

namespace librarys
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Change to your main form

        }
    }
}
