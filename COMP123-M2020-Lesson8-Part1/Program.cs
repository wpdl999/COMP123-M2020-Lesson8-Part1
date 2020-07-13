using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson8_Part1
{
    static class Program
    {
        // Step 1 - Declare a form
        public static HelloWorldForm helloWorldForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Step 2 - Instantiate a from
            helloWorldForm = new HelloWorldForm();


            // Step 3 - pass a reference to the Application
            Application.Run(helloWorldForm);
        }
    }
}
