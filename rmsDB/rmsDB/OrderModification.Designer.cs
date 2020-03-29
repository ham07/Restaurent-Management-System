namespace rmsDB
{
    partial class OrderModification
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderIDCB = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemCB = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.quanLabel = new System.Windows.Forms.Label();
            this.quantiNum = new System.Windows.Forms.NumericUpDown();
            this.orderIDlistBox = new System.Windows.Forms.ListBox();
            this.cartBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt = new System.Windows.Forms.Label();
            this.totTxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perItemPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.welcomepanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.usrpanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpanel
            // 
            this.btnpanel.Size = new System.Drawing.Size(597, 73);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(90, 25);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 2;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.flowLayoutPanel1);
            this.leftpanel.Size = new System.Drawing.Size(265, 593);
            this.leftpanel.Controls.SetChildIndex(this.welcomepanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox2);
            this.rightpanel.Size = new System.Drawing.Size(597, 593);
            this.rightpanel.Controls.SetChildIndex(this.usrpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.btnpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // usrpanel
            // 
            this.usrpanel.Size = new System.Drawing.Size(597, 57);
            // 
            // label2
            // 
            this.label2.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.date);
            this.flowLayoutPanel1.Controls.Add(this.orderLabel);
            this.flowLayoutPanel1.Controls.Add(this.orderIDCB);
            this.flowLayoutPanel1.Controls.Add(this.itemLabel);
            this.flowLayoutPanel1.Controls.Add(this.itemCB);
            this.flowLayoutPanel1.Controls.Add(this.priceLabel);
            this.flowLayoutPanel1.Controls.Add(this.priceTxt);
            this.flowLayoutPanel1.Controls.Add(this.quanLabel);
            this.flowLayoutPanel1.Controls.Add(this.quantiNum);
            this.flowLayoutPanel1.Controls.Add(this.orderIDlistBox);
            this.flowLayoutPanel1.Controls.Add(this.cartBtn);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 463);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // date
            // 
            this.date.CustomFormat = "d-MMM-yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(3, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(255, 25);
            this.date.TabIndex = 2;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(3, 48);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(59, 17);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Order ID";
            // 
            // orderIDCB
            // 
            this.orderIDCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orderIDCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderIDCB.FormattingEnabled = true;
            this.orderIDCB.Location = new System.Drawing.Point(3, 68);
            this.orderIDCB.Name = "orderIDCB";
            this.orderIDCB.Size = new System.Drawing.Size(255, 25);
            this.orderIDCB.TabIndex = 1;
            this.orderIDCB.SelectedIndexChanged += new System.EventHandler(this.orderIDCB_SelectedIndexChanged);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(3, 96);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(71, 17);
            this.itemLabel.TabIndex = 15;
            this.itemLabel.Text = "Select Item";
            // 
            // itemCB
            // 
            this.itemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itemCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCB.FormattingEnabled = true;
            this.itemCB.Location = new System.Drawing.Point(3, 116);
            this.itemCB.Name = "itemCB";
            this.itemCB.Size = new System.Drawing.Size(255, 25);
            this.itemCB.TabIndex = 18;
            this.itemCB.SelectedIndexChanged += new System.EventHandler(this.itemCB_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(3, 144);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 17);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "Price";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(3, 164);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(255, 25);
            this.priceTxt.TabIndex = 17;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quanLabel
            // 
            this.quanLabel.AutoSize = true;
            this.quanLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLabel.Location = new System.Drawing.Point(3, 192);
            this.quanLabel.Name = "quanLabel";
            this.quanLabel.Size = new System.Drawing.Size(56, 17);
            this.quanLabel.TabIndex = 13;
            this.quanLabel.Text = "Quantity";
            this.quanLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // quantiNum
            // 
            this.quantiNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiNum.Location = new System.Drawing.Point(3, 212);
            this.quantiNum.Name = "quantiNum";
            this.quantiNum.Size = new System.Drawing.Size(255, 25);
            this.quantiNum.TabIndex = 14;
            this.quantiNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderIDlistBox
            // 
            this.orderIDlistBox.FormattingEnabled = true;
            this.orderIDlistBox.ItemHeight = 17;
            this.orderIDlistBox.Location = new System.Drawing.Point(3, 243);
            this.orderIDlistBox.Name = "orderIDlistBox";
            this.orderIDlistBox.Size = new System.Drawing.Size(120, 89);
            this.orderIDlistBox.TabIndex = 3;
            this.orderIDlistBox.Visible = false;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.Red;
            this.cartBtn.FlatAppearance.BorderSize = 2;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.Location = new System.Drawing.Point(3, 338);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(247, 62);
            this.cartBtn.TabIndex = 20;
            this.cartBtn.Text = "Add To Cart";
            this.cartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rmsDB.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(3, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 463);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 98);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.totTxt, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Firebrick;
            this.txt.Location = new System.Drawing.Point(298, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(290, 98);
            this.txt.TabIndex = 1;
            this.txt.Text = "0.00";
            this.txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totTxt
            // 
            this.totTxt.BackColor = System.Drawing.Color.White;
            this.totTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totTxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totTxt.ForeColor = System.Drawing.Color.Firebrick;
            this.totTxt.Location = new System.Drawing.Point(3, 0);
            this.totTxt.Name = "totTxt";
            this.totTxt.Size = new System.Drawing.Size(289, 98);
            this.totTxt.TabIndex = 0;
            this.totTxt.Text = "Total Amount";
            this.totTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.snoGV,
            this.orderIDGV,
            this.ItemIDGV,
            this.ItemGV,
            this.perItemPriceGV,
            this.quanGV,
            this.priceGV,
            this.totGV,
            this.deleteGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(591, 439);
            this.dataGridView1.TabIndex = 3;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 41;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "orderID";
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            this.orderIDGV.Visible = false;
            // 
            // ItemIDGV
            // 
            this.ItemIDGV.HeaderText = "Item ID";
            this.ItemIDGV.Name = "ItemIDGV";
            this.ItemIDGV.ReadOnly = true;
            this.ItemIDGV.Visible = false;
            // 
            // ItemGV
            // 
            this.ItemGV.HeaderText = "Item";
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.ReadOnly = true;
            // 
            // perItemPriceGV
            // 
            this.perItemPriceGV.HeaderText = "PUP";
            this.perItemPriceGV.Name = "perItemPriceGV";
            this.perItemPriceGV.ReadOnly = true;
            // 
            // quanGV
            // 
            this.quanGV.HeaderText = "Quantity";
            this.quanGV.Name = "quanGV";
            this.quanGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "Total Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // totGV
            // 
            this.totGV.HeaderText = "Total Amount";
            this.totGV.Name = "totGV";
            this.totGV.ReadOnly = true;
            this.totGV.Visible = false;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deleteGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "Remove";
            this.deleteGV.UseColumnTextForButtonValue = true;
            this.deleteGV.Width = 50;
            // 
            // OrderModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 593);
            this.Name = "OrderModification";
            this.Text = "OrderModification";
            this.Load += new System.EventHandler(this.OrderModification_Load);
            this.panel2.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.welcomepanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.usrpanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.ComboBox orderIDCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ListBox orderIDlistBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label totTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ComboBox itemCB;
        private System.Windows.Forms.Label quanLabel;
        private System.Windows.Forms.NumericUpDown quantiNum;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perItemPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}