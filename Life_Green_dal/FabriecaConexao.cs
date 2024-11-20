using System;
using Microsoft.Data.SqlClient;
namespace Life_Green_dal
{
    public class FabricaConexao
    {
        private static SqlConnection con;
        private static string caminho = "Data Source=mayc;Initial Catalog = Life_Green_BD; Integrated Security = True; Trust Server Certificate=True";


        public static SqlConnection getConnection()
        {
            try
            {

                con = new SqlConnection(caminho);
                return con;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

    }
}
