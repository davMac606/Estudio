using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio201238
{
    class DAO_Conexao
    {

        public static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";database=" + banco + ";password=" + senha);
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static int login(String usuario, String senha)
        {
            int tipo = 0;

            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from CSDAO where usuario ='" + usuario + "' and senha ='" + senha + "'", con);
                Console.WriteLine("Select * from CSDAO where usuario ='" + usuario + "' and senha ='" + senha + "'");
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }


        public static Boolean CadLogin(string usuario, string senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into CSDAO (usuario, senha, tipo) " +
                    "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static Boolean AddItemCbxDesc()
        {
            bool add = false;
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT descModal from ModalCS";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter(sql, DAO_Conexao.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                adiciona.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                add = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(), "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return add;
        }
    }
}
