
namespace multiPingTest
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbExplain = new System.Windows.Forms.TextBox();
            this.btnAddIp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPingTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveToExcell = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.tbReplyTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAsync = new System.Windows.Forms.CheckBox();
            this.cbSync = new System.Windows.Forms.CheckBox();
            this.btnStopSendPing = new System.Windows.Forms.Button();
            this.btnStartSendPing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIpAdresses = new System.Windows.Forms.ComboBox();
            this.dgvIpAddresses = new System.Windows.Forms.DataGridView();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbExplain);
            this.groupBox1.Controls.Add(this.btnAddIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbIpAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(291, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ip Ekleme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Açıklama :";
            // 
            // tbExplain
            // 
            this.tbExplain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExplain.Location = new System.Drawing.Point(98, 100);
            this.tbExplain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbExplain.Name = "tbExplain";
            this.tbExplain.Size = new System.Drawing.Size(150, 25);
            this.tbExplain.TabIndex = 3;
            // 
            // btnAddIp
            // 
            this.btnAddIp.FlatAppearance.BorderSize = 0;
            this.btnAddIp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddIp.Location = new System.Drawing.Point(41, 133);
            this.btnAddIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddIp.Name = "btnAddIp";
            this.btnAddIp.Size = new System.Drawing.Size(207, 54);
            this.btnAddIp.TabIndex = 2;
            this.btnAddIp.Text = "Ip Adresini Ekle";
            this.btnAddIp.UseVisualStyleBackColor = true;
            this.btnAddIp.Click += new System.EventHandler(this.btnAddIp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ip Adresi :";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddress.Location = new System.Drawing.Point(98, 64);
            this.tbIpAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(150, 25);
            this.tbIpAddress.TabIndex = 0;
            this.tbIpAddress.TextChanged += new System.EventHandler(this.tbIpAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ping Atma Aralığı[ms] :";
            // 
            // tbPingTime
            // 
            this.tbPingTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPingTime.Location = new System.Drawing.Point(566, 50);
            this.tbPingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPingTime.Name = "tbPingTime";
            this.tbPingTime.Size = new System.Drawing.Size(191, 26);
            this.tbPingTime.TabIndex = 3;
            this.tbPingTime.TextChanged += new System.EventHandler(this.tbPingTime_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSaveToExcell);
            this.groupBox2.Controls.Add(this.btnStopAll);
            this.groupBox2.Controls.Add(this.tbReplyTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbAsync);
            this.groupBox2.Controls.Add(this.cbSync);
            this.groupBox2.Controls.Add(this.tbPingTime);
            this.groupBox2.Controls.Add(this.btnStopSendPing);
            this.groupBox2.Controls.Add(this.btnStartSendPing);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbIpAdresses);
            this.groupBox2.Location = new System.Drawing.Point(309, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(854, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ping Atma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ping Atma Tipi :";
            // 
            // btnSaveToExcell
            // 
            this.btnSaveToExcell.FlatAppearance.BorderSize = 0;
            this.btnSaveToExcell.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveToExcell.Location = new System.Drawing.Point(603, 150);
            this.btnSaveToExcell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveToExcell.Name = "btnSaveToExcell";
            this.btnSaveToExcell.Size = new System.Drawing.Size(173, 54);
            this.btnSaveToExcell.TabIndex = 12;
            this.btnSaveToExcell.Text = "Verileri Kaydet";
            this.btnSaveToExcell.UseVisualStyleBackColor = true;
            this.btnSaveToExcell.Click += new System.EventHandler(this.btnSaveToExcell_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.FlatAppearance.BorderSize = 0;
            this.btnStopAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStopAll.Location = new System.Drawing.Point(429, 150);
            this.btnStopAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(168, 54);
            this.btnStopAll.TabIndex = 11;
            this.btnStopAll.Text = "Tümünü Durdur";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // tbReplyTime
            // 
            this.tbReplyTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplyTime.Location = new System.Drawing.Point(566, 97);
            this.tbReplyTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReplyTime.Name = "tbReplyTime";
            this.tbReplyTime.Size = new System.Drawing.Size(191, 26);
            this.tbReplyTime.TabIndex = 9;
            this.tbReplyTime.TextChanged += new System.EventHandler(this.tbReplyTime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ping Cevap Limit[ms] :";
            // 
            // cbAsync
            // 
            this.cbAsync.AutoSize = true;
            this.cbAsync.Location = new System.Drawing.Point(200, 109);
            this.cbAsync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAsync.Name = "cbAsync";
            this.cbAsync.Size = new System.Drawing.Size(94, 23);
            this.cbAsync.TabIndex = 8;
            this.cbAsync.Text = "Asenkron";
            this.cbAsync.UseVisualStyleBackColor = true;
            this.cbAsync.CheckedChanged += new System.EventHandler(this.cbAsync_CheckedChanged);
            // 
            // cbSync
            // 
            this.cbSync.AutoSize = true;
            this.cbSync.Location = new System.Drawing.Point(200, 92);
            this.cbSync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSync.Name = "cbSync";
            this.cbSync.Size = new System.Drawing.Size(85, 23);
            this.cbSync.TabIndex = 7;
            this.cbSync.Text = "Senkron";
            this.cbSync.UseVisualStyleBackColor = true;
            this.cbSync.CheckedChanged += new System.EventHandler(this.cbSync_CheckedChanged);
            // 
            // btnStopSendPing
            // 
            this.btnStopSendPing.FlatAppearance.BorderSize = 0;
            this.btnStopSendPing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStopSendPing.Location = new System.Drawing.Point(250, 150);
            this.btnStopSendPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopSendPing.Name = "btnStopSendPing";
            this.btnStopSendPing.Size = new System.Drawing.Size(173, 54);
            this.btnStopSendPing.TabIndex = 6;
            this.btnStopSendPing.Text = "Durdur";
            this.btnStopSendPing.UseVisualStyleBackColor = true;
            this.btnStopSendPing.Click += new System.EventHandler(this.btnStopSendPing_Click);
            // 
            // btnStartSendPing
            // 
            this.btnStartSendPing.FlatAppearance.BorderSize = 0;
            this.btnStartSendPing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartSendPing.Location = new System.Drawing.Point(76, 150);
            this.btnStartSendPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartSendPing.Name = "btnStartSendPing";
            this.btnStartSendPing.Size = new System.Drawing.Size(168, 54);
            this.btnStartSendPing.TabIndex = 3;
            this.btnStartSendPing.Text = "Başlat";
            this.btnStartSendPing.UseVisualStyleBackColor = true;
            this.btnStartSendPing.Click += new System.EventHandler(this.btnStartSendPing_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ip Adresi :";
            // 
            // cmbIpAdresses
            // 
            this.cmbIpAdresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIpAdresses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIpAdresses.FormattingEnabled = true;
            this.cmbIpAdresses.Location = new System.Drawing.Point(197, 49);
            this.cmbIpAdresses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbIpAdresses.Name = "cmbIpAdresses";
            this.cmbIpAdresses.Size = new System.Drawing.Size(186, 26);
            this.cmbIpAdresses.TabIndex = 0;
            // 
            // dgvIpAddresses
            // 
            this.dgvIpAddresses.AllowUserToAddRows = false;
            this.dgvIpAddresses.AllowUserToDeleteRows = false;
            this.dgvIpAddresses.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvIpAddresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIpAddresses.ColumnHeadersHeight = 30;
            this.dgvIpAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aciklama,
            this.ipadresi,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
            this.dgvIpAddresses.Location = new System.Drawing.Point(12, 250);
            this.dgvIpAddresses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvIpAddresses.MultiSelect = false;
            this.dgvIpAddresses.Name = "dgvIpAddresses";
            this.dgvIpAddresses.ReadOnly = true;
            this.dgvIpAddresses.RowHeadersWidth = 40;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIpAddresses.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIpAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIpAddresses.Size = new System.Drawing.Size(1151, 464);
            this.dgvIpAddresses.TabIndex = 2;
            // 
            // aciklama
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.aciklama.DefaultCellStyle = dataGridViewCellStyle1;
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            this.aciklama.Width = 150;
            // 
            // ipadresi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ipadresi.DefaultCellStyle = dataGridViewCellStyle2;
            this.ipadresi.FillWeight = 200F;
            this.ipadresi.HeaderText = "IP Adresi";
            this.ipadresi.Name = "ipadresi";
            this.ipadresi.ReadOnly = true;
            this.ipadresi.Width = 170;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Limit Üstünde";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Limit Altında";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Toplam Ping";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Cevap Süresi [ms]";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Başarısız Süre [s]";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column4
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column4.HeaderText = "Durum";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // dataTimer
            // 
            this.dataTimer.Interval = 1000;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1172, 720);
            this.Controls.Add(this.dgvIpAddresses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Ping Test Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPingTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopSendPing;
        private System.Windows.Forms.Button btnStartSendPing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIpAdresses;
        private System.Windows.Forms.CheckBox cbAsync;
        private System.Windows.Forms.CheckBox cbSync;
        private System.Windows.Forms.TextBox tbReplyTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvIpAddresses;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Button btnSaveToExcell;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

