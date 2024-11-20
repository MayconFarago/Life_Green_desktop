using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life_Green.model;
using Microsoft.Data.SqlClient;

namespace Life_Green_dal
{
    public class produtoDal : SqlHelper
    {
        public bool add(SqlConnection con, Produtos objProd)
        {
            string inserirProd = " INSERT into Produtos (nomeProd, categoriaProd, qtdProd" +
            ",precoProd, medidaPord)" + "VALUES('" + objProd.NomeProd + "','" + objProd.CategoriaProd + "','" + objProd.QtdProd + "','" + objProd.PrecoProd + "','" + objProd.MedidaProd + "')";
            try
            {
                executarComando(inserirProd, con);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterar(SqlConnection con, Produtos objProd)
        {
            string alterarProd = "UPDATE Produtos SET" +
                "nomeProd = '" + objProd.NomeProd + "'," +
                "categoriaProd + '" + objProd.CategoriaProd + "'," +
                "qtdProd = '" + objProd.QtdProd + "'," +
                "precoProd = '" + objProd.PrecoProd + "'," +
                "medidaPord = '" + objProd.MedidaProd + "'," +
                "WHERE ID = '" + objProd.Id + "";
            try
            {
                executarComando(alterarProd, con);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool excluir(SqlConnection con, Produtos objProd)
        {
            string excluirProdutos = "select * from Produtos where ID=" + objProd.Id;
            try
            {
                executarComando(excluirProdutos, con);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produtos PesquisarProdId(SqlConnection con, Produtos objProd)
        {
            string buscarProdId = "select * from Produtos where ID=" + objProd.Id;

            try
            {
                SqlDataReader dr = retornaDataReader(buscarProdId, con);
                dr.Read();
                objProd.NomeProd = dr[1].ToString();
                objProd.CategoriaProd = dr[2].ToString();
                objProd.QtdProd = Convert.ToInt32(dr[3].ToString());
                objProd.PrecoProd = Convert.ToDouble(dr[4].ToString());
                objProd.MedidaProd = dr[5].ToString();
                return objProd;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Produtos> ListarProdutos(SqlConnection con)
        {
            string buscarTodosProdutos = "select * from Produtos";
            List<Produtos> listProd = new List<Produtos>();
            try
            {

                SqlDataReader dr = retornaDataReader(buscarTodosProdutos, con);
                while(dr.Read())
                {
                    Produtos objProd = new Produtos();
                    objProd.Id = Convert.ToInt32(dr[0].ToString());
                    objProd.NomeProd = dr[1].ToString();
                    objProd.CategoriaProd = dr[2].ToString();
                    objProd.QtdProd = Convert.ToInt32(dr[3].ToString());
                    objProd.PrecoProd = Convert.ToDouble(dr[4].ToString());
                    objProd.MedidaProd = dr[5].ToString();
                    listProd.Add(objProd);
                }
                return listProd;
            }catch (Exception ex) 
            {
                throw ex; 
            }

        }
    }
}
