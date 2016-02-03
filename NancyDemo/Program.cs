using System;
using Microsoft.Owin.Hosting;

namespace NancyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 8081;

            using (WebApp.Start<Startup>(string.Format("http://+:{0}", port)))
            {
                Console.WriteLine("Nancy now listening on http://+:" + port);

                var line = Console.ReadLine();
                while (line != "quit")
                {
                    line = Console.ReadLine();
                }
            }
        }
    }


}
