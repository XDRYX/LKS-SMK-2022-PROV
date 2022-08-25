namespace LKS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.btnTabProfile = new System.Windows.Forms.PictureBox();
            this.btnTabShop = new System.Windows.Forms.PictureBox();
            this.btnTabHistory = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Location = new System.Drawing.Point(765, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 34);
            this.panel5.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(63, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(36, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(653, 54);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(582, 54);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(46, 44);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCart.TabIndex = 8;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(36, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(82, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(134, 57);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(92, 20);
            this.labelWelcome.TabIndex = 9;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(134, 80);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(233, 20);
            this.labelDateTime.TabIndex = 11;
            this.labelDateTime.Text = "26 Oktober 2021, 080:00:59";
            // 
            // btnTabProfile
            // 
            this.btnTabProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnTabProfile.Image")));
            this.btnTabProfile.Location = new System.Drawing.Point(139, 140);
            this.btnTabProfile.Name = "btnTabProfile";
            this.btnTabProfile.Size = new System.Drawing.Size(101, 95);
            this.btnTabProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTabProfile.TabIndex = 12;
            this.btnTabProfile.TabStop = false;
            this.btnTabProfile.Click += new System.EventHandler(this.btnTabProfile_Click);
            // 
            // btnTabShop
            // 
            this.btnTabShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabShop.Image = ((System.Drawing.Image)(resources.GetObject("btnTabShop.Image")));
            this.btnTabShop.Location = new System.Drawing.Point(354, 140);
            this.btnTabShop.Name = "btnTabShop";
            this.btnTabShop.Size = new System.Drawing.Size(101, 95);
            this.btnTabShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTabShop.TabIndex = 13;
            this.btnTabShop.TabStop = false;
            this.btnTabShop.Click += new System.EventHandler(this.btnTabShop_Click);
            // 
            // btnTabHistory
            // 
            this.btnTabHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnTabHistory.Image")));
            this.btnTabHistory.Location = new System.Drawing.Point(560, 140);
            this.btnTabHistory.Name = "btnTabHistory";
            this.btnTabHistory.Size = new System.Drawing.Size(101, 95);
            this.btnTabHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTabHistory.TabIndex = 14;
            this.btnTabHistory.TabStop = false;
            this.btnTabHistory.Click += new System.EventHandler(this.btnTabHistory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "PROFILE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "SHOP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "TRANSACTION\r\nHISTORY\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTabHistory);
            this.Controls.Add(this.btnTabShop);
            this.Controls.Add(this.btnTabProfile);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTabHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox btnCart;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.PictureBox btnTabProfile;
        private System.Windows.Forms.PictureBox btnTabShop;
        private System.Windows.Forms.PictureBox btnTabHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}