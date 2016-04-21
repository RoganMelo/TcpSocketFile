using System.Threading;
using System.Windows.Forms;

namespace TcpSocket
{
    public partial class ServerForm : Form
    {
        private Server server;

        public ServerForm()
        {
            server = new Server(this);
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start();
        }

        private void BtnStartServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = false;
            BtnStopServer.Enabled = true;
            TextBoxHost.Enabled = false;
            TextBoxPort.Enabled = false;
            
            server.Start(TextBoxHost.Text, int.Parse(TextBoxPort.Text));
        }

        private void BtnStopServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = true;
            BtnStopServer.Enabled = false;
            TextBoxHost.Enabled = true;
            TextBoxPort.Enabled = true;

            server.Stop();
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
                ListServerInformations.Items.Add(message);
            }
        }
    }
}
