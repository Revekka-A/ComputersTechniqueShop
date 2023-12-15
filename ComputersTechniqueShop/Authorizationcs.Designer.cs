namespace WFAprepearing
{
    partial class Authorizationcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorizationcs));
            this.picture_close = new System.Windows.Forms.PictureBox();
            this.picture_open = new System.Windows.Forms.PictureBox();
            this.tbox_Passw = new System.Windows.Forms.TextBox();
            this.tbox_Login = new System.Windows.Forms.TextBox();
            this.labelPassw = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_close
            // 
            this.picture_close.BackColor = System.Drawing.Color.Transparent;
            this.picture_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_close.BackgroundImage")));
            this.picture_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_close.Location = new System.Drawing.Point(507, 117);
            this.picture_close.Name = "picture_close";
            this.picture_close.Size = new System.Drawing.Size(39, 33);
            this.picture_close.TabIndex = 36;
            this.picture_close.TabStop = false;
            this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
            // 
            // picture_open
            // 
            this.picture_open.BackColor = System.Drawing.Color.Transparent;
            this.picture_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_open.BackgroundImage")));
            this.picture_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_open.Location = new System.Drawing.Point(507, 117);
            this.picture_open.Name = "picture_open";
            this.picture_open.Size = new System.Drawing.Size(38, 32);
            this.picture_open.TabIndex = 35;
            this.picture_open.TabStop = false;
            this.picture_open.Click += new System.EventHandler(this.picture_open_Click);
            // 
            // tbox_Passw
            // 
            this.tbox_Passw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Passw.Location = new System.Drawing.Point(346, 128);
            this.tbox_Passw.Multiline = true;
            this.tbox_Passw.Name = "tbox_Passw";
            this.tbox_Passw.Size = new System.Drawing.Size(141, 20);
            this.tbox_Passw.TabIndex = 34;
            // 
            // tbox_Login
            // 
            this.tbox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Login.Location = new System.Drawing.Point(346, 91);
            this.tbox_Login.Multiline = true;
            this.tbox_Login.Name = "tbox_Login";
            this.tbox_Login.Size = new System.Drawing.Size(141, 20);
            this.tbox_Login.TabIndex = 33;
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.BackColor = System.Drawing.Color.Transparent;
            this.labelPassw.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassw.Location = new System.Drawing.Point(283, 128);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(54, 17);
            this.labelPassw.TabIndex = 32;
            this.labelPassw.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogin.Location = new System.Drawing.Point(283, 93);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 17);
            this.labelLogin.TabIndex = 31;
            this.labelLogin.Text = "Логин";
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonAccount.Location = new System.Drawing.Point(335, 195);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(172, 35);
            this.buttonAccount.TabIndex = 30;
            this.buttonAccount.Text = "Вход";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAccount.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccount.ForeColor = System.Drawing.Color.Black;
            this.labelAccount.Location = new System.Drawing.Point(340, 22);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(155, 32);
            this.labelAccount.TabIndex = 29;
            this.labelAccount.Text = "Авторизация";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WFAprepearing.Properties.Resources.comp31;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Authorizationcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picture_close);
            this.Controls.Add(this.picture_open);
            this.Controls.Add(this.tbox_Passw);
            this.Controls.Add(this.tbox_Login);
            this.Controls.Add(this.labelPassw);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.labelAccount);
            this.Name = "Authorizationcs";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorizationcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_close;
        private System.Windows.Forms.PictureBox picture_open;
        private System.Windows.Forms.TextBox tbox_Passw;
        private System.Windows.Forms.TextBox tbox_Login;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}