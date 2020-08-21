using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PruebaImagen.Models
{
    public class DbCommon
    {
        private static string Conn = @"Data Source=LSTK231296\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}