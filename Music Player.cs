using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicApp
{
    public partial class Form1 : Form
    {
        private List<string> musicFiles;
        private string currentSong;
        private bool isPaused;


        
        public Form1()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            isPaused = false;
            
            
            

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

                    if (currentSong.Contains("D:"))
                    {
                        lblTitulo.Text = currentSong + " - Tocando";
                    }   


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
        

        

        private void siticoneImageButton9_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.previous();
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
        }
    }
    


}
