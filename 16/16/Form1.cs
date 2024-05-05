using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private string folderPath = "";
        private string password = "";
        private int port = 8000;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (server == null || !server.Server.IsBound)
            {
                StartServer();
            }
            else
            {
                StopServer();
            }
        }

        private void StartServer()
        {
            try
            {
                port = int.Parse(PortTextBox.Text);
                password = PasswordTextBox.Text;
                server = new TcpListener(IPAddress.Any, port);
                server.Start();
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderDialog.SelectedPath;
                    FolderPathLabel.Text = folderPath;
                }
                server.BeginAcceptTcpClient(AcceptClient, null);
                StartStopButton.Text = "Stop Server";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void StopServer()
        {
            server.Stop();
            server = null;
            StartStopButton.Text = "Start Server";
        }

        private void AcceptClient(IAsyncResult ar)
        {
            TcpClient client = server.EndAcceptTcpClient(ar);
            server.BeginAcceptTcpClient(AcceptClient, null);
            HandleClient(client);
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string receivedPassword = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            if (receivedPassword == password)
            {
                string[] files = Directory.GetFiles(folderPath);
                string fileList = string.Join("\n", files);
                byte[] data = Encoding.ASCII.GetBytes(fileList);
                stream.Write(data, 0, data.Length);
            }
            else
            {
                byte[] data = Encoding.ASCII.GetBytes("Invalid password");
                stream.Write(data, 0, data.Length);
            }

            stream.Close();
            client.Close();
        }
    }
}
