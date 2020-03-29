namespace rmsDB
{
    partial class Sample
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.welcomepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.usrpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.welcomepanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.usrpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftpanel.Controls.Add(this.welcomepanel);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.ForeColor = System.Drawing.Color.White;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(265, 588);
            this.leftpanel.TabIndex = 0;
            // 
            // welcomepanel
            // 
            this.welcomepanel.Controls.Add(this.label1);
            this.welcomepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomepanel.Location = new System.Drawing.Point(0, 0);
            this.welcomepanel.Name = "welcomepanel";
            this.welcomepanel.Size = new System.Drawing.Size(265, 57);
            this.welcomepanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.usrpanel);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rightpanel.Location = new System.Drawing.Point(265, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(668, 588);
            this.rightpanel.TabIndex = 1;
            // 
            // usrpanel
            // 
            this.usrpanel.Controls.Add(this.label2);
            this.usrpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrpanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usrpanel.Location = new System.Drawing.Point(0, 0);
            this.usrpanel.Name = "usrpanel";
            this.usrpanel.Size = new System.Drawing.Size(668, 57);
            this.usrpanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.ControlBox = false;
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.leftpanel.ResumeLayout(false);
            this.welcomepanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.usrpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftpanel;
        public System.Windows.Forms.Panel welcomepanel;
        public System.Windows.Forms.Panel rightpanel;
        public System.Windows.Forms.Panel usrpanel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

