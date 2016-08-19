using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author : Tom Tsiliopoulos, Chenyuan Xie
 * Date : Aug 19, 2016
 * Date Modified: Aug 19, 2016
 * Description : Final Exam
 * Version : 0.1 - 
 *                  Added Documentary
 */

namespace COMP123_S2016_FinalExam_300709228
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());



        }
    }
}
