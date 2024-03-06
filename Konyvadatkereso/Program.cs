using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Konyvadatkereso;

namespace Konyvadatkereso
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg az könyv ISBN számát: ");
            string isbn = Console.ReadLine();
            await book(isbn);
            Console.ReadLine();
        }

        private static async Task book(string json)
        {
            string apiUrl = $"https://www.goodreads.com/book/isbn/isbn?key=apiKey";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("Valami hiba lépett fel a köny keresése során.");
                }
            }
        }
    }
}
