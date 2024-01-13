﻿namespace MusicApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.ShapeButton = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.siticoneShapes2 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblAlbuns = new System.Windows.Forms.Label();
            this.lblTocando = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.siticoneImageButton1 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblPlaylist_Titulo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.timerPlayback = new System.Windows.Forms.ProgressBar();
            this.volumeBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.siticoneImageButton4 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneImageButton2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnStart = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.btnStop = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSideBar.Controls.Add(this.ShapeButton);
            this.pnlSideBar.Controls.Add(this.siticoneShapes2);
            this.pnlSideBar.Controls.Add(this.lblAjuda);
            this.pnlSideBar.Controls.Add(this.lblConfiguracoes);
            this.pnlSideBar.Controls.Add(this.lblPlaylist);
            this.pnlSideBar.Controls.Add(this.lblAlbuns);
            this.pnlSideBar.Controls.Add(this.lblTocando);
            this.pnlSideBar.Controls.Add(this.label2);
            this.pnlSideBar.Controls.Add(this.label1);
            this.pnlSideBar.Controls.Add(this.siticonePictureBox1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(222, 665);
            this.pnlSideBar.TabIndex = 1;
            // 
            // ShapeButton
            // 
            this.ShapeButton.BorderColor = System.Drawing.Color.Purple;
            this.ShapeButton.FillColor = System.Drawing.Color.Transparent;
            this.ShapeButton.Location = new System.Drawing.Point(35, 298);
            this.ShapeButton.Name = "ShapeButton";
            this.ShapeButton.PolygonSkip = 1;
            this.ShapeButton.Rotate = 0F;
            this.ShapeButton.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Ellipse;
            this.ShapeButton.Size = new System.Drawing.Size(18, 18);
            this.ShapeButton.TabIndex = 11;
            this.ShapeButton.Text = "siticoneShapes1";
            this.ShapeButton.Zoom = 80;
            // 
            // siticoneShapes2
            // 
            this.siticoneShapes2.BorderColor = System.Drawing.Color.Purple;
            this.siticoneShapes2.FillColor = System.Drawing.Color.Silver;
            this.siticoneShapes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneShapes2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.siticoneShapes2.LineThickness = 2;
            this.siticoneShapes2.Location = new System.Drawing.Point(37, 298);
            this.siticoneShapes2.Name = "siticoneShapes2";
            this.siticoneShapes2.PolygonSkip = 1;
            this.siticoneShapes2.Rotate = 0F;
            this.siticoneShapes2.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Line;
            this.siticoneShapes2.Size = new System.Drawing.Size(10, 105);
            this.siticoneShapes2.TabIndex = 10;
            this.siticoneShapes2.Text = "siticoneShapes2";
            this.siticoneShapes2.Zoom = 80;
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjuda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAjuda.Location = new System.Drawing.Point(59, 606);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(50, 20);
            this.lblAjuda.TabIndex = 8;
            this.lblAjuda.Text = "Ajuda";
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConfiguracoes.Location = new System.Drawing.Point(59, 569);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(109, 20);
            this.lblConfiguracoes.TabIndex = 7;
            this.lblConfiguracoes.Text = "Configurações";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlaylist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPlaylist.Location = new System.Drawing.Point(59, 333);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(66, 20);
            this.lblPlaylist.TabIndex = 6;
            this.lblPlaylist.Text = "Playlists";
            this.lblPlaylist.Click += new System.EventHandler(this.lblPlaylist_Click_1);
            // 
            // lblAlbuns
            // 
            this.lblAlbuns.AutoSize = true;
            this.lblAlbuns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlbuns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbuns.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAlbuns.Location = new System.Drawing.Point(59, 374);
            this.lblAlbuns.Name = "lblAlbuns";
            this.lblAlbuns.Size = new System.Drawing.Size(58, 20);
            this.lblAlbuns.TabIndex = 5;
            this.lblAlbuns.Text = "Albuns";
            this.lblAlbuns.Click += new System.EventHandler(this.lblAlbuns_Click);
            // 
            // lblTocando
            // 
            this.lblTocando.AutoSize = true;
            this.lblTocando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTocando.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocando.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTocando.Location = new System.Drawing.Point(59, 296);
            this.lblTocando.Name = "lblTocando";
            this.lblTocando.Size = new System.Drawing.Size(68, 20);
            this.lblTocando.TabIndex = 4;
            this.lblTocando.Text = "Tocando";
            this.lblTocando.Click += new System.EventHandler(this.lblDescobrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 166);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PREMIUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARTHUR JUWER";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BorderRadius = 75;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(37, 28);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(150, 150);
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.musicPlayer);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.siticoneImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 75);
            this.panel2.TabIndex = 4;
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(684, 12);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(225, 51);
            this.musicPlayer.TabIndex = 21;
            this.musicPlayer.Visible = false;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(18, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 37);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Nome da Musica - Tocando";
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneImageButton1.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton1.Image")));
            this.siticoneImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton1.ImageRotate = 0F;
            this.siticoneImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton1.Location = new System.Drawing.Point(932, 20);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton1.Size = new System.Drawing.Size(32, 32);
            this.siticoneImageButton1.TabIndex = 0;
            this.siticoneImageButton1.Click += new System.EventHandler(this.siticoneImageButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(222, 75);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 515);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tocando";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(597, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Titulo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(594, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(597, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(594, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(597, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(594, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome da Musica";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.lblPlaylist_Titulo);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Playlist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(56, 408);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "CARREGAR";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblPlaylist_Titulo
            // 
            this.lblPlaylist_Titulo.AutoSize = true;
            this.lblPlaylist_Titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlaylist_Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lblPlaylist_Titulo.Location = new System.Drawing.Point(49, 39);
            this.lblPlaylist_Titulo.Name = "lblPlaylist_Titulo";
            this.lblPlaylist_Titulo.Size = new System.Drawing.Size(220, 37);
            this.lblPlaylist_Titulo.TabIndex = 7;
            this.lblPlaylist_Titulo.Text = "Adicionar Playlist";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(876, 277);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(17)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblEndTime);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.timerPlayback);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Controls.Add(this.siticoneImageButton4);
            this.panel1.Controls.Add(this.siticoneImageButton2);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(222, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 75);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(245, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "00:00";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(619, 26);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(34, 13);
            this.lblEndTime.TabIndex = 23;
            this.lblEndTime.Text = "00:00";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(245, 26);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(34, 13);
            this.lblStartTime.TabIndex = 22;
            this.lblStartTime.Text = "00:00";
            // 
            // timerPlayback
            // 
            this.timerPlayback.Location = new System.Drawing.Point(248, 43);
            this.timerPlayback.Name = "timerPlayback";
            this.timerPlayback.Size = new System.Drawing.Size(400, 5);
            this.timerPlayback.TabIndex = 21;
            this.timerPlayback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timerPlayback_MouseDown);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(735, 21);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(184, 27);
            this.volumeBar.TabIndex = 20;
            this.volumeBar.ThumbColor = System.Drawing.Color.Plum;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.timerPlayback_Scroll);
            // 
            // siticoneImageButton4
            // 
            this.siticoneImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneImageButton4.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton4.Image")));
            this.siticoneImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton4.ImageRotate = 0F;
            this.siticoneImageButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton4.Location = new System.Drawing.Point(932, 16);
            this.siticoneImageButton4.Name = "siticoneImageButton4";
            this.siticoneImageButton4.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton4.Size = new System.Drawing.Size(32, 32);
            this.siticoneImageButton4.TabIndex = 12;
            this.siticoneImageButton4.Click += new System.EventHandler(this.siticoneImageButton4_Click);
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneImageButton2.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton2.Image")));
            this.siticoneImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton2.ImageRotate = 0F;
            this.siticoneImageButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton2.Location = new System.Drawing.Point(684, 16);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneImageButton2.Size = new System.Drawing.Size(32, 32);
            this.siticoneImageButton2.TabIndex = 11;
            this.siticoneImageButton2.Click += new System.EventHandler(this.siticoneImageButton2_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStart.ImageRotate = 0F;
            this.btnStart.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStart.Location = new System.Drawing.Point(92, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.TabIndex = 10;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStop.ImageRotate = 0F;
            this.btnStop.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStop.Location = new System.Drawing.Point(141, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 6;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albuns";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 665);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblAlbuns;
        private System.Windows.Forms.Label lblTocando;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes2;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes ShapeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnStart;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnStop;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlaylist_Titulo;
        private System.Windows.Forms.ListBox listBox1;
       
        private System.Windows.Forms.Button btnLoad;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar volumeBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar timerPlayback;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
