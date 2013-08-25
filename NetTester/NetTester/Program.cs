using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace NetTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // resize window so it's not maximized
            Console.SetWindowSize(50, 25);
            
            // Send out ping
            Ping sending = new Ping();
            // Options for the ping
            PingOptions options = new PingOptions();
            // Don't fragment the ping.
            options.DontFragment = false;
            // 32 bit message to be sent.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // encode the data to bytes
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            // have a time out just in case
            int timeout = 120;
            // try pinging
            try
            {
                PingReply reply = sending.Send("8.8.8.8", timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    Console.Write("Success!");
                }
                else
                {
                    // network may be down.
                    Console.Write("Connection failed");
                }
            }
            catch (Exception)
            {
                // just a catch all
                Console.Write("Host not found");
                
            }
            Console.ReadLine();
        }
    }
}
