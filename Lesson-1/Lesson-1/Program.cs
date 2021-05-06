using System;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        private static readonly CancellationTokenSource _cancelToken = new CancellationTokenSource();

        private static readonly HttpClient _client = new HttpClient();
        
        private static readonly string _sourceAddress = "https://jsonplaceholder.typicode.com/posts/";

        private static readonly string _responseFile = "C:\\New\\result.txt";

        private static int _firstPostIndex = 4;

        private static int _postsListLenght = 10;


        static void Main(string[] args)
        {
            _cancelToken.CancelAfter(5000);

            File.Create(_responseFile);

            var responseBody = GetResponse();

            SaveResponse(responseBody);

            Console.WriteLine();
        }


        public static async Task<string> GetResponse()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response =
                    await _client.GetAsync(_sourceAddress + _firstPostIndex, _cancelToken.Token);
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Task was cancel by timeout");
            }
            catch (HttpRequestException httpRequestException)
            {
                Console.WriteLine(httpRequestException.Message);
            }

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


        public static async Task SaveResponse(Task<string> response)
        {
            _cancelToken.CancelAfter(10000);
            var responseModel = JsonSerializer.Deserialize<ResponseModel>(response.Result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            if (File.Exists(_responseFile))
            {
                try
                {
                    await File.AppendAllLinesAsync(_responseFile, responseModel.ToList(), _cancelToken.Token);
                    await File.AppendAllTextAsync(_responseFile, "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }  
}
