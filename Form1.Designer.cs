namespace ChatV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_loginText = new System.Windows.Forms.Label();
            this.lbl_exists = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_sendPrivate = new System.Windows.Forms.Button();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.txt_usrMsg = new System.Windows.Forms.TextBox();
            this.txt_publicChat = new System.Windows.Forms.TextBox();
            this.txt_privateChat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_loginText);
            this.panel1.Controls.Add(this.lbl_exists);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 475);
            this.panel1.TabIndex = 0;
            // 
            // lbl_loginText
            // 
            this.lbl_loginText.AutoSize = true;
            this.lbl_loginText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_loginText.Location = new System.Drawing.Point(159, 122);
            this.lbl_loginText.Name = "lbl_loginText";
            this.lbl_loginText.Size = new System.Drawing.Size(223, 45);
            this.lbl_loginText.TabIndex = 5;
            this.lbl_loginText.Text = "Login/Sign-up";
            // 
            // lbl_exists
            // 
            this.lbl_exists.AutoSize = true;
            this.lbl_exists.Location = new System.Drawing.Point(179, 304);
            this.lbl_exists.Name = "lbl_exists";
            this.lbl_exists.Size = new System.Drawing.Size(0, 15);
            this.lbl_exists.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(283, 278);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(179, 209);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(179, 23);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(179, 249);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(179, 23);
            this.txt_pass.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(179, 278);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_sendPrivate);
            this.panel2.Controls.Add(this.txt_pName);
            this.panel2.Controls.Add(this.btn_sendMsg);
            this.panel2.Controls.Add(this.txt_usrMsg);
            this.panel2.Controls.Add(this.txt_publicChat);
            this.panel2.Controls.Add(this.txt_privateChat);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 469);
            this.panel2.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_refresh.Location = new System.Drawing.Point(12, 442);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_sendPrivate
            // 
            this.btn_sendPrivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_sendPrivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendPrivate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sendPrivate.Location = new System.Drawing.Point(204, 431);
            this.btn_sendPrivate.Name = "btn_sendPrivate";
            this.btn_sendPrivate.Size = new System.Drawing.Size(122, 23);
            this.btn_sendPrivate.TabIndex = 5;
            this.btn_sendPrivate.Text = "Send private";
            this.btn_sendPrivate.UseVisualStyleBackColor = true;
            this.btn_sendPrivate.Click += new System.EventHandler(this.btn_sendPrivate_Click);
            // 
            // txt_pName
            // 
            this.txt_pName.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_pName.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_pName.Location = new System.Drawing.Point(204, 401);
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Size = new System.Drawing.Size(122, 23);
            this.txt_pName.TabIndex = 4;
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sendMsg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_sendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sendMsg.Location = new System.Drawing.Point(648, 401);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(140, 35);
            this.btn_sendMsg.TabIndex = 3;
            this.btn_sendMsg.Text = "Send";
            this.btn_sendMsg.UseVisualStyleBackColor = false;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // txt_usrMsg
            // 
            this.txt_usrMsg.BackColor = System.Drawing.Color.Black;
            this.txt_usrMsg.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_usrMsg.Location = new System.Drawing.Point(332, 401);
            this.txt_usrMsg.Multiline = true;
            this.txt_usrMsg.Name = "txt_usrMsg";
            this.txt_usrMsg.Size = new System.Drawing.Size(309, 35);
            this.txt_usrMsg.TabIndex = 2;
            this.txt_usrMsg.TextChanged += new System.EventHandler(this.txt_usrMsg_TextChanged);
            // 
            // txt_publicChat
            // 
            this.txt_publicChat.BackColor = System.Drawing.SystemColors.ControlText;
            this.txt_publicChat.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_publicChat.Location = new System.Drawing.Point(204, 11);
            this.txt_publicChat.Multiline = true;
            this.txt_publicChat.Name = "txt_publicChat";
            this.txt_publicChat.ReadOnly = true;
            this.txt_publicChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_publicChat.Size = new System.Drawing.Size(584, 383);
            this.txt_publicChat.TabIndex = 1;
            this.txt_publicChat.TextChanged += new System.EventHandler(this.txt_publicChat_TextChanged);
            // 
            // txt_privateChat
            // 
            this.txt_privateChat.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_privateChat.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_privateChat.Location = new System.Drawing.Point(13, 11);
            this.txt_privateChat.Multiline = true;
            this.txt_privateChat.Name = "txt_privateChat";
            this.txt_privateChat.ReadOnly = true;
            this.txt_privateChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_privateChat.Size = new System.Drawing.Size(185, 425);
            this.txt_privateChat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_exists;
        private System.Windows.Forms.Label lbl_loginText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_publicChat;
        private System.Windows.Forms.TextBox txt_privateChat;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.TextBox txt_usrMsg;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.Button btn_sendPrivate;
        private System.Windows.Forms.Button btn_refresh;
    }
}

