using System;
using System.IO;
using System.Net;
using static System.Net.WebProxy;

namespace ScrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://fri.uniza.sk";
            WebRequest q = WebRequest.Create(url);
            q.Proxy = GetDefaultProxy();

            Stream dataStream;
            dataStream = q.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(dataStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
            }
            Console.ReadLine();
        }
    }
}
