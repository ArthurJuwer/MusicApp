using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MusicApp
{

    public partial class AdicionarAlbuns : Form
    {
        // instancias globais
        Conexao conexao = new Conexao();
        MySqlCommand cmd;
        string foto = "";




        // variaveis globais
        string sql;

        // variavel q pega o id do registro
        public string id;
        public AdicionarAlbuns()
        {
            InitializeComponent();
            
        }
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"D:\"; // ABRIR DIRETAMENTE NESTA PASTA

            ofd.Title = "Busca de Arquivo de Imagem"; // TITULO

            ofd.Filter = "Imagem png (*.png) |*.png"; // FILTRAR PARA NAO MOSTRAR IMG/OTHERS APENAS ARQUIVOS TXT // "Arquivo txt(*.txt)|*.txt" //  todos - > "TODOS (*.*) | *.*";

            ofd.ShowDialog(); // ABRIR

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            foto = ofd.FileName.ToString();
            imgCapa.BackgroundImage = Image.FromFile(ofd.FileName);

            ofd.Dispose(); // NAO SOBRECARREGA
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexao.AbrirConexao();

            sql = "INSERT INTO albuns (autor, nome, descricao, privacidade, imagem) VALUES(@autor, @nome, @descricao, @privacidade, @imagem)";

            cmd = new MySqlCommand(sql, conexao.conx);

            
            cmd.Parameters.AddWithValue("@autor", txtAutor.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@privacidade", txtcbPrivacidade.Text);
            cmd.Parameters.AddWithValue("@imagem", imgCapa.BackgroundImage);

            cmd.ExecuteNonQuery();

            conexao.FecharConexao();
            MessageBox.Show("Álbum adicionado com sucesso!");
            this.Close();
        }
        //public byte[] img()
        //{
        //    if (foto == "")
        //    {
        //        return null;
        //    }
        //    byte[] imagemByte = null;
        //    FileStream fs = new FileStream(imgCapa.ImageLocation, FileMode.Open, FileAccess.Read);

        //    BinaryReader binaryReader = new BinaryReader(fs);   

        //    imagemByte  = binaryReader.ReadBytes((int)fs.Length);

        //    return imagemByte;


        //}
    }
}
