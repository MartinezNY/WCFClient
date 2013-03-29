using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfServiceClient
{
    class Program
    {
        /// <summary>
        /// Test 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            //Console.WriteLine(client.GetData(5));
            string result = client.PutData("", "bike rental", "10", "1", "11", "SITETEST", "2012-04-04 12:00", "2 hours", "1", "1", "1", "1", "1", "1", "123456", "1234415", "martin", "test");
        }
    }
}
