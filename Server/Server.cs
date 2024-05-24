using Common.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket socket;
        private bool isConnected = false;
        public List<ClientHandler> clients = new List<ClientHandler>();
        public static List<Korisnik> ulogovani = new List<Korisnik>();

        private static Server instance;

        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        public Server()
        {
        }

        public void Start()
        {
            try
            {
                if (!isConnected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                    socket.Bind(endPoint);
                    socket.Listen(10);
                    isConnected = true;

                    Thread thread = new Thread(AcceptClient);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while starting the server: " + ex.Message);
            }
        }

        public void AcceptClient()
        {
            try
            {
                while (isConnected)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket);
                    clients.Add(handler);

                    Thread clientThread = new Thread(handler.HandleRequest);
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException occurred while accepting clients: " + ex.Message);
                Stop();
            }
        }

        FrmServer frm = new FrmServer();

        //internal void HandleServerShutdown()
        //{
        //    CloseAllForms();

        //    MessageBox.Show("Server has been shut down. You have been disconnected.", "Server Shutdown", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}

        //private void CloseAllForms()
        //{
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        form.Close();
        //    }
        //}

        public void Stop()
        {
            try
            {
                if (isConnected)
                {
                    socket.Close();
                    isConnected = false;

                    foreach (ClientHandler handler in clients)
                    {
                        handler.Close();
                    }
                    ulogovani.Clear();
                    clients.Clear();
                    frm.Dispose();
                    //HandleServerShutdown(); 

                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException occurred while stopping the server: " + ex.Message);
            }
        }
    }

}
