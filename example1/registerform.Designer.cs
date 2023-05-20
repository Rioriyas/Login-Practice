namespace example1
{
    partial class Regform
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
            this.Firstname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.pwdtext = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Registrationform = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.Location = new System.Drawing.Point(177, 93);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(102, 24);
            this.Firstname.TabIndex = 0;
            this.Firstname.Text = "Firstname";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.SkyBlue;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.DarkGreen;
            this.fname.Location = new System.Drawing.Point(310, 93);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(196, 29);
            this.fname.TabIndex = 4;
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(177, 152);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(99, 24);
            this.Lastname.TabIndex = 8;
            this.Lastname.Text = "Lastname";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(177, 209);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 24);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(176, 273);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 24);
            this.Password.TabIndex = 10;
            this.Password.Text = "Password";
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.SkyBlue;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.DarkGreen;
            this.lname.Location = new System.Drawing.Point(310, 149);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(196, 29);
            this.lname.TabIndex = 11;
            // 
            // emailtext
            // 
            this.emailtext.BackColor = System.Drawing.Color.SkyBlue;
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.ForeColor = System.Drawing.Color.DarkGreen;
            this.emailtext.Location = new System.Drawing.Point(310, 206);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(196, 29);
            this.emailtext.TabIndex = 12;
            // 
            // pwdtext
            // 
            this.pwdtext.BackColor = System.Drawing.Color.SkyBlue;
            this.pwdtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtext.ForeColor = System.Drawing.Color.DarkGreen;
            this.pwdtext.Location = new System.Drawing.Point(310, 268);
            this.pwdtext.Name = "pwdtext";
            this.pwdtext.Size = new System.Drawing.Size(196, 29);
            this.pwdtext.TabIndex = 13;
            // 
            // Submit
            // 
            this.Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Submit.BackColor = System.Drawing.Color.MediumBlue;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(310, 335);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(196, 41);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Registrationform
            // 
            this.Registrationform.AutoSize = true;
            this.Registrationform.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrationform.ForeColor = System.Drawing.Color.Brown;
            this.Registrationform.Location = new System.Drawing.Point(268, 20);
            this.Registrationform.Name = "Registrationform";
            this.Registrationform.Size = new System.Drawing.Size(314, 36);
            this.Registrationform.TabIndex = 15;
            this.Registrationform.Text = "REGISTRATION FORM";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Green;
            this.info.Location = new System.Drawing.Point(551, 268);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(15, 24);
            this.info.TabIndex = 16;
            this.info.Text = ".";
            // 
            // Regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Registrationform);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pwdtext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.Firstname);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Regform";
            this.Text = "Regform";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox pwdtext;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Registrationform;
        private System.Windows.Forms.Label info;
    }
}

