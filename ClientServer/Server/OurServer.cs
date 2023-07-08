using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555); //Работа с TCP, но нужен Parse
            server.Start();

            LoopClients();  
        }

        void LoopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient(); //"ловим" клиента

                Thread thread = new Thread(() => HandleClient(client)); //отдельный тред под каждого клиента
                thread.Start();
            }
        }

        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8); //считываем поток. Для каждого клиента свой, поэтому поток не в описании сервера
            

            while (true)
            {
                string message = sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {message}");
            }
        }
    }
}