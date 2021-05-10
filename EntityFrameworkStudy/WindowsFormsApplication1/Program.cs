using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
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
            Model1 moddel = new Model1();
            DbSet<list_station> temp = moddel.list_station;

            list_station s = temp.FirstOrDefault();

            Random r = new Random(1000000);
            int id = r.Next(800000, 1000000);

            subscriber sub = new subscriber();
            sub.GENIDXTSISSI = id.ToString();
            sub.GENTYPE = "1";
            sub.TYPEGROUP = "1";
            sub.SUBSCRIBERNAME = id.ToString();

            moddel.subscriber.Add(sub);
            moddel.SaveChanges();
            Console.WriteLine("insert ok:GENIDXTSISSI = " + id.ToString());
            //update
            subscriber sub1 = new subscriber();
            sub1.GENIDXTSISSI = "500001";
            sub1.GENTYPE = "1";
            sub1.TYPEGROUP = "1";
            sub1.SUBSCRIBERNAME = "ef updated:" + DateTime.Now.ToString();
            moddel.Entry<subscriber>(sub1).State = EntityState.Modified;
            int count = moddel.SaveChanges();
            Console.WriteLine("update ok:GENIDXTSISSI = 500001 ,SUBSCRIBERNAME = " + sub1.SUBSCRIBERNAME);


            string idv = id.ToString();
            //delete
            subscriber sub2 = (from t in moddel.subscriber where SqlFunctions.Equals(t.GENIDXTSISSI, idv) select t).First();
            moddel.Entry<subscriber>(sub2).State = EntityState.Deleted;
            count = moddel.SaveChanges();
            Console.WriteLine("delete ok:GENIDXTSISSI = " + id.ToString());


            Application.Run(new Form1());
        }
    }
}
