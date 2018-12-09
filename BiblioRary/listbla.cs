using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BiblioRary
{
    class listbla
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            foreach (var s in list)
            {

            }
            foreach (var s in MyList())
            {


            }
            Console.ReadKey();
        }
    }

    private static IEnumberable<string> MyList()
    {
        var client = new HttpClient();
        var result = client.GetStringAsync("www.google.com").Result;
        yield return result;
    }
}
