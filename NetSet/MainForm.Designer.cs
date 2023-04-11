using System;

namespace NetSet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adaptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IP_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subnet_Mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Button8 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 12);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 12);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 9);
            this.label3.TabIndex = 2;
            this.label3.Text = "by Jeff Nelson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 9);
            this.label1.TabIndex = 1;
            this.label1.Text = "ver 2.0.1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 493);
            this.panel3.TabIndex = 4;
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
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Black;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(0, 28);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(98, 26);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Refresh";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button1, "Right Click for HELP!");
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            this.Button1.MouseHover += new System.EventHandler(this.Button1_MouseHover);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(0, 110);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(98, 26);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "Change IP";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button3, "Right Click for HELP!");
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            this.Button3.MouseLeave += new System.EventHandler(this.Button3_MouseLeave);
            this.Button3.MouseHover += new System.EventHandler(this.Button3_MouseHover);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Black;
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(0, 140);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(98, 26);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "DHCP";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button4, "Right Click for HELP!");
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            this.Button4.MouseLeave += new System.EventHandler(this.Button4_MouseLeave);
            this.Button4.MouseHover += new System.EventHandler(this.Button4_MouseHover);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Black;
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(0, 170);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(98, 26);
            this.Button5.TabIndex = 7;
            this.Button5.Text = "Ping";
            this.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button5, "Right Click for HELP!");
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            this.Button5.MouseLeave += new System.EventHandler(this.Button5_MouseLeave);
            this.Button5.MouseHover += new System.EventHandler(this.Button5_MouseHover);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Black;
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(0, 200);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(98, 26);
            this.Button6.TabIndex = 8;
            this.Button6.Text = "IpConfig";
            this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button6, "Right Click for HELP!");
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            this.Button6.MouseLeave += new System.EventHandler(this.Button6_MouseLeave);
            this.Button6.MouseHover += new System.EventHandler(this.Button6_MouseHover);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Black;
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(0, 313);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(98, 26);
            this.Button7.TabIndex = 9;
            this.Button7.Text = "Set";
            this.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button7, "Right Click for HELP!");
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            this.Button7.MouseLeave += new System.EventHandler(this.Button7_MouseLeave);
            this.Button7.MouseHover += new System.EventHandler(this.Button7_MouseHover);
            // 
            // Button11
            // 
            this.Button11.BackColor = System.Drawing.Color.Black;
            this.Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.ForeColor = System.Drawing.Color.White;
            this.Button11.Location = new System.Drawing.Point(0, 260);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(98, 26);
            this.Button11.TabIndex = 18;
            this.Button11.Text = "Ping List";
            this.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button11, "Right Click for HELP!");
            this.Button11.UseVisualStyleBackColor = false;
            this.Button11.Click += new System.EventHandler(this.button11_Click);
            this.Button11.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.Button11.MouseHover += new System.EventHandler(this.button11_MouseHover);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.Black;
            this.Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button10.FlatAppearance.BorderSize = 0;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button10.ForeColor = System.Drawing.Color.White;
            this.Button10.Location = new System.Drawing.Point(0, 230);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(98, 26);
            this.Button10.TabIndex = 17;
            this.Button10.Text = "CMD";
            this.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button10, "Right Click for HELP!");
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            this.Button10.MouseLeave += new System.EventHandler(this.Button10_MouseLeave);
            this.Button10.MouseHover += new System.EventHandler(this.Button10_MouseHover);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Black;
            this.Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Location = new System.Drawing.Point(0, 345);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(98, 26);
            this.Button9.TabIndex = 16;
            this.Button9.Text = "Delete";
            this.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button9, "Right Click for HELP!");
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            this.Button9.MouseLeave += new System.EventHandler(this.Button9_MouseLeave);
            this.Button9.MouseHover += new System.EventHandler(this.Button9_MouseHover);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Black;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(0, 427);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(98, 26);
            this.Button2.TabIndex = 14;
            this.Button2.Text = "Save";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.Button2, "Right Click for HELP!");
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Button2.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            this.Button2.MouseHover += new System.EventHandler(this.Button2_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adaptor,
            this.Current_IP,
            this.Sub_Mask,
            this.Type});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(100, 14);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(449, 94);
            this.dataGridView1.TabIndex = 5;
            // 
            // Adaptor
            // 
            this.Adaptor.HeaderText = "Adaptor";
            this.Adaptor.Name = "Adaptor";
            // 
            // Current_IP
            // 
            this.Current_IP.HeaderText = "Current IP";
            this.Current_IP.Name = "Current_IP";
            // 
            // Sub_Mask
            // 
            this.Sub_Mask.HeaderText = "Subnet Mask";
            this.Sub_Mask.Name = "Sub_Mask";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP_Address,
            this.Subnet_Mask,
            this.Description});
            this.dataGridView2.DataSource = this.dataSet1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(100, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(449, 193);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // IP_Address
            // 
            this.IP_Address.DataPropertyName = "Ip_Address";
            this.IP_Address.HeaderText = "IP_Address";
            this.IP_Address.Name = "IP_Address";
            // 
            // Subnet_Mask
            // 
            this.Subnet_Mask.DataPropertyName = "Subnet_Mask";
            this.Subnet_Mask.HeaderText = "Subnet Mask";
            this.Subnet_Mask.Name = "Subnet_Mask";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 218;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
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
            this.dataColumn2.ColumnName = "Subnet_Mask";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Description";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(104, 127);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(123, 20);
            this.TextBox2.TabIndex = 7;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(233, 127);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(123, 20);
            this.TextBox3.TabIndex = 8;
            this.TextBox3.Text = "255.255.255.0";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(104, 189);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(123, 20);
            this.TextBox4.TabIndex = 9;
            this.TextBox4.Click += new System.EventHandler(this.TextBox4_Click);
            this.TextBox4.Enter += new System.EventHandler(this.TextBox4_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(232, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = " ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.Button8);
            this.panel4.Controls.Add(this.Button11);
            this.panel4.Controls.Add(this.Button9);
            this.panel4.Controls.Add(this.Button10);
            this.panel4.Controls.Add(this.Button1);
            this.panel4.Controls.Add(this.Button3);
            this.panel4.Controls.Add(this.Button4);
            this.panel4.Controls.Add(this.Button2);
            this.panel4.Controls.Add(this.Button5);
            this.panel4.Controls.Add(this.Button7);
            this.panel4.Controls.Add(this.Button6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(2, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 493);
            this.panel4.TabIndex = 12;
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Black;
            this.Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Location = new System.Drawing.Point(0, 459);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(98, 26);
            this.Button8.TabIndex = 19;
            this.Button8.Text = "Help";
            this.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            this.Button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button8_MouseDown);
            this.Button8.MouseLeave += new System.EventHandler(this.Button8_MouseLeave);
            this.Button8.MouseHover += new System.EventHandler(this.Button8_MouseHover);
            // 
            // toolTip
            // 
            this.toolTip.Active = false;
            this.toolTip.AutomaticDelay = 1500;
            this.toolTip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " NetSet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Button9;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subnet_Mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adaptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

