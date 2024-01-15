using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace MusicApp
{
    public partial class Form1 : Form 
    {
        private List<string> musicFiles;
        private string currentSong;
        private bool isPaused;
        Conexao conexao = new Conexao();



        
        MySqlCommand cmd;
        string foto = "";




        // variaveis globais
        string sql;

        // variavel q pega o id do registro
        public string id;

        // variaveis globais
        

        
        
        public Form1()
        {
            
            InitializeComponent();
            musicFiles = new List<string>();
            isPaused = false;
            

            

            

            conexao.AbrirConexao();
            var cmd = new MySqlCommand("SELECT autor, nome FROM albuns WHERE id=1", conexao.conx);
                
                var reader = cmd.ExecuteReader();
                    
                while (reader.Read())
                {
                    var fname = reader.GetString(0);
                    var lname = reader.GetString(1);
                    lblNomeAlbum.Text = fname;
                    lblAlbumAutor.Text = lname;
                }
            conexao.FecharConexao();

            conexao.AbrirConexao();
            var cmd1 = new MySqlCommand("SELECT autor, nome FROM albuns WHERE id=2", conexao.conx);

            var reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                var fname1 = reader1.GetString(0);
                var lname1 = reader1.GetString(1);
                lblNomeAlbum1.Text = fname1;
                lblAlbumAutor1.Text = lname1;
            }
            conexao.FecharConexao();

            conexao.AbrirConexao();
            //var cmd2 = new MySqlCommand("SELECT autor, nome, imagem FROM albuns WHERE id=8", conexao.conx);

            //var reader2 = cmd2.ExecuteReader();

            //while (reader2.Read())
            //{
            //    var fname2 = reader2.GetString(0);
            //    var lname2 = reader2.GetString(1);
            //    var ftname2 = reader2.GetString(2).Trim(); 

            //    lblNomeAlbum2.Text = fname2;
            //    lblAlbumAutor2.Text = lname2.ToUpper();
            //    img2.BackgroundImage = null; // 

                
            //}

            //conexao.FecharConexao();

            //

            
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            conexao.AbrirConexao();
            MySqlCommand command;
            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM albuns WHERE ID = 8";

            command = new MySqlCommand(selectQuery, conexao.conx);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);

            lblAlbumAutor.Text = table.Rows[0][1].ToString();
            lblNomeAlbum2.Text = table.Rows[0][2].ToString();
            byte[] img = (byte[])table.Rows[0][5];

            MemoryStream ms = new MemoryStream(img);   

            img2.Image = Image.FromStream(ms);
            da.Dispose();
            conexao.FecharConexao();

            
            


        }
        private void lblDescobrir_Click(object sender, EventArgs e)
        {
            var point = new Point(35, 298);
            this.ShapeButton.Location = point;
            tabControl1.SelectedTab = tabPage1;
        }

        private void lblPlaylist_Click_1(object sender, EventArgs e)
        {
            var point = new Point(35, 335);
            this.ShapeButton.Location = point;
            tabControl1.SelectedTab = tabPage2;

        }
        private void lblAlbuns_Click(object sender, EventArgs e)
        {
            var point = new Point(35, 376);
            this.ShapeButton.Location = point;
            tabControl1.SelectedTab = tabPage3;
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;

                }
                else
                {
                    currentSong = musicFiles[listBox1.SelectedIndex];

                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();


                }
                timerPlayback.Enabled = true;
            }
        }
        

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                musicPlayer.Ctlcontrols.pause();
                isPaused = true;
            }
            else
            {
                musicPlayer.Ctlcontrols.play();
                isPaused = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 FILES | *.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    musicFiles.Add(file);
                    listBox1.Items.Add(Path.GetFileName(file));
                    
                }
                if (musicFiles.Count > 0)
                {
                    btnStart.Enabled = true;
                }
            }
            
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); 

        }


        private void timerPlayback_Scroll(object sender, ScrollEventArgs e)
        {
            musicPlayer.settings.volume = volumeBar.Value;
        }

        private void siticoneImageButton2_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume = volumeBar.Value = 0;
        }

        private void siticoneImageButton4_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume = volumeBar.Value = 100;
        }
        
        
        
        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                int nextIndex = listBox1.SelectedIndex += 1;

                if (nextIndex < musicFiles.Count)
                {
                    listBox1.SelectedIndex = nextIndex;
                    currentSong = musicFiles[nextIndex];
                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }
                else
                {
                    musicPlayer.Ctlcontrols.stop();
                    isPaused = false;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timerPlayback.Maximum = Convert.ToInt32(musicPlayer.Ctlcontrols.currentItem.duration);

                timerPlayback.Value = Convert.ToInt32(musicPlayer.Ctlcontrols.currentPosition);
                label11.Visible = false;
            }
            try
            {
                
                lblStartTime.Text = musicPlayer.Ctlcontrols.currentPositionString;
                
                lblEndTime.Text = musicPlayer.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch 
            {

                
            }
        }

        private void timerPlayback_MouseDown(object sender, MouseEventArgs e)
        {
            musicPlayer.Ctlcontrols.currentPosition = musicPlayer.currentMedia.duration * e.X / timerPlayback.Width;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                var point = new Point(35, 298);
                this.ShapeButton.Location = point;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                var point = new Point(35, 335);
                this.ShapeButton.Location = point;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                var point = new Point(35, 376);
                this.ShapeButton.Location = point;
            }
        }

        private void btnSalvarAlbuns_Click(object sender, EventArgs e)
        {
            AdicionarAlbuns adicionarAlbuns = new AdicionarAlbuns();
            adicionarAlbuns.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

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
        
    }
    }
    



