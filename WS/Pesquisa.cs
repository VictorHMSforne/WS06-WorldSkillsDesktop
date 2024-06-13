using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WS
{
    public class Pesquisa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pergunta1 { get; set; }
        public int Pergunta2 { get; set; }
        public int Pergunta3 { get; set; }
        public string Resposta { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\WS\\WS\\WS\\DbPesquisa.mdf;Integrated Security=True");

        
        public void Inserir(string Nome,int perg1,int perg2, int perg3, string resp)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string sql = "INSERT INTO pesquisa(Nome,Pergunta1,Pergunta2,Pergunta3,Resposta) VALUES('" + Nome + "','" + perg1 + "','" + perg2 + "','" + perg3 + "','" + resp + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro", er.Message);
            }
        }
        public void Exibir()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "SELECT Nome,Resposta from pesquisa WHERE Id=(SELECT MAX(Id) FROM pesquisa)";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nome = dr["Nome"].ToString();
                Resposta = dr["Resposta"].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
