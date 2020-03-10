using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using LotusAPI;
using System.Threading;

namespace ATMC.App.SealerInspection
{
    public class ControllerServer
    {
        //public delegate void OnMessageReceivedEventHandler(string msg);
        //public event OnMessageReceivedEventHandler OnMessageReceived = null;

        public delegate void OnCommandReceivedEventHandler(ControllerCommandItem cmd, string msg);
        public event OnCommandReceivedEventHandler OnCommandReceived = null;

        public delegate void OnServerStartedEventHandler();
        public event OnServerStartedEventHandler OnServerStarted = null;
        public delegate void OnClientConnectedEventHandler(string ip);
        public event OnClientConnectedEventHandler OnClientConnected = null;
        public delegate void OnClientDisconnectedEventHandler();
        public event OnClientDisconnectedEventHandler OnClientDisconnected = null;

        TcpListener m_listener = null;
        TcpClient m_client = null;

        public string IP { get; set; }
        public int Port { get; set; }
        Thread tcpthread = null;
        bool shouldstop = false;

        List<ControllerCommandItem> m_commands = new List<ControllerCommandItem>();


        public void LoadMap()
        {
            try {
                Json j = Json.ReadFromFile(Registry.GetStringValue("ControllerCommandMapFile", ""));
                var jj = j["ControllerCommandMap"];
                m_commands.AddRange(jj.ToArray<ControllerCommandItem>());
            }catch(Exception ex) { Logger.Error(ex.Message); }
        }

        ~ControllerServer()
        {
            Stop();
        }

        ControllerCommandItem FindCommand(string msg)
        {
            if (m_commands == null) return null;
            foreach(var cmd in m_commands)
            {
                if (msg.Contains(cmd.Command)) return cmd;
            }
            return null;
        }

        public void Start()
        {
            try
            {
                Stop();

                Logger.Info($"Starting tcp server {IP}:{Port}");
                m_listener = new TcpListener(IPAddress.Parse(IP), Port);
                m_listener.Start();
                OnServerStarted?.Invoke();

                shouldstop = false;
                //thread
                tcpthread = new Thread(() =>
                {
                    while (true)
                    {
                        Logger.Info("Waiting for connection...");
                        while (!m_listener.Pending())
                        {
                            Thread.Sleep(1000);
                            if (shouldstop) return;
                        }
                        m_client = m_listener.AcceptTcpClient();
                        using (NetworkStream stream = m_client.GetStream())
                        {
                            Logger.Info($"Controller connected @{m_client.Client.RemoteEndPoint}");
                            OnClientConnected?.Invoke(m_client.Client.RemoteEndPoint.ToString());
                            //buffer
                            var buff = new byte[16];
                            string msg = "";
                            //serve this client
                            while (true)
                            {
                                try
                                {
                                    while (true)
                                    {
                                        while (!stream.DataAvailable) { if (shouldstop) return; }
                                        stream.Read(buff, 0, 1);
                                        if (buff[0] == 0x02)
                                        {
                                            msg = "";
                                            break;
                                        }
                                    }
                                    while (true)
                                    {
                                        while (!stream.DataAvailable) { if (shouldstop) return; }
                                        stream.Read(buff, 0, 1);
                                        if (buff[0] != 0x03)
                                        {
                                            msg += (char)buff[0];
                                        }
                                        else break;
                                    }
                                    //OnMessageReceived?.Invoke(msg);
                                    OnCommandReceived?.Invoke(FindCommand(msg),msg);
                                }
                                catch (Exception ex)
                                {
                                    if (m_client.Connected == false)
                                    {
                                        OnClientDisconnected?.Invoke();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                });
                tcpthread.Start();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }
        public void Stop()
        {
            Logger.Debug("Stopping controller server...");
            shouldstop = true;

            if (tcpthread != null) tcpthread.Abort();
            //setup the listerner
            if (m_listener != null)
            {
                m_listener.Server.Close();
                m_listener.Stop();
            }
            if (m_client != null) m_client.Close();
        }
        public void Send(string msg) {
            try {
                var buf = new byte[msg.Length + 2];
                buf[0] = 0x02;
                buf[buf.Length - 1] = 0x03;
                for(int i = 0; i < msg.Length; i++)
                {
                    buf[i + 1] = (byte)msg[i];
                }
                m_client.GetStream().Write(buf, 0, buf.Length);
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }
    }
}
