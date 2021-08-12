
namespace HelloWorld
{
    partial class FormMain
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
            this.btnNhacHoa = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistdgv = new System.Windows.Forms.DataGridView();
            this.lblVietnam = new System.Windows.Forms.Label();
            this.lblAuMy = new System.Windows.Forms.Label();
            this.lblChauA = new System.Windows.Forms.Label();
            this.lblKhac = new System.Windows.Forms.Label();
            this.btnNhacTre = new System.Windows.Forms.Button();
            this.btnTruTinh = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnRap = new System.Windows.Forms.Button();
            this.btnNhacHan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBeat = new System.Windows.Forms.Button();
            this.btnKhongLoi = new System.Windows.Forms.Button();
            this.lblBaiHatHotNhat = new System.Windows.Forms.Label();
            this.btnHotNhat = new System.Windows.Forms.Button();
            this.btnMoiNhat = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbPlaylist = new System.Windows.Forms.ComboBox();
            this.cbSong = new System.Windows.Forms.ComboBox();
            this.checkFavorties = new System.Windows.Forms.CheckBox();
            this.btnCountSong = new System.Windows.Forms.Button();
            this.btnNhacHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhacHoa
            // 
            this.btnNhacHoa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btnNhacHoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.btnNhacHoa.Location = new System.Drawing.Point(0, 0);
            this.btnNhacHoa.Name = "btnNhacHoa";
            this.btnNhacHoa.Size = new System.Drawing.Size(1242, 28);
            this.btnNhacHoa.TabIndex = 2;
            this.btnNhacHoa.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aboutMeToolStripMenuItem.Text = "About me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // playlistdgv
            // 
            this.playlistdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistdgv.Location = new System.Drawing.Point(25, 228);
            this.playlistdgv.Name = "playlistdgv";
            this.playlistdgv.RowHeadersWidth = 51;
            this.playlistdgv.RowTemplate.Height = 24;
            this.playlistdgv.Size = new System.Drawing.Size(887, 373);
            this.playlistdgv.TabIndex = 6;
            // 
            // lblVietnam
            // 
            this.lblVietnam.AutoSize = true;
            this.lblVietnam.Location = new System.Drawing.Point(22, 41);
            this.lblVietnam.Name = "lblVietnam";
            this.lblVietnam.Size = new System.Drawing.Size(65, 17);
            this.lblVietnam.TabIndex = 7;
            this.lblVietnam.Text = "Việt Nam";
            // 
            // lblAuMy
            // 
            this.lblAuMy.AutoSize = true;
            this.lblAuMy.Location = new System.Drawing.Point(22, 77);
            this.lblAuMy.Name = "lblAuMy";
            this.lblAuMy.Size = new System.Drawing.Size(47, 17);
            this.lblAuMy.TabIndex = 8;
            this.lblAuMy.Text = "Âu Mỹ";
            // 
            // lblChauA
            // 
            this.lblChauA.AutoSize = true;
            this.lblChauA.Location = new System.Drawing.Point(22, 111);
            this.lblChauA.Name = "lblChauA";
            this.lblChauA.Size = new System.Drawing.Size(54, 17);
            this.lblChauA.TabIndex = 9;
            this.lblChauA.Text = "Châu Á";
            // 
            // lblKhac
            // 
            this.lblKhac.AutoSize = true;
            this.lblKhac.Location = new System.Drawing.Point(22, 146);
            this.lblKhac.Name = "lblKhac";
            this.lblKhac.Size = new System.Drawing.Size(40, 17);
            this.lblKhac.TabIndex = 10;
            this.lblKhac.Text = "Khác";
            // 
            // btnNhacTre
            // 
            this.btnNhacTre.BackColor = System.Drawing.Color.Transparent;
            this.btnNhacTre.Location = new System.Drawing.Point(120, 38);
            this.btnNhacTre.Name = "btnNhacTre";
            this.btnNhacTre.Size = new System.Drawing.Size(75, 23);
            this.btnNhacTre.TabIndex = 11;
            this.btnNhacTre.Text = "Nhạc trẻ";
            this.btnNhacTre.UseVisualStyleBackColor = false;
            this.btnNhacTre.Click += new System.EventHandler(this.btnNhacTre_Click);
            // 
            // btnTruTinh
            // 
            this.btnTruTinh.BackColor = System.Drawing.Color.Transparent;
            this.btnTruTinh.Location = new System.Drawing.Point(258, 38);
            this.btnTruTinh.Name = "btnTruTinh";
            this.btnTruTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTruTinh.TabIndex = 12;
            this.btnTruTinh.Text = "Trữ Tình";
            this.btnTruTinh.UseVisualStyleBackColor = false;
            this.btnTruTinh.Click += new System.EventHandler(this.btnTruTinh_Click);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.Transparent;
            this.btnPop.Location = new System.Drawing.Point(120, 77);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 13;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnRap
            // 
            this.btnRap.BackColor = System.Drawing.Color.Transparent;
            this.btnRap.Location = new System.Drawing.Point(258, 77);
            this.btnRap.Name = "btnRap";
            this.btnRap.Size = new System.Drawing.Size(75, 23);
            this.btnRap.TabIndex = 14;
            this.btnRap.Text = "Rap";
            this.btnRap.UseVisualStyleBackColor = false;
            this.btnRap.Click += new System.EventHandler(this.btnRap_Click);
            // 
            // btnNhacHan
            // 
            this.btnNhacHan.BackColor = System.Drawing.Color.Transparent;
            this.btnNhacHan.Location = new System.Drawing.Point(120, 111);
            this.btnNhacHan.Name = "btnNhacHan";
            this.btnNhacHan.Size = new System.Drawing.Size(106, 23);
            this.btnNhacHan.TabIndex = 15;
            this.btnNhacHan.Text = "Nhạc Hàn";
            this.btnNhacHan.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(258, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nhạc Hoa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBeat
            // 
            this.btnBeat.BackColor = System.Drawing.Color.Transparent;
            this.btnBeat.Location = new System.Drawing.Point(120, 146);
            this.btnBeat.Name = "btnBeat";
            this.btnBeat.Size = new System.Drawing.Size(106, 23);
            this.btnBeat.TabIndex = 17;
            this.btnBeat.Text = "Beat";
            this.btnBeat.UseVisualStyleBackColor = false;
            // 
            // btnKhongLoi
            // 
            this.btnKhongLoi.BackColor = System.Drawing.Color.Transparent;
            this.btnKhongLoi.Location = new System.Drawing.Point(258, 146);
            this.btnKhongLoi.Name = "btnKhongLoi";
            this.btnKhongLoi.Size = new System.Drawing.Size(106, 23);
            this.btnKhongLoi.TabIndex = 18;
            this.btnKhongLoi.Text = "Không Lời";
            this.btnKhongLoi.UseVisualStyleBackColor = false;
            // 
            // lblBaiHatHotNhat
            // 
            this.lblBaiHatHotNhat.AutoSize = true;
            this.lblBaiHatHotNhat.Location = new System.Drawing.Point(22, 198);
            this.lblBaiHatHotNhat.Name = "lblBaiHatHotNhat";
            this.lblBaiHatHotNhat.Size = new System.Drawing.Size(108, 17);
            this.lblBaiHatHotNhat.TabIndex = 19;
            this.lblBaiHatHotNhat.Text = "Bài hát hot nhất";
            // 
            // btnHotNhat
            // 
            this.btnHotNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnHotNhat.Location = new System.Drawing.Point(752, 199);
            this.btnHotNhat.Name = "btnHotNhat";
            this.btnHotNhat.Size = new System.Drawing.Size(75, 23);
            this.btnHotNhat.TabIndex = 20;
            this.btnHotNhat.Text = "Hot Nhất";
            this.btnHotNhat.UseVisualStyleBackColor = false;
            this.btnHotNhat.Click += new System.EventHandler(this.btnHotNhat_Click);
            // 
            // btnMoiNhat
            // 
            this.btnMoiNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnMoiNhat.Location = new System.Drawing.Point(833, 199);
            this.btnMoiNhat.Name = "btnMoiNhat";
            this.btnMoiNhat.Size = new System.Drawing.Size(75, 23);
            this.btnMoiNhat.TabIndex = 21;
            this.btnMoiNhat.Text = "Mới Nhất";
            this.btnMoiNhat.UseVisualStyleBackColor = false;
            this.btnMoiNhat.Click += new System.EventHandler(this.btnMoiNhat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(577, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbPlaylist
            // 
            this.cbPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaylist.FormattingEnabled = true;
            this.cbPlaylist.Location = new System.Drawing.Point(425, 41);
            this.cbPlaylist.Name = "cbPlaylist";
            this.cbPlaylist.Size = new System.Drawing.Size(227, 24);
            this.cbPlaylist.TabIndex = 23;
            // 
            // cbSong
            // 
            this.cbSong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSong.FormattingEnabled = true;
            this.cbSong.Location = new System.Drawing.Point(425, 77);
            this.cbSong.Name = "cbSong";
            this.cbSong.Size = new System.Drawing.Size(227, 24);
            this.cbSong.TabIndex = 24;
            // 
            // checkFavorties
            // 
            this.checkFavorties.AutoSize = true;
            this.checkFavorties.Location = new System.Drawing.Point(425, 113);
            this.checkFavorties.Name = "checkFavorties";
            this.checkFavorties.Size = new System.Drawing.Size(96, 21);
            this.checkFavorties.TabIndex = 25;
            this.checkFavorties.Text = "Favorites?";
            this.checkFavorties.UseVisualStyleBackColor = true;
            // 
            // btnCountSong
            // 
            this.btnCountSong.Location = new System.Drawing.Point(752, 110);
            this.btnCountSong.Name = "btnCountSong";
            this.btnCountSong.Size = new System.Drawing.Size(121, 32);
            this.btnCountSong.TabIndex = 26;
            this.btnCountSong.Text = "CountSong";
            this.btnCountSong.UseVisualStyleBackColor = true;
            this.btnCountSong.Click += new System.EventHandler(this.btnCountSong_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 609);
            this.Controls.Add(this.btnCountSong);
            this.Controls.Add(this.checkFavorties);
            this.Controls.Add(this.cbSong);
            this.Controls.Add(this.cbPlaylist);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMoiNhat);
            this.Controls.Add(this.btnHotNhat);
            this.Controls.Add(this.lblBaiHatHotNhat);
            this.Controls.Add(this.btnKhongLoi);
            this.Controls.Add(this.btnBeat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNhacHan);
            this.Controls.Add(this.btnRap);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnTruTinh);
            this.Controls.Add(this.btnNhacTre);
            this.Controls.Add(this.lblKhac);
            this.Controls.Add(this.lblChauA);
            this.Controls.Add(this.lblAuMy);
            this.Controls.Add(this.lblVietnam);
            this.Controls.Add(this.playlistdgv);
            this.Controls.Add(this.btnNhacHoa);
            this.MainMenuStrip = this.btnNhacHoa;
            this.Name = "FormMain";
            this.Text = "19125106HuynhTuanLuc";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.btnNhacHoa.ResumeLayout(false);
            this.btnNhacHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip btnNhacHoa;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.DataGridView playlistdgv;
        private System.Windows.Forms.Label lblVietnam;
        private System.Windows.Forms.Label lblAuMy;
        private System.Windows.Forms.Label lblChauA;
        private System.Windows.Forms.Label lblKhac;
        private System.Windows.Forms.Button btnNhacTre;
        private System.Windows.Forms.Button btnTruTinh;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnRap;
        private System.Windows.Forms.Button btnNhacHan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBeat;
        private System.Windows.Forms.Button btnKhongLoi;
        private System.Windows.Forms.Label lblBaiHatHotNhat;
        private System.Windows.Forms.Button btnHotNhat;
        private System.Windows.Forms.Button btnMoiNhat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbPlaylist;
        private System.Windows.Forms.ComboBox cbSong;
        private System.Windows.Forms.CheckBox checkFavorties;
        private System.Windows.Forms.Button btnCountSong;
    }
}

