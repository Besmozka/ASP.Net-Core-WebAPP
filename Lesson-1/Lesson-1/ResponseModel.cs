using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class ResponseModel
    {
        public int UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public ResponseModel()
        {
            UserId = new int();
            Id = new int();
            Title = null;
            Body = null;
        }

        internal void Print()
        {
            Console.SetCursorPosition(Console.WindowWidth/2 - Title.Length / 2, Console.CursorTop);
            Console.WriteLine(Title);
            Console.WriteLine(Body);
        }

        internal List<string> ToList()
        {
            var list = new List<string>();
            list.Add(UserId.ToString());
            list.Add(Id.ToString());
            list.Add(Title);
            list.Add(Body);
            return list;
        }
    }
}
