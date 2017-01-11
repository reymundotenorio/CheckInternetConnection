using System;
using System.Net;
using System.IO;

namespace CheckInternetConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            if (CheckForInternetConnection())
            {
                Console.WriteLine("Conexión a internet establecida");
            }
            else
            {

                Console.WriteLine("Sin conexión a internet");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                WebClient client = new WebClient();
                Stream Stream = client.OpenRead("http://www.google.com");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
