namespace rmsDB
{
    partial class Settings
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
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.CheckBox();
            this.serverlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.usrlabel = new System.Windows.Forms.Label();
            this.databaselabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.CB);
            this.leftpanel.Controls.Add(this.saveBtn);
            this.leftpanel.Controls.Add(this.passwordTxt);
            this.leftpanel.Controls.Add(this.userTxt);
            this.leftpanel.Controls.Add(this.databaseTxt);
            this.leftpanel.Controls.Add(this.serverTxt);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.serverlabel);
            this.leftpanel.Controls.Add(this.databaselabel);
            this.leftpanel.Controls.Add(this.usrlabel);
            this.leftpanel.Controls.Add(this.passlabel);
            this.leftpanel.Size = new System.Drawing.Size(265, 450);
            this.leftpanel.Controls.SetChildIndex(this.passlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.usrlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaselabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.serverlabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.saveBtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.CB, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(535, 450);
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(5, 136);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(254, 25);
            this.serverTxt.TabIndex = 1;
            this.serverTxt.TextChanged += new System.EventHandler(this.serverTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "DataBase";
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(5, 184);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(254, 25);
            this.databaseTxt.TabIndex = 1;
            this.databaseTxt.TextChanged += new System.EventHandler(this.databaseTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "UserID";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(5, 232);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(254, 25);
            this.userTxt.TabIndex = 1;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(5, 280);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(254, 25);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(3, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(256, 49);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Location = new System.Drawing.Point(7, 312);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(136, 21);
            this.CB.TabIndex = 5;
            this.CB.Text = "Integrated Security";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // serverlabel
            // 
            this.serverlabel.AutoSize = true;
            this.serverlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.serverlabel.Location = new System.Drawing.Point(242, 123);
            this.serverlabel.Name = "serverlabel";
            this.serverlabel.Size = new System.Drawing.Size(13, 17);
            this.serverlabel.TabIndex = 6;
            this.serverlabel.Text = "*";
            this.serverlabel.Visible = false;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passlabel.Location = new System.Drawing.Point(241, 268);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(13, 17);
            this.passlabel.TabIndex = 7;
            this.passlabel.Text = "*";
            this.passlabel.Visible = false;
            // 
            // usrlabel
            // 
            this.usrlabel.AutoSize = true;
            this.usrlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.usrlabel.Location = new System.Drawing.Point(242, 219);
            this.usrlabel.Name = "usrlabel";
            this.usrlabel.Size = new System.Drawing.Size(13, 17);
            this.usrlabel.TabIndex = 8;
            this.usrlabel.Text = "*";
            this.usrlabel.Visible = false;
            // 
            // databaselabel
            // 
            this.databaselabel.AutoSize = true;
            this.databaselabel.ForeColor = System.Drawing.Color.DarkRed;
            this.databaselabel.Location = new System.Drawing.Point(242, 173);
            this.databaselabel.Name = "databaselabel";
            this.databaselabel.Size = new System.Drawing.Size(13, 17);
            this.databaselabel.TabIndex = 9;
            this.databaselabel.Text = "*";
            this.databaselabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox CB;
        private System.Windows.Forms.Label serverlabel;
        private System.Windows.Forms.Label databaselabel;
        private System.Windows.Forms.Label usrlabel;
        private System.Windows.Forms.Label passlabel;
    }
}