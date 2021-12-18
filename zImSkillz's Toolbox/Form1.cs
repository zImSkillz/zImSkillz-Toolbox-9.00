using libdebug;
using MetroFramework.Forms;
using PS4_BO3_GSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


        /*
         * Created by zImSkillz
         *    18.12.2021
         */

namespace zImSkillz_s_Toolbox
{
    public partial class main : MetroForm
    {
        public static Socket _psocket;
        private PS4DBG ps4;
        private int pid;

        private Enums.Bo3Version selectedGameVersion = Enums.Bo3Version.OneThreeThree;
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusattached_Click(object sender, EventArgs e)
        {

        }

        private void connecttab_Click(object sender, EventArgs e)
        {

        }

        private String getPS4DebugPayload()
        {
            var payloadsDirectory = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Payloads");
            var payloadFileName = "ps4debug.bin";
            return $"{payloadsDirectory}\\defaultpayloads\\{payloadFileName}";
        }

        private async void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                ps4 = new PS4DBG(ps4ip.Text);
                ps4.Connect();
                ps4.Notify(222, "Connected!");
                statusps4.Text = "Connected";
                foreach (libdebug.Process process in ps4.GetProcessList().processes)
                {
                    if(process.name == "eboot.bin")
                    {
                        pid = process.pid;
                        statusattached.Text = "Attached";
                        ps4.Notify(222, "Attached automatically!");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please start PS4Debug (9.00) and then try connect again.", "Could not connect to PS4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusps4.Text = "Error..";
            }
        }

        private void btnattach_Click(object sender, EventArgs e)
        {
            if(statusps4.Text is "Connected")
            {
                try
                {
                    foreach (libdebug.Process process in ps4.GetProcessList().processes)
                    {
                        if (process.name == "eboot.bin")
                        {
                            pid = process.pid;
                            statusattached.Text = "Attached";
                            ps4.Notify(222, "Attached!");
                            break;
                        }
                    }
                } catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Start a Game or Connect to your PS4", "Game could not be attached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusattached.Text = "Error..";
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Start a Game or Connect to your PS4", "Game could not be attached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusattached.Text = "Error..";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {/*
            _psocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _psocket.ReceiveTimeout = 3000;
            _psocket.SendTimeout = 3000;
            _psocket.Connect(new IPEndPoint(IPAddress.Parse(ps4ip.Text), Int32.Parse("9090")));
            _psocket.SendFile(getPS4DebugPayload());
        */}

        private void metroButton2_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                fd.Filter = "Compiled GSC FIles (*.gscc)|*.gscc";
                DialogResult result = fd.ShowDialog();
                gscloacation.Text = fd.FileName;
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            ps4.Notify(222, "GSC is loading..");
            byte[] buffer = null;
            try
            {
                buffer = File.ReadAllBytes(gscloacation.Text);
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Could not read compiled gsc file, make sure it still exists.", "Couldn't Read File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ulong dupGscAddress = (ulong)selectedGameVersion;
            var filePointerAddress = ps4.ReadMemory<ulong>(pid, dupGscAddress + 0x10);
            int checksum = ps4.ReadMemory<int>(pid, filePointerAddress + 0x8);
            BitConverter.GetBytes(checksum).CopyTo(buffer, 0x8);
            var newGscFileAddress = ps4.AllocateMemory(pid, buffer.Length);
            ps4.WriteMemory(pid, newGscFileAddress, buffer);
            ps4.WriteMemory(pid, dupGscAddress + 0x10, newGscFileAddress);
            ps4.Notify(222, "GSC injected!");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ps4.WriteMemory(pid, 0x4ED79E84, 999999);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ps4.WriteMemory(pid, 0x4ED63634, 999999999);
            ps4.WriteMemory(pid, 0x4ED6362C, 999999999);
            ps4.WriteMemory(pid, 0x4ED63638, 999999999);

            ps4.WriteMemory(pid, 0x4ED63670, 999999);
            ps4.WriteMemory(pid, 0x4ED63674, 999999);
            ps4.WriteMemory(pid, 0x4ED63668, 999999);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            notifybox.Multiline = true;
        }

        private void notifysend_Click(object sender, EventArgs e)
        {
            int intnotifysymbol = Int32.Parse(notifysymbol.Text);
            ps4.Notify(intnotifysymbol, notifybox.Text);
        }

        private void playstationtab_Click(object sender, EventArgs e)
        {

        }

        private void notifysymbol_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
