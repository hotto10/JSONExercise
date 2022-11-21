using Newtonsoft.Json.Linq;

namespace JSONExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            for (int i = 0; i < 5; i++)
            {
               var kanyeURL = "https://api.kanye.rest/";

                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                Console.WriteLine($" Kayne says {kanyeQuote}");

                var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var swansonResponse = client.GetStringAsync(swansonURL).Result;

                var ronQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine($"Ron responds {ronQuote}");

                Console.WriteLine();

            }

            
        }
    }
}