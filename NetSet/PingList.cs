using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Drawing;
using System.Security.Principal;

namespace NetSet
{
    public partial class PingList : Form
    {
        public PingList()
        {
            InitializeComponent();
            this.FormClosed +=
          new System.Windows.Forms.FormClosedEventHandler(this.PingList_FormClosed);
        }

        private void PingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static class Globals
        {
            public static String[] results = new String[100];
            public static int formLoaded = 0;
            public static int gridView2Count = 0;
            public static string curFile = "None";

        }

        //Ping
        private async void Btn_Ping_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.curFile != "None")
                {
                    Btn_Ping.ForeColor = System.Drawing.Color.Red;

                    DataGridViewCellStyle Sstyle = new DataGridViewCellStyle();
                    Sstyle.BackColor = Color.LightGreen;

                    DataGridViewCellStyle Fstyle = new DataGridViewCellStyle();
                    Fstyle.BackColor = Color.Red;

                    DataGridViewCellStyle Nstyle = new DataGridViewCellStyle();
                    Nstyle.BackColor = Color.White;

                    DataGridViewCellStyle Tstyle = new DataGridViewCellStyle();
                    Nstyle.BackColor = Color.Yellow;

                    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                    {
                        this.dataGridView2.Rows[i].Cells[2].Style = Nstyle;
                        dataGridView2.Rows[i].Cells[2].Value = "";
                    }

                    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                    {
                        String[] IpAdd = new String[] { dataGridView2.Rows[i].Cells[0].Value.ToString() };

                        dataGridView2.Rows[i].Cells[2].Value = "Pinging";
                        this.dataGridView2.Rows[i].Cells[2].Style = Tstyle;

                        if (Validation(2, "", IpAdd[0], ""))
                        {

                            await Ping(IpAdd, i);

                            if (Globals.results[i] == "Success")
                            {
                                this.dataGridView2.Rows[i].Cells[2].Style = Sstyle;
                                dataGridView2.Rows[i].Cells[2].Value = Globals.results[i].ToString();
                            }
                            else
                            {
                                this.dataGridView2.Rows[i].Cells[2].Style = Fstyle;
                                dataGridView2.Rows[i].Cells[2].Value = Globals.results[i].ToString();
                            }
                        }
                    }

                    Btn_Ping.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    MessageBox.Show("You must Open or Create a New Ping List",
                                    "Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RightAlign,
                                    true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Btn_Ping.ForeColor = System.Drawing.Color.White;
            }
        }
        private void Btn_Ping_MouseHover(object sender, EventArgs e)
        {
            if (Btn_Ping.ForeColor != System.Drawing.Color.Red)
            {
                Btn_Ping.ForeColor = System.Drawing.Color.Black;
            }
            Btn_Ping.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_Ping_MouseLeave(object sender, EventArgs e)
        {
            if (Btn_Ping.ForeColor != System.Drawing.Color.Red)
            {
                Btn_Ping.ForeColor = System.Drawing.Color.White;
            }
            Btn_Ping.BackColor = System.Drawing.Color.Black;
        }

        //New
        private void Btn_New_Click(object sender, EventArgs e)
        {
            Text = "NetSet - Current Ping List - [ None ]";
            Btn_Save.Visible = false;

            //Check if XML file exsist
            if (File.Exists("Example.xml"))// if exsist read it
            {
                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("Example.xml", new XmlReaderSettings());
                    DataSet dataSet1 = new DataSet();
                    dataSet1.ReadXml(xmlFile);
                    dataGridView2.DataSource = dataSet1.Tables[0];
                    xmlFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else // if not create it then read it
            {
                XmlTextWriter writer = new XmlTextWriter("Example.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                createNode("10.0.0.10", "New List", "", writer);

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("Example.xml", new XmlReaderSettings());
                    DataSet dataSet1 = new DataSet();
                    dataSet1.ReadXml(xmlFile);
                    dataGridView2.DataSource = dataSet1.Tables[0];
                    xmlFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void Btn_New_MouseHover(object sender, EventArgs e)
        {
            Btn_New.ForeColor = System.Drawing.Color.Black;
            Btn_New.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_New_MouseLeave(object sender, EventArgs e)
        {
            Btn_New.ForeColor = System.Drawing.Color.White;
            Btn_New.BackColor = System.Drawing.Color.Black;
        }

        //Open
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Globals.formLoaded = 0;
                if (!String.Equals(Path.GetExtension(ofd.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML file.",
                                    "Invalid File Type",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (Path.GetFileName(ofd.FileName) == "NetSet.xml")
                {
                    // Invalid file type selected; display an error.
                    MessageBox.Show("The selected file is a NetSet Configuration file. You must select an Ping List file.",
                                    "Invalid File Type",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    Globals.curFile = Path.GetFileName(ofd.FileName);
                    Text = "NetSet - Current Ping List - [ " + Globals.curFile + " ]";
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    DataSet dataSet1 = new DataSet();
                    dataSet1.ReadXml(xmlFile);
                    dataGridView2.DataSource = dataSet1.Tables[0];
                    xmlFile.Close();
                    Btn_Save.Visible = true;
                    Btn_Save.ForeColor = System.Drawing.Color.White;
                }
                Globals.formLoaded = 1;
            }
        }
        private void Btn_Open_MouseHover(object sender, EventArgs e)
        {
            Btn_Open.ForeColor = System.Drawing.Color.Black;
            Btn_Open.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_Open_MouseLeave(object sender, EventArgs e)
        {
            Btn_Open.ForeColor = System.Drawing.Color.White;
            Btn_Open.BackColor = System.Drawing.Color.Black;
        }

        //Save
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(Globals.curFile, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                for (int x = 0; x < dataGridView2.RowCount - 1; x++)
                {
                    createNode(dataGridView2.Rows[x].Cells[0].Value.ToString(),
                        dataGridView2.Rows[x].Cells[1].Value.ToString(),
                        dataGridView2.Rows[x].Cells[2].Value.ToString(), writer);
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                Btn_Save.ForeColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Btn_Save_MouseHover(object sender, EventArgs e)
        {
            if (Btn_Save.ForeColor != System.Drawing.Color.Red)
            {
                Btn_Save.ForeColor = System.Drawing.Color.Black;
            }
            Btn_Save.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_Save_MouseLeave(object sender, EventArgs e)
        {
            if (Btn_Save.ForeColor != System.Drawing.Color.Red)
            {
                Btn_Save.ForeColor = System.Drawing.Color.White;
            }
            Btn_Save.BackColor = System.Drawing.Color.Black;
        }

        //Save As
        private void Btn_SaveAs_Click(object sender, EventArgs e)
        {
            DialogResult SaveAsfileResults = InputBox("Create Ping List", "New Ping List:");
            if (SaveAsfileResults.ToString() == "OK" && Globals.curFile.Length > 4)
            {
                try
                {
                    XmlTextWriter writer = new XmlTextWriter(Globals.curFile, System.Text.Encoding.UTF8);
                    writer.WriteStartDocument(true);
                    writer.Formatting = Formatting.Indented;
                    writer.Indentation = 2;
                    writer.WriteStartElement("Table");
                    for (int x = 0; x < dataGridView2.RowCount - 1; x++)
                    {
                        createNode(dataGridView2.Rows[x].Cells[0].Value.ToString(),
                            dataGridView2.Rows[x].Cells[1].Value.ToString(),
                            dataGridView2.Rows[x].Cells[2].Value.ToString(), writer);
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                    Text = "NetSet - Current Ping List - [ " + Globals.curFile + " ]";
                    Btn_Save.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (SaveAsfileResults.ToString() == "OK" && Globals.curFile.Length == 4)
            {
                    MessageBox.Show("The file name can not be empty.",
                                    "Invalid File Name",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
        private void Btn_SaveAs_MouseHover(object sender, EventArgs e)
        {
            if (Btn_SaveAs.ForeColor != System.Drawing.Color.Red)
            {
                Btn_SaveAs.ForeColor = System.Drawing.Color.Black;
            }
            Btn_SaveAs.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_SaveAs_MouseLeave(object sender, EventArgs e)
        {
            if (Btn_SaveAs.ForeColor != System.Drawing.Color.Red)
            {
                Btn_SaveAs.ForeColor = System.Drawing.Color.White;
            }
            Btn_SaveAs.BackColor = System.Drawing.Color.Black;
        }

        //Paste
        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            char[] rowSplitter = { '\r', '\n' };
            char[] columnSplitter = { '\t' };

            //get the text from clipboard

            IDataObject dataInClipboard = Clipboard.GetDataObject();
            string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

            //split it into lines

            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

            if (rowsInClipboard.Length > 0)
            {
                XmlTextWriter writer = new XmlTextWriter("Temp.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                int nodesCreated = 0;

                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)

                {
                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);
                    
                    if (valuesInRow.Length >= 2)
                    {
                        createNode(valuesInRow[0], valuesInRow[1], "", writer);
                        nodesCreated++;
                    }
                }


                if (nodesCreated > 0)
                {
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();

                    try
                    {
                        XmlReader xmlFile;
                        xmlFile = XmlReader.Create("Temp.xml", new XmlReaderSettings());
                        DataSet dataSet1 = new DataSet();
                        dataSet1.ReadXml(xmlFile);
                        dataGridView2.DataSource = dataSet1.Tables[0];
                        xmlFile.Close();
                        Globals.curFile = "Temp.xml";
                        Text = "NetSet - Current Ping List - [ " + Globals.curFile + " ]";
                        Btn_Save.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        private void Btn_Paste_MouseHover(object sender, EventArgs e)
        {
            Btn_Paste.ForeColor = System.Drawing.Color.Black;
            Btn_Paste.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_Paste_MouseLeave(object sender, EventArgs e)
        {
            Btn_Paste.ForeColor = System.Drawing.Color.White;
            Btn_Paste.BackColor = System.Drawing.Color.Black;
        }

        //IpCfg
        private void Btn_IPCfg_Click(object sender, EventArgs e)
        {

            try
            {
                //* Create your Process
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.StartInfo.Arguments = "/K ipconfig";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.Verb = "runas";
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Btn_IPCfg_MouseHover(object sender, EventArgs e)
        {
            Btn_IPCfg.ForeColor = System.Drawing.Color.Black;
            Btn_IPCfg.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_IPCfg_MouseLeave(object sender, EventArgs e)
        {
            Btn_IPCfg.ForeColor = System.Drawing.Color.White;
            Btn_IPCfg.BackColor = System.Drawing.Color.Black;
        }

        //CMD
        private void Btn_CMD_Click(object sender, EventArgs e)
        {

            try
            {
                //* Create your Process
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.StartInfo.Arguments = "/K cd/";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.Verb = "runas";
                process.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Btn_CMD_MouseHover(object sender, EventArgs e)
        {
            Btn_CMD.ForeColor = System.Drawing.Color.Black;
            Btn_CMD.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_CMD_MouseLeave(object sender, EventArgs e)
        {
            Btn_CMD.ForeColor = System.Drawing.Color.White;
            Btn_CMD.BackColor = System.Drawing.Color.Black;
        }

        //NetSet
        private void Btn_NetSet_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
        private void Btn_NetSet_MouseHover(object sender, EventArgs e)
        {
            Btn_NetSet.ForeColor = System.Drawing.Color.Black;
            Btn_NetSet.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_NetSet_MouseLeave(object sender, EventArgs e)
        {
            Btn_NetSet.ForeColor = System.Drawing.Color.White;
            Btn_NetSet.BackColor = System.Drawing.Color.Black;
        }

        //Delete
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridView2.SelectedRows.Count > 0)
                {
                    dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                    Btn_Save.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Btn_Delete_MouseHover(object sender, EventArgs e)
        {
            Btn_Delete.ForeColor = System.Drawing.Color.Black;
            Btn_Delete.BackColor = System.Drawing.Color.LightSteelBlue;

        }
        private void Btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            Btn_Delete.ForeColor = System.Drawing.Color.White;
            Btn_Delete.BackColor = System.Drawing.Color.Black;
        }

        //Help
        private void Btn_Help_Click(object sender, EventArgs e)
        {
        }
        private void Btn_Help_MouseHover(object sender, EventArgs e)
        {
            Btn_Help.ForeColor = System.Drawing.Color.Black;
            Btn_Help.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Btn_Help_MouseLeave(object sender, EventArgs e)
        {
            Btn_Help.ForeColor = System.Drawing.Color.White;
            Btn_Help.BackColor = System.Drawing.Color.Black;
        }

        //Ping Results
        private void TextBox4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    label2.BackColor = Color.White;
            //    label2.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        private void TextBox4_Enter(object sender, EventArgs e)
        {

        }

        //Move rows up/down
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                string tempIp;
                string tempSub;
                string tempDesc;

                int rowcount = dataGridView2.RowCount - 1;
                int selectedrowindex2 = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow2 = dataGridView2.Rows[selectedrowindex2];
                DataTable dataTable = (DataTable)dataGridView2.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                if (selectedrowindex2 > 0)
                {
                    tempIp = Convert.ToString(selectedRow2.Cells[0].Value);
                    tempSub = Convert.ToString(selectedRow2.Cells[1].Value);
                    tempDesc = Convert.ToString(selectedRow2.Cells[2].Value);
                    dataTable.Rows[selectedrowindex2].Delete();
                    dataTable.AcceptChanges();

                    drToAdd["Ip_Address"] = tempIp;
                    drToAdd["Description"] = tempSub;
                    drToAdd["Results"] = tempDesc;

                    dataTable.Rows.InsertAt(drToAdd, selectedrowindex2 - 1);
                    dataTable.AcceptChanges();

                    dataGridView2.Rows[selectedrowindex2].Selected = false;
                    dataGridView2.Refresh();
                    dataGridView2.Rows[selectedrowindex2 - 1].Selected = true;
                    dataGridView2.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                string tempIp;
                string tempSub;
                string tempDesc;

                int rowcount = dataGridView2.RowCount - 1;
                int selectedrowindex2 = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow2 = dataGridView2.Rows[selectedrowindex2];
                DataTable dataTable = (DataTable)dataGridView2.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                if (selectedrowindex2 < rowcount - 1)
                {
                    tempIp = Convert.ToString(selectedRow2.Cells[0].Value);
                    tempSub = Convert.ToString(selectedRow2.Cells[1].Value);
                    tempDesc = Convert.ToString(selectedRow2.Cells[2].Value);
                    dataTable.Rows[selectedrowindex2].Delete();
                    dataTable.AcceptChanges();

                    drToAdd["Ip_Address"] = tempIp;
                    drToAdd["Description"] = tempSub;
                    drToAdd["Results"] = tempDesc;

                    dataTable.Rows.InsertAt(drToAdd, selectedrowindex2 + 1);
                    dataTable.AcceptChanges();

                    dataGridView2.Rows[selectedrowindex2].Selected = false;
                    dataGridView2.Refresh();
                    dataGridView2.Rows[selectedrowindex2 + 1].Selected = true;
                    dataGridView2.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Set save to red when new row or cell changed
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Globals.formLoaded == 1 && Globals.gridView2Count != dataGridView2.RowCount)
            {
                try
                {


                    Btn_Save.ForeColor = System.Drawing.Color.Red;
                    Globals.gridView2Count = dataGridView2.RowCount;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Set save to red when new row or cell changed
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Globals.formLoaded == 1)
            {
                try
                {
                    Btn_Save.ForeColor = System.Drawing.Color.Red;
                    Globals.gridView2Count = dataGridView2.RowCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                DataGridViewCellStyle Nstyle = new DataGridViewCellStyle();
                Nstyle.BackColor = Color.White;
                Nstyle.ForeColor = Color.Black;

                this.dataGridView2.Rows[i].Cells[2].Style = Nstyle;
                dataGridView2.Rows[i].Cells[2].Value = "";
            }
            Btn_Save.ForeColor = System.Drawing.Color.White;
        }

        //Write to xml file
        private void createNode(string ipadd, string descrpt, string rslts, XmlTextWriter writer)
        {
            try
            {
                writer.WriteStartElement("PingList");
                writer.WriteStartElement("Ip_Address");
                writer.WriteString(ipadd);
                writer.WriteEndElement();
                writer.WriteStartElement("Description");
                writer.WriteString(descrpt);
                writer.WriteEndElement();
                writer.WriteStartElement("Results");
                writer.WriteString(rslts);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static async Task Ping(string[] args, int i)
        {
            if (args.Length == 0)
                throw new ArgumentException("Ping needs a host or IP Address.");

            string who = args[0];
            AutoResetEvent waiter = new AutoResetEvent(false);

            Ping pingSender = new Ping();

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 12 seconds for a reply.
            int timeout = 5000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            //Console.WriteLine("Time to live: {0}", options.Ttl);
            //Console.WriteLine("Don't fragment: {0}", options.DontFragment);

            PingReply x = await pingSender.SendPingAsync(who, timeout, buffer, options);
            Globals.results[i] = x.Status.ToString();
            

            //Console.WriteLine("Ping example completed.");
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                .IsInRole(WindowsBuiltInRole.Administrator);

        }

        public static bool Validation(int caseValue, string str1, string str2, string str3)
        {

            bool Valid;
            Valid = false;

            switch (caseValue)
            {
                case 1:
                    Valid = str1 != null && str1 != String.Empty;
                    if (!Valid)
                    {
                        MessageBox.Show("You must select an Adaptor",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
                    }
                    break;
                case 2:
                    Valid = str2 != null && str2 != String.Empty;
                    if (!Valid)
                    {
                        MessageBox.Show("You must enter an IP",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
                    }
                    break;
                case 3:
                    Valid = str1 != null && str1 != String.Empty &&
                        str2 != null && str2 != String.Empty &&
                        str3 != null && str3 != String.Empty;
                    if (!Valid)
                    {
                        if (str1 == null || str1 == String.Empty)
                        {
                            MessageBox.Show("You must select an Adaptor",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
                        }
                        if (str2 == null || str2 == String.Empty)
                        {
                            MessageBox.Show("You must enter an IP",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
                        }
                        if (str3 == null || str3 == String.Empty)
                        {
                            MessageBox.Show("You must enter a Subnet Mask",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
                        }

                    }
                    break;
                default:
                    Valid = false;
                    break;

            }

            return Valid;

        }

        public void GetNetworkInfo()
        {
            //dataGridView1.Rows.Clear();

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            int x = 0;
            //try
            //{
            //    foreach (ManagementObject mo in moc)
            //    {
            //        if ((bool)mo["IPEnabled"] == true)
            //        {

            //            dataGridView1.Rows.Add(1);
            //            dataGridView1[0, x].Value = (string)mo["Description"];
            //            dataGridView1[1, x].Value = ((string[])mo["IPAddress"])[0];
            //            dataGridView1[2, x].Value = ((string[])mo["IPSubnet"])[0];

            //            if ((bool)mo["DHCPEnabled"] == true)
            //            {
            //                dataGridView1[3, x].Value = "DHCP";
            //            }
            //            else
            //            {
            //                dataGridView1[3, x].Value = "Static";
            //            }
            //            x++;

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        public static DialogResult InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = "";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            Globals.curFile = textBox.Text + ".xml";
            return dialogResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "NetSet - Current Ping List - [ " + Globals.curFile + " ]";
            Btn_Save.Visible = false;
            //Check if XML file exsist
            if (File.Exists("Example.xml"))// if exsist read it
            {
                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("Example.xml", new XmlReaderSettings());
                    DataSet dataSet1 = new DataSet();
                    dataSet1.ReadXml(xmlFile);
                    dataGridView2.DataSource = dataSet1.Tables[0];
                    xmlFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else // if not create it then read it
            {
                XmlTextWriter writer = new XmlTextWriter("Example.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                createNode("10.0.0.10", "New List", "", writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("Example.xml", new XmlReaderSettings());
                    DataSet dataSet1 = new DataSet();
                    dataSet1.ReadXml(xmlFile);
                    dataGridView2.DataSource = dataSet1.Tables[0];
                    xmlFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            Globals.gridView2Count = dataGridView2.RowCount;
            Globals.formLoaded = 1;

            DataGridViewCellStyle Sstyle = new DataGridViewCellStyle();
            Sstyle.BackColor = Color.LightGreen;
            Sstyle.ForeColor = Color.Black;

            DataGridViewCellStyle Fstyle = new DataGridViewCellStyle();
            Fstyle.BackColor = Color.Red;
            Fstyle.ForeColor = Color.Black;

            DataGridViewCellStyle Nstyle = new DataGridViewCellStyle();
            Nstyle.BackColor = Color.White;
            Nstyle.ForeColor = Color.Black;

            this.dataGridView2.Columns[0].Width = Convert.ToInt32(dataGridView2.Width * .22);
            this.dataGridView2.Columns[1].Width = Convert.ToInt32(dataGridView2.Width * .37);
            this.dataGridView2.Columns[2].Width = Convert.ToInt32(dataGridView2.Width * .36);
        }

    }
}