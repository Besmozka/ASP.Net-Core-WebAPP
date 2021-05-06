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

        private static int _postsListCount = 10;


        static async Task Main(string[] args)
        {
            _cancelToken.CancelAfter(5000);
            Task<string>[] responseBody = new Task<string>[_postsListCount];

            for (int i = 0; i < _postsListCount; i++)
            {
                responseBody[i] = GetResponse(_firstPostIndex + i);
            }
            await Task.WhenAll(responseBody);

            for (int i = 0; i < _postsListCount; i++)
            {
                SaveResponse(responseBody[i]);
            }

            Console.WriteLine();
        }


        public static Task<string> GetResponse(int index)
        {
            try
            {
                var response =  _client.GetAsync(_sourceAddress + index, _cancelToken.Token);
                var result = response.Result.Content.ReadAsStringAsync();
                return result;
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Task was cancel by timeout");
            }
            catch (HttpRequestException httpRequestException)
            {
                Console.WriteLine(httpRequestException.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }


        public static void SaveResponse(Task<string> response)
        {
            var responseModel = JsonSerializer.Deserialize<ResponseModel>(response.Result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            try
            {
                File.AppendAllLines(_responseFile, responseModel.ToList());
                File.AppendAllText(_responseFile, "\n");
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }  
}
