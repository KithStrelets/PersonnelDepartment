using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace PersonnelDepartment.server
{
    class Program
    {
        private static byte[] clientBuffer;
        private static Socket handler;
        private static Socket sListener;
        private static IPEndPoint ipEndPoint;

        static void Main(string[] args)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);
            sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                while (true)
                {
                    clientBuffer = new byte[1024];
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);
                    handler = sListener.Accept();
                    Thread connectedClient = new Thread(new ThreadStart(Run));
                    connectedClient.Start();
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            string data = null;
            int bytesRec = handler.Receive(clientBuffer);
            data += Encoding.UTF8.GetString(clientBuffer, 0, bytesRec);
            Console.WriteLine("Полученный текст: " + data);

            var memStream = new MemoryStream();
            new BinaryFormatter().Serialize(memStream, new DatabaseConnect().CommonExecute(data));
            byte[] msg = memStream.ToArray();
            handler.Send(msg);
            Console.WriteLine("Сервер завершил соединение с клиентом.\n");                

            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
}