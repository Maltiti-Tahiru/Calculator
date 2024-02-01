///////////////////////////////////////////////////////////////////////////////
// Maltiti Tahiru   
// TINFO-200A Costerella
// 2024-01-27
///////////////////////////////////////////////////////////////////////////////
// Simple Calculator Program
// A simple calculator that can process basic math problems such as addittion
// subtraction, multiplication and division
// It should also be able to handle errors and exceptions like dividing by zero
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer -- Description
// 2024-01-08   maltiti      I

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
