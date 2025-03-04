using System.Threading.Channels;

namespace ConsoleApp7
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var content = await Readcontent("https://www.youtube.com/watch?v=kDUDX3VJFEc&list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l&index=39&t=2318s");
            Console.WriteLine(content);
            Console.ReadKey();


        }
        
        static async Task<string> Readcontent(string url)
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            return content;
        }
    }
}
