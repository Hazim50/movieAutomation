namespace Imdb
{
    partial class GirişSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişSayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_filmEkle = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_Sifre = new System.Windows.Forms.TextBox();
            this.tx_kAdi = new System.Windows.Forms.TextBox();
            this.picboxPassword = new System.Windows.Forms.PictureBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.link_filmEkle);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tx_Sifre);
            this.panel1.Controls.Add(this.tx_kAdi);
            this.panel1.Controls.Add(this.picboxPassword);
            this.panel1.Controls.Add(this.picboxUser);
            this.panel1.Controls.Add(this.lblLine);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 599);
            this.panel1.TabIndex = 0;
            // 
            // link_filmEkle
            // 
            this.link_filmEkle.AutoSize = true;
            this.link_filmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_filmEkle.LinkColor = System.Drawing.Color.White;
            this.link_filmEkle.Location = new System.Drawing.Point(323, 573);
            this.link_filmEkle.Name = "link_filmEkle";
            this.link_filmEkle.Size = new System.Drawing.Size(73, 20);
            this.link_filmEkle.TabIndex = 14;
            this.link_filmEkle.TabStop = true;
            this.link_filmEkle.Text = "Film Ekle";
            this.link_filmEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_filmEkle_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(36, 573);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(134, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_Sifre
            // 
            this.tx_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Sifre.Location = new System.Drawing.Point(106, 309);
            this.tx_Sifre.Name = "tx_Sifre";
            this.tx_Sifre.PasswordChar = '*';
            this.tx_Sifre.Size = new System.Drawing.Size(279, 31);
            this.tx_Sifre.TabIndex = 11;
            this.tx_Sifre.Text = "123";
            this.tx_Sifre.UseSystemPasswordChar = true;
            // 
            // tx_kAdi
            // 
            this.tx_kAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kAdi.Location = new System.Drawing.Point(106, 239);
            this.tx_kAdi.Multiline = true;
            this.tx_kAdi.Name = "tx_kAdi";
            this.tx_kAdi.Size = new System.Drawing.Size(279, 31);
            this.tx_kAdi.TabIndex = 10;
            this.tx_kAdi.Text = "asd";
            // 
            // picboxPassword
            // 
            this.picboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.picboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxPassword.BackgroundImage")));
            this.picboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPassword.Location = new System.Drawing.Point(40, 309);
            this.picboxPassword.Name = "picboxPassword";
            this.picboxPassword.Size = new System.Drawing.Size(32, 33);
            this.picboxPassword.TabIndex = 9;
            this.picboxPassword.TabStop = false;
            // 
            // picboxUser
            // 
            this.picboxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxUser.BackColor = System.Drawing.Color.Transparent;
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxUser.Location = new System.Drawing.Point(40, 239);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(32, 33);
            this.picboxUser.TabIndex = 8;
            this.picboxUser.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Location = new System.Drawing.Point(35, 198);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(350, 1);
            this.lblLine.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLogin.Location = new System.Drawing.Point(35, 158);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(148, 25);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "OTURUM AÇ";
            // 
            // GirişSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1056, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GirişSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxPassword;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tx_kAdi;
        private System.Windows.Forms.TextBox tx_Sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel link_filmEkle;
    }
}

