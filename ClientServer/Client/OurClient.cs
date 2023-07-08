using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client; //позволяет работать с TCP
        private StreamWriter sWriter; //позволяет записывать на сервер

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555); //ID (ПК) и номер порта
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }

        void HandleCommunication()
        {
            while (true) //бесконечный цикл для соединения с сервером
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sWriter.WriteLine(message);
                sWriter.Flush(); //Flush - отправка на сервер
            }
        }


    }
}