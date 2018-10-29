using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using XF.MVVMBasic.Entidades;

namespace XF.MVVMBasic.Dados
{
    public class AlunoDAL
    {
        private string connectionString = @"Data Source=.;Initial Catalog=DBAluno;Integrated Security=True";
        public List<Aluno> GetAlunos()
        {
            List<Aluno> lista = new List<Aluno>();

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PR_GetAlunos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Aluno aluno = new Aluno();
                    aluno.Id = Convert.ToInt32(dr["Id"].ToString());
                    aluno.Nome = dr["Nome"].ToString();
                    aluno.Email = dr["Email"].ToString();
                    aluno.RM = dr["RM"].ToString();
                    lista.Add(aluno);

                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
        public bool PostAluno(Aluno aluno)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PR_PostAluno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@RM", aluno.RM);
                cmd.Parameters.AddWithValue("@Email", aluno.Email);
                int retorno = cmd.ExecuteNonQuery();


                if (retorno != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
        public bool PutAluno(int id, Aluno aluno)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PR_PutAluno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@RM", aluno.RM);
                cmd.Parameters.AddWithValue("@Email", aluno.Email);
                int retorno = cmd.ExecuteNonQuery();


                if (retorno != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
        public bool DeleteAluno(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PR_DeleteAluno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int retorno = cmd.ExecuteNonQuery();


                if (retorno != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
    }
}
