namespace rmsDB
{
    partial class Tables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablenumCB = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NOchairCB = new System.Windows.Forms.ComboBox();
            this.FloornumCB = new System.Windows.Forms.Label();
            this.FloorCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenumGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChairsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.welcomepanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.usrpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.FloorCB);
            this.leftpanel.Controls.Add(this.FloornumCB);
            this.leftpanel.Controls.Add(this.NOchairCB);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.comboBox1);
            this.leftpanel.Controls.Add(this.TablenumCB);
            this.leftpanel.Size = new System.Drawing.Size(265, 450);
            this.leftpanel.Controls.SetChildIndex(this.welcomepanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.TablenumCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.comboBox1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.NOchairCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.FloornumCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.FloorCB, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(535, 450);
            this.rightpanel.Controls.SetChildIndex(this.usrpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.btnpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // TablenumCB
            // 
            this.TablenumCB.AutoSize = true;
            this.TablenumCB.Location = new System.Drawing.Point(9, 137);
            this.TablenumCB.Name = "TablenumCB";
            this.TablenumCB.Size = new System.Drawing.Size(91, 17);
            this.TablenumCB.TabIndex = 2;
            this.TablenumCB.Text = "Table Number";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(10, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 25);
            this.comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "No of Chairs";
            // 
            // NOchairCB
            // 
            this.NOchairCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NOchairCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NOchairCB.FormattingEnabled = true;
            this.NOchairCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.NOchairCB.Location = new System.Drawing.Point(11, 212);
            this.NOchairCB.Name = "NOchairCB";
            this.NOchairCB.Size = new System.Drawing.Size(247, 25);
            this.NOchairCB.TabIndex = 2;
            // 
            // FloornumCB
            // 
            this.FloornumCB.AutoSize = true;
            this.FloornumCB.Location = new System.Drawing.Point(9, 249);
            this.FloornumCB.Name = "FloornumCB";
            this.FloornumCB.Size = new System.Drawing.Size(90, 17);
            this.FloornumCB.TabIndex = 2;
            this.FloornumCB.Text = "Floor Number";
            // 
            // FloorCB
            // 
            this.FloorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FloorCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FloorCB.FormattingEnabled = true;
            this.FloorCB.Location = new System.Drawing.Point(10, 269);
            this.FloorCB.Name = "FloorCB";
            this.FloorCB.Size = new System.Drawing.Size(247, 25);
            this.FloorCB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srnoGV,
            this.floorIDGV,
            this.nameGV,
            this.tableidGV,
            this.tablenumGV,
            this.ChairsGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(529, 296);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // srnoGV
            // 
            this.srnoGV.FillWeight = 10F;
            this.srnoGV.HeaderText = "";
            this.srnoGV.MaxInputLength = 34444;
            this.srnoGV.Name = "srnoGV";
            this.srnoGV.ReadOnly = true;
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "Floor ID";
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Floor Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // tableidGV
            // 
            this.tableidGV.HeaderText = "Table ID";
            this.tableidGV.Name = "tableidGV";
            this.tableidGV.ReadOnly = true;
            this.tableidGV.Visible = false;
            // 
            // tablenumGV
            // 
            this.tablenumGV.HeaderText = "Table Number";
            this.tablenumGV.Name = "tablenumGV";
            this.tablenumGV.ReadOnly = true;
            // 
            // ChairsGV
            // 
            this.ChairsGV.HeaderText = "Chairs";
            this.ChairsGV.Name = "ChairsGV";
            this.ChairsGV.ReadOnly = true;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Tables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.panel2.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.welcomepanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.usrpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TablenumCB;
        private System.Windows.Forms.ComboBox FloorCB;
        private System.Windows.Forms.Label FloornumCB;
        private System.Windows.Forms.ComboBox NOchairCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenumGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChairsGV;
    }
}