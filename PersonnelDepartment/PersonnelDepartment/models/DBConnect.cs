using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace PersonnelDepartment
{
    public class DBConnect
    {
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {

        }

        public string Transform(string target)
        {
            string result;
            if (target == null) result = "";
            else { result = "\'" + target + "\'"; }
            return result;
        }

        public string Insert(string table, params string[] parameters)
        {
            return "INSERT INTO " + table + " VALUES(" + string.Join(", ", parameters) + ")";
        }

        public string Update(string table, string where, params string[] parameters)
        {
            return "UPDATE " + table + " SET " + string.Join(", ", parameters) + " WHERE " + where;
        }

        public string Delete(string table, string where)
        {
            return "DELETE FROM " + table + " WHERE " + where;
        }

        public string Select(string table, string what, string where)
        {
            if (what.Equals("")) what = "*";
            return "SELECT " + what + " FROM " + table + " WHERE " + where;
        }

        public string BoolToTiny(bool b)
        {
            return b ? "1" : "0";
        }

        public static List<string>[] SendMessageFromSocket(string message)
        {
            byte[] bytes = new byte[1024];
            List<string>[] myList = new List<string>[] { };
            IPAddress ipAddr = Dns.GetHostEntry("localhost").AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(ipEndPoint);
                Console.WriteLine("Сокет соединяется с {0} ", sender.RemoteEndPoint.ToString());
                byte[] msg = Encoding.UTF8.GetBytes(message);
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);
                using (Stream ms = new MemoryStream(bytes))
                {
                    myList = (List<string>[])(new BinaryFormatter().Deserialize(ms));
                }
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (SocketException)
            {
                MessageBox.Show("Connection to socket is lost");
            }
            return myList;
        }
    }
}
