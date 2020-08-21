using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace PruebaImagen.Models
{
    public class ProductosDAL
    {
        IDbConnection _conn = DbCommon.Conexion();

        //crear metodo agregar
        public int AregarProducto(ProductosEN pEN)
        {
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("AgregarProd", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@Nombre", pEN.Nombre));
            _Comand.Parameters.Add(new SqlParameter("@Desctip", pEN.Desctip));
            _Comand.Parameters.Add(new SqlParameter("@Imagen", pEN.Imagen));
            _Comand.Parameters.Add(new SqlParameter("@Precio", pEN.Precio));
            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }




        //metodo consultar
    }
}