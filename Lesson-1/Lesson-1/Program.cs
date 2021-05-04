using System;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        private static readonly HttpClient _client = new HttpClient();
        
        private static readonly string _sourceAddress = "https://jsonplaceholder.typicode.com/posts/";

        private static readonly string _responseFile = "Responses.txt";

        private static int _firstPostIndex = 4;

        private static int _postsListLenght = 10;


        static async Task Main(string[] args)
        {
            HttpResponseMessage response = await _client.GetAsync(_sourceAddress + _firstPostIndex);                                               
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            
            var s = JsonSerializer.Deserialize<ResponseModel>(responseBody, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            }); 

            Console.WriteLine();
        }
    }  
}
