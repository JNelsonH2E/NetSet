namespace NetSet
{
    partial class PingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingList));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Paste = new System.Windows.Forms.Button();
            this.Btn_NetSet = new System.Windows.Forms.Button();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Btn_CMD = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.Btn_SaveAs = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_IPCfg = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Ping = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IP_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 12);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 12);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 9);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Jeff Nelson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 9);
            this.label1.TabIndex = 0;
            this.label1.Text = "ver 2.1.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Btn_Paste);
            this.panel1.Controls.Add(this.Btn_NetSet);
            this.panel1.Controls.Add(this.Btn_Open);
            this.panel1.Controls.Add(this.Btn_CMD);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Help);
            this.panel1.Controls.Add(this.Btn_SaveAs);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.Btn_IPCfg);
            this.panel1.Controls.Add(this.Btn_New);
            this.panel1.Controls.Add(this.Btn_Ping);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 494);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Paste
            // 
            this.Btn_Paste.BackColor = System.Drawing.Color.Black;
            this.Btn_Paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Paste.FlatAppearance.BorderSize = 0;
            this.Btn_Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Paste.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Paste.ForeColor = System.Drawing.Color.White;
            this.Btn_Paste.Location = new System.Drawing.Point(0, 173);
            this.Btn_Paste.Name = "Btn_Paste";
            this.Btn_Paste.Size = new System.Drawing.Size(98, 26);
            this.Btn_Paste.TabIndex = 20;
            this.Btn_Paste.Text = "Paste";
            this.Btn_Paste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_Paste, "Right Click for HELP!");
            this.Btn_Paste.UseVisualStyleBackColor = false;
            this.Btn_Paste.Click += new System.EventHandler(this.Btn_Paste_Click);
            this.Btn_Paste.MouseLeave += new System.EventHandler(this.Btn_Paste_MouseLeave);
            this.Btn_Paste.MouseHover += new System.EventHandler(this.Btn_Paste_MouseHover);
            // 
            // Btn_NetSet
            // 
            this.Btn_NetSet.BackColor = System.Drawing.Color.Black;
            this.Btn_NetSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NetSet.FlatAppearance.BorderSize = 0;
            this.Btn_NetSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NetSet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NetSet.ForeColor = System.Drawing.Color.White;
            this.Btn_NetSet.Location = new System.Drawing.Point(0, 429);
            this.Btn_NetSet.Name = "Btn_NetSet";
            this.Btn_NetSet.Size = new System.Drawing.Size(98, 26);
            this.Btn_NetSet.TabIndex = 19;
            this.Btn_NetSet.Text = "NetSet";
            this.Btn_NetSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_NetSet, "Right Click for HELP!");
            this.Btn_NetSet.UseVisualStyleBackColor = false;
            this.Btn_NetSet.Click += new System.EventHandler(this.Btn_NetSet_Click);
            this.Btn_NetSet.MouseLeave += new System.EventHandler(this.Btn_NetSet_MouseLeave);
            this.Btn_NetSet.MouseHover += new System.EventHandler(this.Btn_NetSet_MouseHover);
            // 
            // Btn_Open
            // 
            this.Btn_Open.BackColor = System.Drawing.Color.Black;
            this.Btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Open.FlatAppearance.BorderSize = 0;
            this.Btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Open.ForeColor = System.Drawing.Color.White;
            this.Btn_Open.Location = new System.Drawing.Point(0, 86);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(98, 26);
            this.Btn_Open.TabIndex = 18;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_Open, "Right Click for HELP!");
            this.Btn_Open.UseVisualStyleBackColor = false;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            this.Btn_Open.MouseLeave += new System.EventHandler(this.Btn_Open_MouseLeave);
            this.Btn_Open.MouseHover += new System.EventHandler(this.Btn_Open_MouseHover);
            // 
            // Btn_CMD
            // 
            this.Btn_CMD.BackColor = System.Drawing.Color.Black;
            this.Btn_CMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CMD.FlatAppearance.BorderSize = 0;
            this.Btn_CMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CMD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CMD.ForeColor = System.Drawing.Color.White;
            this.Btn_CMD.Location = new System.Drawing.Point(0, 256);
            this.Btn_CMD.Name = "Btn_CMD";
            this.Btn_CMD.Size = new System.Drawing.Size(98, 26);
            this.Btn_CMD.TabIndex = 17;
            this.Btn_CMD.Text = "CMD";
            this.Btn_CMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_CMD, "Right Click for HELP!");
            this.Btn_CMD.UseVisualStyleBackColor = false;
            this.Btn_CMD.Click += new System.EventHandler(this.Btn_CMD_Click);
            this.Btn_CMD.MouseLeave += new System.EventHandler(this.Btn_CMD_MouseLeave);
            this.Btn_CMD.MouseHover += new System.EventHandler(this.Btn_CMD_MouseHover);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Black;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(0, 304);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(98, 26);
            this.Btn_Delete.TabIndex = 16;
            this.Btn_Delete.Text = "Delete Row";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_Delete, "Right Click for HELP!");
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.Btn_Delete_MouseLeave);
            this.Btn_Delete.MouseHover += new System.EventHandler(this.Btn_Delete_MouseHover);
            // 
            // Btn_Help
            // 
            this.Btn_Help.BackColor = System.Drawing.Color.Black;
            this.Btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Help.FlatAppearance.BorderSize = 0;
            this.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Help.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Help.ForeColor = System.Drawing.Color.White;
            this.Btn_Help.Location = new System.Drawing.Point(0, 458);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(98, 26);
            this.Btn_Help.TabIndex = 15;
            this.Btn_Help.Text = "Help";
            this.Btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Help.UseVisualStyleBackColor = false;
            this.Btn_Help.Click += new System.EventHandler(this.Btn_Help_Click);
            this.Btn_Help.MouseLeave += new System.EventHandler(this.Btn_Help_MouseLeave);
            this.Btn_Help.MouseHover += new System.EventHandler(this.Btn_Help_MouseHover);
            // 
            // Btn_SaveAs
            // 
            this.Btn_SaveAs.BackColor = System.Drawing.Color.Black;
            this.Btn_SaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveAs.FlatAppearance.BorderSize = 0;
            this.Btn_SaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveAs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveAs.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveAs.Location = new System.Drawing.Point(0, 144);
            this.Btn_SaveAs.Name = "Btn_SaveAs";
            this.Btn_SaveAs.Size = new System.Drawing.Size(98, 26);
            this.Btn_SaveAs.TabIndex = 14;
            this.Btn_SaveAs.Text = "Save As";
            this.Btn_SaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_SaveAs, "Right Click for HELP!");
            this.Btn_SaveAs.UseVisualStyleBackColor = false;
            this.Btn_SaveAs.Click += new System.EventHandler(this.Btn_SaveAs_Click);
            this.Btn_SaveAs.MouseLeave += new System.EventHandler(this.Btn_SaveAs_MouseLeave);
            this.Btn_SaveAs.MouseHover += new System.EventHandler(this.Btn_SaveAs_MouseHover);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Black;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(0, 115);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(98, 26);
            this.Btn_Save.TabIndex = 9;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_Save, "Right Click for HELP!");
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.Btn_Save.MouseLeave += new System.EventHandler(this.Btn_Save_MouseLeave);
            this.Btn_Save.MouseHover += new System.EventHandler(this.Btn_Save_MouseHover);
            // 
            // Btn_IPCfg
            // 
            this.Btn_IPCfg.BackColor = System.Drawing.Color.Black;
            this.Btn_IPCfg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_IPCfg.FlatAppearance.BorderSize = 0;
            this.Btn_IPCfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IPCfg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IPCfg.ForeColor = System.Drawing.Color.White;
            this.Btn_IPCfg.Location = new System.Drawing.Point(0, 227);
            this.Btn_IPCfg.Name = "Btn_IPCfg";
            this.Btn_IPCfg.Size = new System.Drawing.Size(98, 26);
            this.Btn_IPCfg.TabIndex = 8;
            this.Btn_IPCfg.Text = "IpConfig";
            this.Btn_IPCfg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_IPCfg, "Right Click for HELP!");
            this.Btn_IPCfg.UseVisualStyleBackColor = false;
            this.Btn_IPCfg.Click += new System.EventHandler(this.Btn_IPCfg_Click);
            this.Btn_IPCfg.MouseLeave += new System.EventHandler(this.Btn_IPCfg_MouseLeave);
            this.Btn_IPCfg.MouseHover += new System.EventHandler(this.Btn_IPCfg_MouseHover);
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.Black;
            this.Btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_New.FlatAppearance.BorderSize = 0;
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Location = new System.Drawing.Point(0, 57);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(98, 26);
            this.Btn_New.TabIndex = 7;
            this.Btn_New.Text = "New";
            this.Btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_New, "Right Click for HELP!");
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            this.Btn_New.MouseLeave += new System.EventHandler(this.Btn_New_MouseLeave);
            this.Btn_New.MouseHover += new System.EventHandler(this.Btn_New_MouseHover);
            // 
            // Btn_Ping
            // 
            this.Btn_Ping.BackColor = System.Drawing.Color.Black;
            this.Btn_Ping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ping.FlatAppearance.BorderSize = 0;
            this.Btn_Ping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ping.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ping.ForeColor = System.Drawing.Color.White;
            this.Btn_Ping.Location = new System.Drawing.Point(0, 28);
            this.Btn_Ping.Name = "Btn_Ping";
            this.Btn_Ping.Size = new System.Drawing.Size(98, 26);
            this.Btn_Ping.TabIndex = 3;
            this.Btn_Ping.Text = "Ping";
            this.Btn_Ping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Btn_Ping, "Right Click for HELP!");
            this.Btn_Ping.UseVisualStyleBackColor = false;
            this.Btn_Ping.Click += new System.EventHandler(this.Btn_Ping_Click);
            this.Btn_Ping.MouseLeave += new System.EventHandler(this.Btn_Ping_MouseLeave);
            this.Btn_Ping.MouseHover += new System.EventHandler(this.Btn_Ping_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(549, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 494);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::NetSet.Properties.Resources.DwnArrow;
            this.pictureBox7.Location = new System.Drawing.Point(2, 347);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 34);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::NetSet.Properties.Resources.UpArrow;
            this.pictureBox6.Location = new System.Drawing.Point(2, 311);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP_Address,
            this.Description,
            this.Results});
            this.dataGridView2.DataSource = this.dataSet1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(100, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(449, 494);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // IP_Address
            // 
            this.IP_Address.DataPropertyName = "Ip_Address";
            this.IP_Address.HeaderText = "IP_Address";
            this.IP_Address.Name = "IP_Address";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 218;
            // 
            // Results
            // 
            this.Results.DataPropertyName = "Results";
            this.Results.HeaderText = "Results";
            this.Results.Name = "Results";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Ip_Address";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Description";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Results";
            // 
            // toolTip
            // 
            this.toolTip.Active = false;
            this.toolTip.AutomaticDelay = 1500;
            this.toolTip.IsBalloon = true;
            // 
            // PingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(583, 522);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PingList";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetSet - Ping List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button Btn_CMD;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.Button Btn_SaveAs;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_IPCfg;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Ping;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Btn_NetSet;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Results;
        private System.Windows.Forms.Button Btn_Paste;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}