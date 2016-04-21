using System;
using System.Threading;
using System.Windows.Forms;

namespace TcpSocket
{
    public partial class ClientForm : Form
    {
        private Client client;
        private Thread threadFolderBrowserDialog;
        private FolderBrowserDialog folderBrowserDialog;

        public ClientForm()
        {
            client = new Client(this);
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
            TextBoxHostName.Enabled = false;
            TextBoxPort.Enabled = false;
            TextBoxFileName.Enabled = true;
            BtnSearchFile.Enabled = true;
            GroupBoxFile.Enabled = true;

            client.Start(TextBoxHostName.Text, int.Parse(TextBoxPort.Text));
        }

        private void BtnDisconnect_Click(object sender, System.EventArgs e)
        {
            Disconnect();
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            threadFolderBrowserDialog = new Thread(new ThreadStart(() => {
                folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SetPath(folderBrowserDialog.SelectedPath);
                }
            }));

            threadFolderBrowserDialog.SetApartmentState(ApartmentState.STA);
            threadFolderBrowserDialog.Start();
        }

        delegate void SetPathCallback(string path);
        public void SetPath(string path)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetPathCallback(SetPath), path);
            }
            else
            {
                TextBoxPath.Text = path;
            }
        }

        private void BtnSearchFile_Click(object sender, System.EventArgs e)
        {
            client.SearchFile(TextBoxPath.Text + "\\" + TextBoxFileName.Text);
        }

        delegate void DisconnectCallback();
        public void Disconnect()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DisconnectCallback(Disconnect));
            }
            else
            {
                BtnConnect.Enabled = true;
                BtnDisconnect.Enabled = false;
                TextBoxHostName.Enabled = true;
                TextBoxPort.Enabled = true;
                TextBoxFileName.Enabled = false;
                BtnSearchFile.Enabled = false;
                GroupBoxFile.Enabled = false;

                client.Disconnect();
            }
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            }
            else
            {
                ListBoxClientInformations.Items.Add(message);
            }
        }
    }
}
