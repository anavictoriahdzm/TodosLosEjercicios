using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace SqlDependencyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"data source =LSTK231296\SQLEXPRESS ; initial catalog=prueba ; integrated security = True";
            using (TableDependency.SqlClient.SqlTableDependency<Customers> dep = new TableDependency.SqlClient.SqlTableDependency<Customers>(connectionString))
            {
                dep.OnChanged += Dep_OnChanged;

                dep.Start();
                Console.WriteLine("Waiting for receiving notificatiions...");
                Console.WriteLine("Press a key to stop");
                Console.ReadKey();
                dep.Stop();
            }
        }

        private static void Dep_OnChanged(object sender, RecordChangedEventArgs<Customers> e)
        {
            Console.WriteLine(Environment.NewLine);

            if (e.ChangeType != ChangeType.None)
            {
                Console.WriteLine("DML operation: " + e.ChangeType);
                Console.WriteLine(e.Entity.Id);
                Console.WriteLine(e.Entity.Name);
                Console.WriteLine(e.Entity.Surname);
                Console.WriteLine(Environment.NewLine);
            }
            
        }
    }
}
