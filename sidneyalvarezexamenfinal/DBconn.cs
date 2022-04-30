using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace sidneyalvarezexamenfinal
{
    public class DBconn
    {
        
        
            public static SqlConnection obtenerConexion()
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["sidneyalvarezexamenfinalConnectionString"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                return conexion;
            }
        
    }
}