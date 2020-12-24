namespace WindowsFormsApplication6
{
    partial class plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nextbuttom = new System.Windows.Forms.Button();
            this.skipbuttom = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.basic = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.Premium = new System.Windows.Forms.RadioButton();
            this.basicprice = new System.Windows.Forms.Label();
            this.standardprice = new System.Windows.Forms.Label();
            this.premiemprice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basicqua = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.premiumqua = new System.Windows.Forms.Label();
            this.standardqua = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.basicscreen = new System.Windows.Forms.Label();
            this.premiumscreen = new System.Windows.Forms.Label();
            this.standardscreen = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.basicqua.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.nextbuttom);
            this.panel5.Controls.Add(this.skipbuttom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 164);
            this.panel5.TabIndex = 27;
            // 
            // nextbuttom
            // 
            this.nextbuttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.nextbuttom.FlatAppearance.BorderSize = 0;
            this.nextbuttom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nextbuttom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.nextbuttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbuttom.Font = new System.Drawing.Font("Neuropolitical Rg", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbuttom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nextbuttom.Location = new System.Drawing.Point(52, 5);
            this.nextbuttom.Name = "nextbuttom";
            this.nextbuttom.Size = new System.Drawing.Size(177, 30);
            this.nextbuttom.TabIndex = 12;
            this.nextbuttom.Text = "Next";
            this.nextbuttom.UseVisualStyleBackColor = false;
            this.nextbuttom.Click += new System.EventHandler(this.nextbuttom_Click);
            // 
            // skipbuttom
            // 
            this.skipbuttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.skipbuttom.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.skipbuttom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skipbuttom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.skipbuttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipbuttom.Font = new System.Drawing.Font("Neuropolitical Rg", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipbuttom.ForeColor = System.Drawing.SystemColors.Window;
            this.skipbuttom.Location = new System.Drawing.Point(52, 41);
            this.skipbuttom.Name = "skipbuttom";
            this.skipbuttom.Size = new System.Drawing.Size(177, 30);
            this.skipbuttom.TabIndex = 13;
            this.skipbuttom.Text = "Skip";
            this.skipbuttom.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoEllipsis = true;
            this.label.Font = new System.Drawing.Font("Neuropolitical Rg", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(0, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(290, 32);
            this.label.TabIndex = 14;
            this.label.Text = "Pick Plan";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic.Location = new System.Drawing.Point(21, 129);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(65, 17);
            this.basic.TabIndex = 32;
            this.basic.TabStop = true;
            this.basic.Text = "BBBB";
            this.basic.UseVisualStyleBackColor = true;
            this.basic.CheckedChanged += new System.EventHandler(this.basic_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standard.Location = new System.Drawing.Point(95, 129);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(88, 17);
            this.standard.TabIndex = 33;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            this.standard.CheckedChanged += new System.EventHandler(this.standard_CheckedChanged);
            // 
            // Premium
            // 
            this.Premium.AutoSize = true;
            this.Premium.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Premium.Location = new System.Drawing.Point(201, 129);
            this.Premium.Name = "Premium";
            this.Premium.Size = new System.Drawing.Size(85, 17);
            this.Premium.TabIndex = 34;
            this.Premium.TabStop = true;
            this.Premium.Text = "Premium";
            this.Premium.UseVisualStyleBackColor = true;
            this.Premium.CheckedChanged += new System.EventHandler(this.Premium_CheckedChanged);
            // 
            // basicprice
            // 
            this.basicprice.AutoSize = true;
            this.basicprice.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicprice.Location = new System.Drawing.Point(18, 0);
            this.basicprice.Name = "basicprice";
            this.basicprice.Size = new System.Drawing.Size(16, 13);
            this.basicprice.TabIndex = 35;
            this.basicprice.Text = "a";
            // 
            // standardprice
            // 
            this.standardprice.AutoSize = true;
            this.standardprice.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardprice.Location = new System.Drawing.Point(118, 0);
            this.standardprice.Name = "standardprice";
            this.standardprice.Size = new System.Drawing.Size(47, 13);
            this.standardprice.TabIndex = 36;
            this.standardprice.Text = "7.99$";
            // 
            // premiemprice
            // 
            this.premiemprice.AutoSize = true;
            this.premiemprice.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiemprice.Location = new System.Drawing.Point(214, 0);
            this.premiemprice.Name = "premiemprice";
            this.premiemprice.Size = new System.Drawing.Size(51, 13);
            this.premiemprice.TabIndex = 37;
            this.premiemprice.Text = "12.99$";
            this.premiemprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.basicprice);
            this.panel1.Controls.Add(this.premiemprice);
            this.panel1.Controls.Add(this.standardprice);
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 27);
            this.panel1.TabIndex = 38;
            // 
            // basicqua
            // 
            this.basicqua.Controls.Add(this.label4);
            this.basicqua.Controls.Add(this.premiumqua);
            this.basicqua.Controls.Add(this.standardqua);
            this.basicqua.Location = new System.Drawing.Point(0, 204);
            this.basicqua.Name = "basicqua";
            this.basicqua.Size = new System.Drawing.Size(290, 27);
            this.basicqua.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "a";
            // 
            // premiumqua
            // 
            this.premiumqua.AutoSize = true;
            this.premiumqua.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumqua.Location = new System.Drawing.Point(214, 0);
            this.premiumqua.Name = "premiumqua";
            this.premiumqua.Size = new System.Drawing.Size(37, 13);
            this.premiumqua.TabIndex = 37;
            this.premiumqua.Text = "UHD";
            // 
            // standardqua
            // 
            this.standardqua.AutoSize = true;
            this.standardqua.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardqua.Location = new System.Drawing.Point(118, 0);
            this.standardqua.Name = "standardqua";
            this.standardqua.Size = new System.Drawing.Size(27, 13);
            this.standardqua.TabIndex = 36;
            this.standardqua.Text = "HD";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.basicscreen);
            this.panel3.Controls.Add(this.premiumscreen);
            this.panel3.Controls.Add(this.standardscreen);
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 27);
            this.panel3.TabIndex = 39;
            // 
            // basicscreen
            // 
            this.basicscreen.AutoSize = true;
            this.basicscreen.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicscreen.Location = new System.Drawing.Point(18, 0);
            this.basicscreen.Name = "basicscreen";
            this.basicscreen.Size = new System.Drawing.Size(16, 13);
            this.basicscreen.TabIndex = 35;
            this.basicscreen.Text = "a";
            // 
            // premiumscreen
            // 
            this.premiumscreen.AutoSize = true;
            this.premiumscreen.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumscreen.Location = new System.Drawing.Point(214, 0);
            this.premiumscreen.Name = "premiumscreen";
            this.premiumscreen.Size = new System.Drawing.Size(71, 13);
            this.premiumscreen.TabIndex = 37;
            this.premiumscreen.Text = "4 Screen";
            // 
            // standardscreen
            // 
            this.standardscreen.AutoSize = true;
            this.standardscreen.Font = new System.Drawing.Font("Neuropolitical Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardscreen.Location = new System.Drawing.Point(118, 0);
            this.standardscreen.Name = "standardscreen";
            this.standardscreen.Size = new System.Drawing.Size(70, 13);
            this.standardscreen.TabIndex = 36;
            this.standardscreen.Text = "2 Screen";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel4.Location = new System.Drawing.Point(87, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 140);
            this.panel4.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel6.Location = new System.Drawing.Point(193, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 140);
            this.panel6.TabIndex = 41;
            // 
            // close
            // 
            this.close.BackgroundImage = global::WindowsFormsApplication6.Properties.Resources.close11;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Location = new System.Drawing.Point(270, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 42;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(290, 452);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.basicqua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Premium);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.basic);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "plan";
            this.Load += new System.EventHandler(this.plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.basicqua.ResumeLayout(false);
            this.basicqua.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button nextbuttom;
        private System.Windows.Forms.Button skipbuttom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton basic;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton Premium;
        private System.Windows.Forms.Label basicprice;
        private System.Windows.Forms.Label standardprice;
        private System.Windows.Forms.Label premiemprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel basicqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label premiumqua;
        private System.Windows.Forms.Label standardqua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label basicscreen;
        private System.Windows.Forms.Label premiumscreen;
        private System.Windows.Forms.Label standardscreen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox close;
    }
}