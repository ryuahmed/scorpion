namespace WindowsFormsApplication6
{
    partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            this.usermenu = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.prfile = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.gradient_panel2 = new WindowsFormsApplication6.gradient_panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userdock = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.Label();
            this.gradient_panel1 = new WindowsFormsApplication6.gradient_panel();
            this.usermenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gradient_panel2.SuspendLayout();
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
            this.usermenu.Controls.Add(this.account);
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
            this.prfile.MouseLeave += new System.EventHandler(this.prfile_MouseLeave);
            this.prfile.MouseHover += new System.EventHandler(this.prfile_MouseHover);
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.account.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.account.Location = new System.Drawing.Point(0, 19);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(151, 19);
            this.account.TabIndex = 4;
            this.account.Text = "Account details";
            this.account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.account.MouseLeave += new System.EventHandler(this.account_MouseLeave);
            this.account.MouseHover += new System.EventHandler(this.account_MouseHover);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchpanel);
            this.panel1.Controls.Add(this.searchbar);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 695);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 50);
            this.label8.TabIndex = 9;
            this.label8.Text = "Coming soon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "Series";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 50);
            this.label6.TabIndex = 7;
            this.label6.Text = "Top";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "newest";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recomendation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trending";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "browse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Neuropolitical Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchpanel.Location = new System.Drawing.Point(0, 78);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(209, 1);
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
            this.searchbar.Size = new System.Drawing.Size(209, 23);
            this.searchbar.TabIndex = 0;
            this.searchbar.Text = "Search";
            this.searchbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // gradient_panel2
            // 
            this.gradient_panel2.angel = 120F;
            this.gradient_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gradient_panel2.bottomcolor = System.Drawing.Color.Empty;
            this.gradient_panel2.Controls.Add(this.minimize);
            this.gradient_panel2.Controls.Add(this.close);
            this.gradient_panel2.Controls.Add(this.pictureBox1);
            this.gradient_panel2.Controls.Add(this.userdock);
            this.gradient_panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_panel2.Location = new System.Drawing.Point(0, 0);
            this.gradient_panel2.Name = "gradient_panel2";
            this.gradient_panel2.Size = new System.Drawing.Size(1402, 32);
            this.gradient_panel2.TabIndex = 3;
            this.gradient_panel2.topcolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.gradient_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient_panel2_Paint);
            this.gradient_panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_panel2_MouseDown);
            this.gradient_panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_panel2_MouseMove);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
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
            // gradient_panel1
            // 
            this.gradient_panel1.angel = 0F;
            this.gradient_panel1.AutoScroll = true;
            this.gradient_panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gradient_panel1.BackColor = System.Drawing.Color.Transparent;
            this.gradient_panel1.bottomcolor = System.Drawing.Color.Empty;
            this.gradient_panel1.Location = new System.Drawing.Point(212, 34);
            this.gradient_panel1.Name = "gradient_panel1";
            this.gradient_panel1.Size = new System.Drawing.Size(1190, 695);
            this.gradient_panel1.TabIndex = 5;
            this.gradient_panel1.topcolor = System.Drawing.Color.Empty;
            this.gradient_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient_panel1_Paint);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1402, 730);
            this.Controls.Add(this.gradient_panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradient_panel1);
            this.Controls.Add(this.usermenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.view_Load);
            this.usermenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradient_panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label account;
        private gradient_panel gradient_panel2;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel userdock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private gradient_panel gradient_panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}