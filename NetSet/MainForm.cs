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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed +=
           new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new PingList()).Show();
        }

        public static class Globals
        {
            public static String results = "";
            public static int formLoaded = 0;
            public static int gridView2Count = 0;
            
        }

        //Refresh Adaptors
        private void Button1_Click(object sender, EventArgs e)
        {
            GetNetworkInfo();
        }
        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Button1.ForeColor = System.Drawing.Color.Black;
            Button1.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.ForeColor = System.Drawing.Color.White;
            Button1.BackColor = System.Drawing.Color.Black;
        }

        //Save
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("NetSet.xml", System.Text.Encoding.UTF8);
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

                Button2.ForeColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Button2_MouseHover(object sender, EventArgs e)
        {
            if (Button2.ForeColor != System.Drawing.Color.Red)
            {
                Button2.ForeColor = System.Drawing.Color.Black;
            }
            Button2.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            if (Button2.ForeColor != System.Drawing.Color.Red)
            {
                Button2.ForeColor = System.Drawing.Color.White;
            }
            Button2.BackColor = System.Drawing.Color.Black;
        }

        //Change IP
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow1 = dataGridView1.Rows[selectedrowindex1];

                string strAdaptor = Convert.ToString(selectedRow1.Cells[0].Value);

                if (Validation(3, strAdaptor, TextBox2.Text, TextBox3.Text))
                {
                    SetIpAddress(strAdaptor, TextBox2.Text, TextBox3.Text);
                    GetNetworkInfo();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Button3_MouseHover(object sender, EventArgs e)
        {
            Button3.ForeColor = System.Drawing.Color.Black;
            Button3.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            Button3.ForeColor = System.Drawing.Color.White;
            Button3.BackColor = System.Drawing.Color.Black;
        }

        //DHCP
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow1 = dataGridView1.Rows[selectedrowindex1];

                string strAdaptor = Convert.ToString(selectedRow1.Cells[0].Value);

                if (Validation(1, strAdaptor, "", ""))
                {
                    SetDHCP(strAdaptor);
                    System.Threading.Thread.Sleep(2000);
                    GetNetworkInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Button4_MouseHover(object sender, EventArgs e)
        {
            Button4.ForeColor = System.Drawing.Color.Black;
            Button4.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            Button4.ForeColor = System.Drawing.Color.White;
            Button4.BackColor = System.Drawing.Color.Black;
        }

        //Ping
        private async void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                label2.BackColor = Color.White;
                label2.Text = "";

                String[] IpAdd = new String[] { TextBox4.Text };

                if (Validation(2, "", TextBox4.Text, ""))
                {

                    //await Task.Delay(1000); 
                    label2.BackColor = Color.Yellow;
                    label2.Text = "Pinging [" + IpAdd[0] + "]";

                    await Ping(IpAdd);
                    label2.Text = Globals.results;

                    if (Globals.results == "Success")
                    {
                        label2.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        label2.BackColor = Color.Red;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Button5_MouseHover(object sender, EventArgs e)
        {
            Button5.ForeColor = System.Drawing.Color.Black;
            Button5.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            Button5.ForeColor = System.Drawing.Color.White;
            Button5.BackColor = System.Drawing.Color.Black;
        }

        //IpCfg
        private void Button6_Click(object sender, EventArgs e)
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
        private void Button6_MouseHover(object sender, EventArgs e)
        {
            Button6.ForeColor = System.Drawing.Color.Black;
            Button6.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            Button6.ForeColor = System.Drawing.Color.White;
            Button6.BackColor = System.Drawing.Color.Black;
        }

        //Set
        private void Button7_Click(object sender, EventArgs e)
        {

            try
            {

                int selectedrowindex1 = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow1 = dataGridView1.Rows[selectedrowindex1];

                string strAdaptor = Convert.ToString(selectedRow1.Cells[0].Value);

                int selectedrowindex2 = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow2 = dataGridView2.Rows[selectedrowindex2];

                string strIp = Convert.ToString(selectedRow2.Cells[0].Value);
                string subNet = Convert.ToString(selectedRow2.Cells[1].Value);

                if (Validation(3, strAdaptor, strIp, subNet))
                {
                    SetIpAddress(strAdaptor, strIp, subNet);
                    GetNetworkInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Button7_MouseHover(object sender, EventArgs e)
        {
            Button7.ForeColor = System.Drawing.Color.Black;
            Button7.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            Button7.ForeColor = System.Drawing.Color.White;
            Button7.BackColor = System.Drawing.Color.Black;
        }

        //Help
        private void Button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Left Button");
        }
        private void Button8_MouseHover(object sender, EventArgs e)
        {
            Button8.ForeColor = System.Drawing.Color.Black;
            Button8.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            Button8.ForeColor = System.Drawing.Color.White;
            Button8.BackColor = System.Drawing.Color.Black;
        }
        private void Button8_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                ////case MouseButtons.Left:
                ////    MessageBox.Show("Left Button");
                ////    break;
                //case MouseButtons.Right:
                //    CustomMsgBox.Show();
                //    break;
            }
        }

        //Delete
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.dataGridView2.SelectedRows.Count > 0)
                {
                    dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                    Button2.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Button9_MouseHover(object sender, EventArgs e)
        {
            Button9.ForeColor = System.Drawing.Color.Black;
            Button9.BackColor = System.Drawing.Color.LightSteelBlue;

        }
        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            Button9.ForeColor = System.Drawing.Color.White;
            Button9.BackColor = System.Drawing.Color.Black;
        }

        //CMD
        private void Button10_Click(object sender, EventArgs e)
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
        private void Button10_MouseHover(object sender, EventArgs e)
        {
            Button10.ForeColor = System.Drawing.Color.Black;
            Button10.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void Button10_MouseLeave(object sender, EventArgs e)
        {
            Button10.ForeColor = System.Drawing.Color.White;
            Button10.BackColor = System.Drawing.Color.Black;
        }

        //Ping List
        private void button11_Click(object sender, EventArgs e)
        {
            Globals.formLoaded = 0;
            this.Hide();
            
            PingList pl = new PingList();
            pl.ShowDialog();
        }
        private void button11_MouseHover(object sender, EventArgs e)
        {
            Button11.ForeColor = System.Drawing.Color.Black;
            Button11.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            Button11.ForeColor = System.Drawing.Color.White;
            Button11.BackColor = System.Drawing.Color.Black;
        }

        //Ping Results
        private void TextBox4_Click(object sender, EventArgs e)
        {
            try
            {
                label2.BackColor = Color.White;
                label2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void TextBox4_Enter(object sender, EventArgs e)
        {

        }

        //Move Up/Down in dataGridView2
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
                    drToAdd["Subnet_Mask"] = tempSub;
                    drToAdd["Description"] = tempDesc;

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
                    drToAdd["Subnet_Mask"] = tempSub;
                    drToAdd["Description"] = tempDesc;

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
            try
            {
                if (Globals.formLoaded == 1 && Globals.gridView2Count != dataGridView2.RowCount)
                {
                    Button2.ForeColor = System.Drawing.Color.Red;
                    Globals.gridView2Count = dataGridView2.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Set save to red when new row or cell changed
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Globals.formLoaded == 1)
            {
                try
                {
                    Button2.ForeColor = System.Drawing.Color.Red;
                    Globals.gridView2Count = dataGridView2.RowCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Write to xml file
        private void createNode(string ipadd, string subnet, string descrpt, XmlTextWriter writer)
        {
            try
            {
                writer.WriteStartElement("NetSet");
                writer.WriteStartElement("Ip_Address");
                writer.WriteString(ipadd);
                writer.WriteEndElement();
                writer.WriteStartElement("Subnet_Mask");
                writer.WriteString(subnet);
                writer.WriteEndElement();
                writer.WriteStartElement("Description");
                writer.WriteString(descrpt);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static async Task Ping(string[] args)
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
            int timeout = 12000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            //Console.WriteLine("Time to live: {0}", options.Ttl);
            //Console.WriteLine("Don't fragment: {0}", options.DontFragment);

            PingReply x = await pingSender.SendPingAsync(who, timeout, buffer, options);
            Globals.results = x.Status.ToString();

            //Console.WriteLine("Ping example completed.");
        }

        public static bool SetDHCP(string nicName)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface networkInterface = interfaces.FirstOrDefault(x => x.Name == nicName);
            string nicDesc = nicName;

            if (networkInterface != null)
            {
                nicDesc = networkInterface.Description;
            }

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true
                    && mo["Description"].Equals(nicDesc) == true)
                {
                    try
                    {
                        ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");

                        newDNS["DNSServerSearchOrder"] = null;
                        ManagementBaseObject enableDHCP = mo.InvokeMethod("EnableDHCP", null, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool SetIpAddress(string nicName, string ipAddress, string subnetMask)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface networkInterface = interfaces.FirstOrDefault(x => x.Name == nicName);
            string nicDesc = nicName;

            if (networkInterface != null)
            {
                nicDesc = networkInterface.Description;
            }

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true
                    && mo["Description"].Equals(nicDesc) == true)
                {
                    try
                    {
                        ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { ipAddress };
                        newIP["SubnetMask"] = new string[] { subnetMask };

                        ManagementBaseObject setIP = mo.InvokeMethod("EnableStatic", newIP, null);

                        Globals.results = ((string[])mo["IPAddress"])[0];

                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return true;
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
                                        MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    Valid = str2 != null && str2 != String.Empty;
                    if (!Valid)
                    {
                        MessageBox.Show("You must enter an IP",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
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
                                        MessageBoxIcon.Error);
                        }
                        if (str2 == null || str2 == String.Empty)
                        {
                            MessageBox.Show("You must enter an IP",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        }
                        if (str3 == null || str3 == String.Empty)
                        {
                            MessageBox.Show("You must enter a Subnet Mask",
                                        "Input Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
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
            dataGridView1.Rows.Clear();

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            int x = 0;
            try
            {
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {

                        dataGridView1.Rows.Add(1);
                        dataGridView1[0, x].Value = (string)mo["Description"];
                        dataGridView1[1, x].Value = ((string[])mo["IPAddress"])[0];
                        dataGridView1[2, x].Value = ((string[])mo["IPSubnet"])[0];

                        if ((bool)mo["DHCPEnabled"] == true)
                        {
                            dataGridView1[3, x].Value = "DHCP";
                        }
                        else
                        {
                            dataGridView1[3, x].Value = "Static";
                        }
                        x++;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool IsAdmin = IsAdministrator();
            if (!IsAdmin)
            {
                CustomMsgBox.Show();
            }

            //Get current active adaptors
            GetNetworkInfo();

            //Check if XML file exsist
            if (File.Exists("NetSet.xml"))// if exsist read it
            {
                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("NetSet.xml", new XmlReaderSettings());
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
                XmlTextWriter writer = new XmlTextWriter("NetSet.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                createNode("192.168.0.10", "255.255.255.0", "Example1", writer);
                createNode("192.168.0.11", "255.255.255.0", "Example2", writer);
                createNode("192.168.0.12", "255.255.255.0", "Example3", writer);
                createNode("192.168.0.13", "255.255.255.0", "Example4", writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                try
                {
                    XmlReader xmlFile;
                    xmlFile = XmlReader.Create("NetSet.xml", new XmlReaderSettings());
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

            Globals.formLoaded = 1;
            Globals.gridView2Count = dataGridView2.RowCount;

            this.dataGridView1.Columns[0].Width = Convert.ToInt32(dataGridView1.Width * .45);
            this.dataGridView1.Columns[1].Width = Convert.ToInt32(dataGridView1.Width * .22);
            this.dataGridView1.Columns[2].Width = Convert.ToInt32(dataGridView1.Width * .22);
            this.dataGridView1.Columns[3].Width = Convert.ToInt32(dataGridView1.Width * .16);

            this.dataGridView2.Columns[0].Width = Convert.ToInt32(dataGridView2.Width * .22);
            this.dataGridView2.Columns[1].Width = Convert.ToInt32(dataGridView2.Width * .22);
            this.dataGridView2.Columns[2].Width = Convert.ToInt32(dataGridView2.Width * .51);
        }


    }
}