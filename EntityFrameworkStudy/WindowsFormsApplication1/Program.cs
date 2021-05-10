using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model1 mddel = new Model1();
            DbSet<list_station> temp = mddel.list_station;

            list_station s = temp.FirstOrDefault();




            Application.Run(new Form1());
        }
    }
}
