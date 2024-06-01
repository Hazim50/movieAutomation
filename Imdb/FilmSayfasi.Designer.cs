namespace Imdb
{
    partial class FilmSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.iMDBDataSet = new Imdb.IMDBDataSet();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerTableAdapter = new Imdb.IMDBDataSetTableAdapters.FilmlerTableAdapter();
            this.YorumListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_dil = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.l_sure = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l_yildiz = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.l_imdbPuani = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_yonetmen = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_basrol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l_yil = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_tur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.l_filmAdi = new System.Windows.Forms.Label();
            this.iMDBDataSet1 = new Imdb.IMDBDataSet1();
            this.filmlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerTableAdapter1 = new Imdb.IMDBDataSet1TableAdapters.FilmlerTableAdapter();
            this.iMDBDataSet2 = new Imdb.IMDBDataSet2();
            this.filmlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerTableAdapter2 = new Imdb.IMDBDataSet2TableAdapters.FilmlerTableAdapter();
            this.FilmListesi = new System.Windows.Forms.DataGridView();
            this.yildiz1 = new System.Windows.Forms.PictureBox();
            this.yildiz2 = new System.Windows.Forms.PictureBox();
            this.yildiz3 = new System.Windows.Forms.PictureBox();
            this.yildiz4 = new System.Windows.Forms.PictureBox();
            this.yildiz5 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YorumListesi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz5)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iMDBDataSet
            // 
            this.iMDBDataSet.DataSetName = "IMDBDataSet";
            this.iMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.iMDBDataSet;
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // YorumListesi
            // 
            this.YorumListesi.AllowUserToDeleteRows = false;
            this.YorumListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(219)))));
            this.YorumListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YorumListesi.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.YorumListesi.Location = new System.Drawing.Point(613, 395);
            this.YorumListesi.Name = "YorumListesi";
            this.YorumListesi.Size = new System.Drawing.Size(240, 150);
            this.YorumListesi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "yorumlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "solda siyah, filme ait diğer bilgiler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.l_dil);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.l_sure);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.l_yildiz);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.l_imdbPuani);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.l_yonetmen);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.l_basrol);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.l_yil);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.l_tur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblLine);
            this.panel1.Controls.Add(this.l_filmAdi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 655);
            this.panel1.TabIndex = 5;
            // 
            // l_dil
            // 
            this.l_dil.AutoSize = true;
            this.l_dil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_dil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_dil.Location = new System.Drawing.Point(219, 418);
            this.l_dil.Name = "l_dil";
            this.l_dil.Size = new System.Drawing.Size(23, 18);
            this.l_dil.TabIndex = 36;
            this.l_dil.Text = "...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(38, 418);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 18);
            this.label19.TabIndex = 35;
            this.label19.Text = "Dil:";
            // 
            // l_sure
            // 
            this.l_sure.AutoSize = true;
            this.l_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_sure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_sure.Location = new System.Drawing.Point(219, 375);
            this.l_sure.Name = "l_sure";
            this.l_sure.Size = new System.Drawing.Size(23, 18);
            this.l_sure.TabIndex = 34;
            this.l_sure.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(38, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "Süre:";
            // 
            // l_yildiz
            // 
            this.l_yildiz.AutoSize = true;
            this.l_yildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_yildiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_yildiz.Location = new System.Drawing.Point(219, 333);
            this.l_yildiz.Name = "l_yildiz";
            this.l_yildiz.Size = new System.Drawing.Size(23, 18);
            this.l_yildiz.TabIndex = 32;
            this.l_yildiz.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(38, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Yıldız Puanı:";
            // 
            // l_imdbPuani
            // 
            this.l_imdbPuani.AutoSize = true;
            this.l_imdbPuani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_imdbPuani.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_imdbPuani.Location = new System.Drawing.Point(219, 291);
            this.l_imdbPuani.Name = "l_imdbPuani";
            this.l_imdbPuani.Size = new System.Drawing.Size(23, 18);
            this.l_imdbPuani.TabIndex = 30;
            this.l_imdbPuani.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(38, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "IMDB Puanı:";
            // 
            // l_yonetmen
            // 
            this.l_yonetmen.AutoSize = true;
            this.l_yonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_yonetmen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_yonetmen.Location = new System.Drawing.Point(218, 247);
            this.l_yonetmen.Name = "l_yonetmen";
            this.l_yonetmen.Size = new System.Drawing.Size(23, 18);
            this.l_yonetmen.TabIndex = 28;
            this.l_yonetmen.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(37, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Yönetmen:";
            // 
            // l_basrol
            // 
            this.l_basrol.AutoSize = true;
            this.l_basrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_basrol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_basrol.Location = new System.Drawing.Point(219, 203);
            this.l_basrol.Name = "l_basrol";
            this.l_basrol.Size = new System.Drawing.Size(23, 18);
            this.l_basrol.TabIndex = 26;
            this.l_basrol.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(38, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Başrol:";
            // 
            // l_yil
            // 
            this.l_yil.AutoSize = true;
            this.l_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_yil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_yil.Location = new System.Drawing.Point(219, 159);
            this.l_yil.Name = "l_yil";
            this.l_yil.Size = new System.Drawing.Size(23, 18);
            this.l_yil.TabIndex = 24;
            this.l_yil.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(38, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Çıkış Yılı:";
            // 
            // l_tur
            // 
            this.l_tur.AutoSize = true;
            this.l_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_tur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_tur.Location = new System.Drawing.Point(218, 114);
            this.l_tur.Name = "l_tur";
            this.l_tur.Size = new System.Drawing.Size(23, 18);
            this.l_tur.TabIndex = 22;
            this.l_tur.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(112, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "İzle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblLine
            // 
            this.lblLine.AllowDrop = true;
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Location = new System.Drawing.Point(40, 84);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(350, 1);
            this.lblLine.TabIndex = 7;
            // 
            // l_filmAdi
            // 
            this.l_filmAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_filmAdi.AutoSize = true;
            this.l_filmAdi.BackColor = System.Drawing.Color.Transparent;
            this.l_filmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_filmAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.l_filmAdi.Location = new System.Drawing.Point(37, 54);
            this.l_filmAdi.Name = "l_filmAdi";
            this.l_filmAdi.Size = new System.Drawing.Size(73, 20);
            this.l_filmAdi.TabIndex = 6;
            this.l_filmAdi.Text = "Film Adı";
            // 
            // iMDBDataSet1
            // 
            this.iMDBDataSet1.DataSetName = "IMDBDataSet1";
            this.iMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmlerBindingSource1
            // 
            this.filmlerBindingSource1.DataMember = "Filmler";
            this.filmlerBindingSource1.DataSource = this.iMDBDataSet1;
            // 
            // filmlerTableAdapter1
            // 
            this.filmlerTableAdapter1.ClearBeforeFill = true;
            // 
            // iMDBDataSet2
            // 
            this.iMDBDataSet2.DataSetName = "IMDBDataSet2";
            this.iMDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmlerBindingSource2
            // 
            this.filmlerBindingSource2.DataMember = "Filmler";
            this.filmlerBindingSource2.DataSource = this.iMDBDataSet2;
            // 
            // filmlerTableAdapter2
            // 
            this.filmlerTableAdapter2.ClearBeforeFill = true;
            // 
            // FilmListesi
            // 
            this.FilmListesi.AllowUserToAddRows = false;
            this.FilmListesi.AllowUserToDeleteRows = false;
            this.FilmListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilmListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FilmListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilmListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FilmListesi.ColumnHeadersHeight = 21;
            this.FilmListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FilmListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.FilmListesi.EnableHeadersVisualStyles = false;
            this.FilmListesi.Location = new System.Drawing.Point(497, 44);
            this.FilmListesi.Name = "FilmListesi";
            this.FilmListesi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilmListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FilmListesi.RowHeadersVisible = false;
            this.FilmListesi.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.FilmListesi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FilmListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FilmListesi.Size = new System.Drawing.Size(475, 133);
            this.FilmListesi.TabIndex = 7;
            this.FilmListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmListesi_CellClick);
            // 
            // yildiz1
            // 
            this.yildiz1.Location = new System.Drawing.Point(3, 3);
            this.yildiz1.Name = "yildiz1";
            this.yildiz1.Size = new System.Drawing.Size(40, 40);
            this.yildiz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yildiz1.TabIndex = 8;
            this.yildiz1.TabStop = false;
            this.yildiz1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yildiz1_MouseClick);
            // 
            // yildiz2
            // 
            this.yildiz2.Location = new System.Drawing.Point(49, 3);
            this.yildiz2.Name = "yildiz2";
            this.yildiz2.Size = new System.Drawing.Size(40, 40);
            this.yildiz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yildiz2.TabIndex = 9;
            this.yildiz2.TabStop = false;
            this.yildiz2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yildiz2_MouseClick);
            // 
            // yildiz3
            // 
            this.yildiz3.Location = new System.Drawing.Point(95, 3);
            this.yildiz3.Name = "yildiz3";
            this.yildiz3.Size = new System.Drawing.Size(40, 40);
            this.yildiz3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yildiz3.TabIndex = 10;
            this.yildiz3.TabStop = false;
            this.yildiz3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yildiz3_MouseClick);
            // 
            // yildiz4
            // 
            this.yildiz4.Location = new System.Drawing.Point(141, 3);
            this.yildiz4.Name = "yildiz4";
            this.yildiz4.Size = new System.Drawing.Size(40, 40);
            this.yildiz4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yildiz4.TabIndex = 11;
            this.yildiz4.TabStop = false;
            this.yildiz4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yildiz4_MouseClick);
            // 
            // yildiz5
            // 
            this.yildiz5.Location = new System.Drawing.Point(187, 3);
            this.yildiz5.Name = "yildiz5";
            this.yildiz5.Size = new System.Drawing.Size(40, 40);
            this.yildiz5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yildiz5.TabIndex = 12;
            this.yildiz5.TabStop = false;
            this.yildiz5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yildiz5_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.yildiz1);
            this.flowLayoutPanel1.Controls.Add(this.yildiz2);
            this.flowLayoutPanel1.Controls.Add(this.yildiz3);
            this.flowLayoutPanel1.Controls.Add(this.yildiz4);
            this.flowLayoutPanel1.Controls.Add(this.yildiz5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(597, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 45);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // FilmSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1056, 603);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FilmListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YorumListesi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilmSayfasi";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.FilmSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YorumListesi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yildiz5)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private IMDBDataSet iMDBDataSet;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private IMDBDataSetTableAdapters.FilmlerTableAdapter filmlerTableAdapter;
        private System.Windows.Forms.DataGridView YorumListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label l_filmAdi;
        private System.Windows.Forms.Label l_imdbPuani;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_yonetmen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_basrol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_yil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_tur;
        private System.Windows.Forms.Label l_dil;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label l_sure;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label l_yildiz;
        private System.Windows.Forms.Label label15;
        private IMDBDataSet1 iMDBDataSet1;
        private System.Windows.Forms.BindingSource filmlerBindingSource1;
        private IMDBDataSet1TableAdapters.FilmlerTableAdapter filmlerTableAdapter1;
        private IMDBDataSet2 iMDBDataSet2;
        private System.Windows.Forms.BindingSource filmlerBindingSource2;
        private IMDBDataSet2TableAdapters.FilmlerTableAdapter filmlerTableAdapter2;
        private System.Windows.Forms.DataGridView FilmListesi;
        private System.Windows.Forms.PictureBox yildiz1;
        private System.Windows.Forms.PictureBox yildiz2;
        private System.Windows.Forms.PictureBox yildiz3;
        private System.Windows.Forms.PictureBox yildiz4;
        private System.Windows.Forms.PictureBox yildiz5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}