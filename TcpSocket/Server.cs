using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpSocket
{
    public class Server
    {
        private string host;
        private int port;
        private ServerForm serverForm;
        private IPAddress ipAddress;
        private TcpListener listener;
        private TcpClient client;
        private Thread thread;
        private NetworkStream networkStream;
        private byte[] bytes;
        private string fileName;
        private DirectoryInfo directory;
        private FileInfo foundFile;
        private byte[] sendBytes;

        public Server(ServerForm serverForm)
        {
            this.serverForm = serverForm;
        }

        public void Start(string host, int port)
        {
            this.host = host;
            this.port = port;

            ipAddress = Dns.GetHostAddresses(host)[0];
            
            listener = new TcpListener(ipAddress, port);
            listener.Start();
            serverForm.SetMessage("Server started and listening on port: " + port);

            thread = new Thread(new ThreadStart(ServerStartThread));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }

        private void ServerStartThread()
        {
            try
            {
                client = listener.AcceptTcpClient();

                serverForm.SetMessage("Connection accepted...");

                do
                {
                    networkStream = client.GetStream();

                    if (networkStream.CanRead)
                    {
                        bytes = new byte[client.ReceiveBufferSize]; // tamanho do dados canal
                        networkStream.Read(bytes, 0, Convert.ToInt32(client.ReceiveBufferSize)); //leitura da stream

                        fileName = Encoding.ASCII.GetString(bytes).Replace("\0", "");

                        if (fileName != "")
                        {
                            serverForm.SetMessage("Searching file...");

                            directory = new DirectoryInfo(Path.GetDirectoryName(fileName)); //diretorio do arquivo
                            foundFile = SearchFile(Path.GetFileName(fileName)); //procura do arquivo

                            if (foundFile != null)
                            {
                                serverForm.SetMessage("Sending file: " + foundFile.Name); //chamada do método de envio

                                SendFile(foundFile);

                                serverForm.SetMessage("File uploaded successfully...");
                            }
                        }
                        else
                        {
                            client = null;
                        }  
                    }
                } while (client != null); 

                Stop();
            }
            catch { }
        }

        private FileInfo SearchFile(string fileName)
        {
            foreach (var file in directory.GetFiles()) //procura o arquivo
                if (file.Name.Substring(0, file.Name.Length - 4) == fileName)
                    return file;

            return null;
        }

        public void Stop() //stop do server
        {
            SendMessage("Closing connection...");

            if (thread != null)
                if (thread.ThreadState == ThreadState.Running)
                    thread.Abort();

            if (client != null)
                client.Client.Disconnect(true);

            if(listener != null)
                listener.Stop();

            listener = null;

            serverForm.SetMessage("Connection lost...");
        }

        private void SendMessage(string message) // envio msg servidor para cliente
        {
            if (CanWrite())
            {
                sendBytes = Encoding.ASCII.GetBytes(message);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        private void SendFile(FileInfo file) //envio do arquivo
        {
            if (CanWrite())
            {
                byte[] fileBytes = File.ReadAllBytes(file.FullName);
                networkStream.Write(fileBytes, 0, fileBytes.Length);
            }
        }

        public bool CanWrite()// disponibilidade da stream
        {
            if (networkStream == null)
                return false;

            if (networkStream.CanWrite && client != null)
                return true;
            else
                return false;
        }
    }
}
