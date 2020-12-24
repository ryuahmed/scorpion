namespace WindowsFormsApplication6
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.usermenu = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.prfile = new System.Windows.Forms.Label();
            this.Noti = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingspanel = new System.Windows.Forms.Panel();
            this.profilepanel = new System.Windows.Forms.Panel();
            this.planpanel = new System.Windows.Forms.Panel();
            this.comingsoonpanel = new System.Windows.Forms.Panel();
            this.recomendationpanel = new System.Windows.Forms.Panel();
            this.trendingpanel = new System.Windows.Forms.Panel();
            this.browsepanel = new System.Windows.Forms.Panel();
            this.homepanel = new System.Windows.Forms.Panel();
            this.comingsoon = new System.Windows.Forms.Label();
            this.paln_menu = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Label();
            this.recomendation = new System.Windows.Forms.Label();
            this.trending = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Label();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gradient_panel2 = new WindowsFormsApplication6.gradient_panel();
            this.adminicon = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userdock = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.Label();
            this.usermenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gradient_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userdock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usermenu
            // 
            this.usermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usermenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usermenu.Controls.Add(this.logout);
            this.usermenu.Controls.Add(this.prfile);
            this.usermenu.Controls.Add(this.Noti);
            this.usermenu.Controls.Add(this.settings);
            this.usermenu.Location = new System.Drawing.Point(1192, 35);
            this.usermenu.Name = "usermenu";
            this.usermenu.Size = new System.Drawing.Size(151, 76);
            this.usermenu.TabIndex = 1;
            this.usermenu.Visible = false;
            this.usermenu.VisibleChanged += new System.EventHandler(this.usermenu_VisibleChanged);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logout.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.logout.Location = new System.Drawing.Point(0, 57);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(151, 19);
            this.logout.TabIndex = 6;
            this.logout.Text = "Log out";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // prfile
            // 
            this.prfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prfile.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.prfile.Location = new System.Drawing.Point(-3, 0);
            this.prfile.Name = "prfile";
            this.prfile.Size = new System.Drawing.Size(154, 19);
            this.prfile.TabIndex = 3;
            this.prfile.Text = "View my profile";
            this.prfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prfile.Click += new System.EventHandler(this.prfile_Click);
            this.prfile.MouseLeave += new System.EventHandler(this.prfile_MouseLeave);
            this.prfile.MouseHover += new System.EventHandler(this.prfile_MouseHover);
            // 
            // Noti
            // 
            this.Noti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Noti.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Noti.Location = new System.Drawing.Point(0, 19);
            this.Noti.Name = "Noti";
            this.Noti.Size = new System.Drawing.Size(151, 19);
            this.Noti.TabIndex = 4;
            this.Noti.Text = "Notification";
            this.Noti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Noti.MouseLeave += new System.EventHandler(this.account_MouseLeave);
            this.Noti.MouseHover += new System.EventHandler(this.account_MouseHover);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settings.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.settings.Location = new System.Drawing.Point(-3, 38);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(154, 19);
            this.settings.TabIndex = 5;
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            this.settings.MouseHover += new System.EventHandler(this.settings_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.settingspanel);
            this.panel1.Controls.Add(this.profilepanel);
            this.panel1.Controls.Add(this.planpanel);
            this.panel1.Controls.Add(this.comingsoonpanel);
            this.panel1.Controls.Add(this.recomendationpanel);
            this.panel1.Controls.Add(this.trendingpanel);
            this.panel1.Controls.Add(this.browsepanel);
            this.panel1.Controls.Add(this.homepanel);
            this.panel1.Controls.Add(this.comingsoon);
            this.panel1.Controls.Add(this.paln_menu);
            this.panel1.Controls.Add(this.profile);
            this.panel1.Controls.Add(this.recomendation);
            this.panel1.Controls.Add(this.trending);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.searchpanel);
            this.panel1.Controls.Add(this.searchbar);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 705);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // settingspanel
            // 
            this.settingspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.settingspanel.Location = new System.Drawing.Point(0, 645);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(12, 50);
            this.settingspanel.TabIndex = 12;
            // 
            // profilepanel
            // 
            this.profilepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.profilepanel.Location = new System.Drawing.Point(0, 545);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(12, 50);
            this.profilepanel.TabIndex = 12;
            // 
            // planpanel
            // 
            this.planpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.planpanel.Location = new System.Drawing.Point(0, 595);
            this.planpanel.Name = "planpanel";
            this.planpanel.Size = new System.Drawing.Size(12, 50);
            this.planpanel.TabIndex = 12;
            // 
            // comingsoonpanel
            // 
            this.comingsoonpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.comingsoonpanel.Location = new System.Drawing.Point(0, 495);
            this.comingsoonpanel.Name = "comingsoonpanel";
            this.comingsoonpanel.Size = new System.Drawing.Size(12, 50);
            this.comingsoonpanel.TabIndex = 12;
            // 
            // recomendationpanel
            // 
            this.recomendationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.recomendationpanel.Location = new System.Drawing.Point(0, 445);
            this.recomendationpanel.Name = "recomendationpanel";
            this.recomendationpanel.Size = new System.Drawing.Size(12, 50);
            this.recomendationpanel.TabIndex = 12;
            // 
            // trendingpanel
            // 
            this.trendingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.trendingpanel.Location = new System.Drawing.Point(0, 395);
            this.trendingpanel.Name = "trendingpanel";
            this.trendingpanel.Size = new System.Drawing.Size(12, 50);
            this.trendingpanel.TabIndex = 12;
            // 
            // browsepanel
            // 
            this.browsepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.browsepanel.Location = new System.Drawing.Point(0, 345);
            this.browsepanel.Name = "browsepanel";
            this.browsepanel.Size = new System.Drawing.Size(12, 50);
            this.browsepanel.TabIndex = 11;
            // 
            // homepanel
            // 
            this.homepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.homepanel.Location = new System.Drawing.Point(0, 295);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(12, 50);
            this.homepanel.TabIndex = 10;
            // 
            // comingsoon
            // 
            this.comingsoon.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingsoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.comingsoon.Location = new System.Drawing.Point(0, 495);
            this.comingsoon.Name = "comingsoon";
            this.comingsoon.Size = new System.Drawing.Size(217, 50);
            this.comingsoon.TabIndex = 9;
            this.comingsoon.Text = "Coming soon";
            this.comingsoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comingsoon.Click += new System.EventHandler(this.comingsoon_Click);
            this.comingsoon.MouseLeave += new System.EventHandler(this.comingsoon_MouseLeave);
            this.comingsoon.MouseHover += new System.EventHandler(this.comingsoon_MouseHover);
            // 
            // paln_menu
            // 
            this.paln_menu.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paln_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.paln_menu.Location = new System.Drawing.Point(0, 595);
            this.paln_menu.Name = "paln_menu";
            this.paln_menu.Size = new System.Drawing.Size(217, 50);
            this.paln_menu.TabIndex = 8;
            this.paln_menu.Text = "Plan";
            this.paln_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paln_menu.Click += new System.EventHandler(this.paln_menu_Click);
            this.paln_menu.MouseLeave += new System.EventHandler(this.paln_menu_MouseLeave);
            this.paln_menu.MouseHover += new System.EventHandler(this.paln_menu_MouseHover);
            // 
            // profile
            // 
            this.profile.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.profile.Location = new System.Drawing.Point(0, 545);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(217, 50);
            this.profile.TabIndex = 7;
            this.profile.Text = "Profile";
            this.profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            this.profile.MouseLeave += new System.EventHandler(this.profile_MouseLeave);
            this.profile.MouseHover += new System.EventHandler(this.profile_MouseHover);
            // 
            // recomendation
            // 
            this.recomendation.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recomendation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.recomendation.Location = new System.Drawing.Point(0, 445);
            this.recomendation.Name = "recomendation";
            this.recomendation.Size = new System.Drawing.Size(217, 50);
            this.recomendation.TabIndex = 6;
            this.recomendation.Text = "Recomendation";
            this.recomendation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recomendation.Click += new System.EventHandler(this.recomendation_Click);
            this.recomendation.MouseLeave += new System.EventHandler(this.recomendation_MouseLeave);
            this.recomendation.MouseHover += new System.EventHandler(this.recomendation_MouseHover);
            // 
            // trending
            // 
            this.trending.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trending.Location = new System.Drawing.Point(0, 395);
            this.trending.Name = "trending";
            this.trending.Size = new System.Drawing.Size(217, 50);
            this.trending.TabIndex = 5;
            this.trending.Text = "Trending";
            this.trending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trending.Click += new System.EventHandler(this.trending_Click);
            this.trending.MouseLeave += new System.EventHandler(this.trending_MouseLeave);
            this.trending.MouseHover += new System.EventHandler(this.trending_MouseHover);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.browse.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.browse.Location = new System.Drawing.Point(0, 345);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(217, 50);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            this.browse.MouseLeave += new System.EventHandler(this.browse_MouseLeave);
            this.browse.MouseHover += new System.EventHandler(this.browse_MouseHover);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.home.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.home.Location = new System.Drawing.Point(0, 295);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(217, 50);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            this.home.MouseHover += new System.EventHandler(this.home_MouseHover);
            // 
            // setting
            // 
            this.setting.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.setting.Location = new System.Drawing.Point(0, 645);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(217, 50);
            this.setting.TabIndex = 2;
            this.setting.Text = "Settings";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            this.setting.MouseLeave += new System.EventHandler(this.setting_MouseLeave);
            this.setting.MouseHover += new System.EventHandler(this.setting_MouseHover);
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchpanel.Location = new System.Drawing.Point(0, 78);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(220, 1);
            this.searchpanel.TabIndex = 1;
            // 
            // searchbar
            // 
            this.searchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.searchbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbar.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.searchbar.Location = new System.Drawing.Point(0, 49);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(217, 23);
            this.searchbar.TabIndex = 0;
            this.searchbar.Text = "Search";
            this.searchbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            this.searchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbar_KeyDown);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gradient_panel2
            // 
            this.gradient_panel2.angel = 120F;
            this.gradient_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gradient_panel2.bottomcolor = System.Drawing.Color.Empty;
            this.gradient_panel2.Controls.Add(this.adminicon);
            this.gradient_panel2.Controls.Add(this.minimize);
            this.gradient_panel2.Controls.Add(this.close);
            this.gradient_panel2.Controls.Add(this.pictureBox1);
            this.gradient_panel2.Controls.Add(this.userdock);
            this.gradient_panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_panel2.Location = new System.Drawing.Point(0, 0);
            this.gradient_panel2.Name = "gradient_panel2";
            this.gradient_panel2.Size = new System.Drawing.Size(1402, 32);
            this.gradient_panel2.TabIndex = 3;
            this.gradient_panel2.topcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.gradient_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient_panel2_Paint);
            this.gradient_panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_panel2_MouseDown);
            this.gradient_panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_panel2_MouseMove);
            // 
            // adminicon
            // 
            this.adminicon.BackColor = System.Drawing.Color.Transparent;
            this.adminicon.BackgroundImage = global::WindowsFormsApplication6.Properties.Resources.admin;
            this.adminicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminicon.Location = new System.Drawing.Point(1155, 0);
            this.adminicon.Name = "adminicon";
            this.adminicon.Size = new System.Drawing.Size(32, 32);
            this.adminicon.TabIndex = 3;
            this.adminicon.TabStop = false;
            this.adminicon.Visible = false;
            this.adminicon.Click += new System.EventHandler(this.adminicon_Click);
            this.adminicon.DoubleClick += new System.EventHandler(this.adminicon_DoubleClick);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Image = global::WindowsFormsApplication6.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(1346, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 44;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Image = global::WindowsFormsApplication6.Properties.Resources.close1;
            this.close.Location = new System.Drawing.Point(1372, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 43;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userdock
            // 
            this.userdock.BackColor = System.Drawing.Color.Transparent;
            this.userdock.Controls.Add(this.pictureBox2);
            this.userdock.Controls.Add(this.id);
            this.userdock.Location = new System.Drawing.Point(1192, 1);
            this.userdock.Name = "userdock";
            this.userdock.Size = new System.Drawing.Size(151, 30);
            this.userdock.TabIndex = 2;
            this.userdock.Click += new System.EventHandler(this.userdock_Click);
            this.userdock.MouseHover += new System.EventHandler(this.userdock_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Neuropolitical Rg", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.id.Location = new System.Drawing.Point(27, 6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(121, 15);
            this.id.TabIndex = 1;
            this.id.Text = "user name";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1402, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradient_panel2);
            this.Controls.Add(this.usermenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.usermenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gradient_panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userdock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel usermenu;
        private System.Windows.Forms.Label prfile;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.Label Noti;
        private gradient_panel gradient_panel2;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel userdock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Label setting;
        private System.Windows.Forms.Label comingsoon;
        private System.Windows.Forms.Label paln_menu;
        private System.Windows.Forms.Label profile;
        private System.Windows.Forms.Label recomendation;
        private System.Windows.Forms.Label trending;
        private System.Windows.Forms.Label browse;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Panel profilepanel;
        private System.Windows.Forms.Panel planpanel;
        private System.Windows.Forms.Panel comingsoonpanel;
        private System.Windows.Forms.Panel recomendationpanel;
        private System.Windows.Forms.Panel trendingpanel;
        private System.Windows.Forms.Panel browsepanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox adminicon;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}