using Life_Green.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Life_Green_dal
{
    public class funcionarioDal:SqlHelper
    {
        public bool adicionar(SqlConnection con, Funcionario objfun)
        {
            string inserirFuncionario = "INSERT Funcionarios (nome, cargo, " + "cpffunc, nomeUser, senhaUser)" +
                " VALUES ('" + objfun.Nome + "','" + objfun.Cargo + "','" + objfun.Cpffunc + "','" + objfun.NomeUser + "'" +
                ",'" + objfun.SenhaUser + "')";
            try
            {
                executarComando(inserirFuncionario, con);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool alterar(SqlConnection con, Funcionario objfun)
        {
            string alterarFuncionario = " UPDATE Funcionarios SET" +
                                      "nome = '" + objfun.Nome + "'," +
                                      "cargo = '" + objfun.Cargo + "'," +
                                      "cpffunc = '" + objfun.Cpffunc + "'," +
                                      "nomeUser = '" + objfun.NomeUser + "'," +
                                      "senhaUser = '" + objfun.SenhaUser + "'," +
                                      "WHERE ID = '" + objfun.Id + " ";
            try
            {
                executarComando(alterarFuncionario, con);
                return true;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool excluir(SqlConnection con, Funcionario objfun)
        {
            string excluirFuncionario = "select * from Funcionarios where ID=" + objfun.Id;
            try
            {
                executarComando(excluirFuncionario, con);
                return true;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario pesquisarFuncId(SqlConnection con, Funcionario objfun)
        {
            string buscarFuncionarioId = "select * from Funcionarios where ID=" + objfun.Id;

            try
            {
                SqlDataReader dr = retornaDataReader(buscarFuncionarioId, con);
                dr.Read();
                objfun.Nome = dr[1].ToString();
                objfun.Cargo = dr[2].ToString();
                objfun.Cpffunc = dr[3].ToString();
                objfun.NomeUser = dr[4].ToString();
                objfun.SenhaUser = dr[5].ToString();
                return objfun;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Funcionario> listarFuncionarios(SqlConnection con)
        {
            string buscarTodosFuncionarios = "select * from Funcionarios";
            List<Funcionario> ListaFunc = new List<Funcionario>();
            try
            {
                SqlDataReader dr = retornaDataReader(buscarTodosFuncionarios, con);
                while (dr.Read())
                {
                    Funcionario objFunc = new Funcionario();
                    objFunc.Id = Convert.ToInt32(dr[0].ToString());
                    objFunc.Nome = dr[1].ToString();
                    objFunc.Cargo = dr[2].ToString();
                    objFunc.Cpffunc = dr[3].ToString();
                    objFunc.NomeUser = dr[4].ToString();
                    objFunc.SenhaUser = dr[5].ToString();
                    ListaFunc.Add(objFunc);
                }
                return ListaFunc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario pesquisarUser(SqlConnection con, Funcionario objfun)
        {
            string buscarUser = "SELECT nomeUser, senhaUser FROM Funcionarios";

            try
            {
                SqlDataReader dr = retornaDataReader(buscarUser, con);
                dr.Read();
                objfun.NomeUser = dr["nomeUser"].ToString();
                objfun.SenhaUser = dr["senhaUser"].ToString();
                return objfun;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     

    }
}
