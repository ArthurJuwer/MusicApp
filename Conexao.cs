using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MusicApp
{
    class Conexao
    {
        public string conect = "SERVER=localhost; DATABASE=musicapp; UID=root; PWD =; PORT=;";
        

        public MySqlConnection conx = null;

        // abrir conexao
        public void AbrirConexao()
        {
            try
            {
                conx = new MySqlConnection(conect);
                conx.Open();
            }
            catch (Exception ex)
            {
                // erro
                MessageBox.Show("Erro no servidor" + ex.Message);

            }
        }

        // fechar conexao
        public void FecharConexao()
        {
            try
            {
                conx = new MySqlConnection(conect);
                conx.Close();
            }
            catch (Exception ex)
            {
                // erro
                MessageBox.Show("Erro no servidor" + ex.Message);

            }
        }

    }
}
