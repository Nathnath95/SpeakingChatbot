﻿using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace SpeakingChatbot.socket
{
    internal class ConnectClient
    {
        TcpClient client;


        public IO.PacketReader packetReader;


        // login
        public event Action connectedEvent;
        // send msg
        public event Action msgReceivedEvent;
        // logout
        public event Action userDisconnectEvent;

        public ConnectClient()
        {
            client = new TcpClient();
        }


        // sa login to icacall
        public void ConnectToServer(string username)
        {

            // store sa env
            string address = "127.0.0.1";
            int port = 8080;

            if (!client.Connected) {
                client.Connect(address, port);

                packetReader = new IO.PacketReader(client.GetStream());

                if(!string.IsNullOrEmpty(username)) {
                    var connectPacket = new IO.PacketBuilder();
                    connectPacket.WriteOpCode(0);
                    connectPacket.WriteMsg(username);
                    // send packet sa server
                    client.Client.Send(connectPacket.GetPacketBytes());
                }

                ReadPackets();

            }
        }

        private void ReadPackets() {
            Task.Run(() => {
                while(true) {
                    var opCode = packetReader.ReadByte();
                    switch(opCode) {
                        case 1:
                            connectedEvent?.Invoke();
                            break;
                        case 5:
                            msgReceivedEvent?.Invoke();
                            break;
                        case 10:
                            userDisconnectEvent?.Invoke();
                            break;
                        default:
                            Console.WriteLine("ahh yes..");
                            break;
                    }
                }
            });
        }

        public void SendMsgToServer(string msg) { 
            var msgPacket = new IO.PacketBuilder();
            // 5 the opcode to send a msg
            msgPacket.WriteOpCode(5);
            msgPacket.WriteMsg(msg);
            client.Client.Send(msgPacket.GetPacketBytes());
        }
    }
}