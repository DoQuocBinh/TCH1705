using System;
using Newtonsoft.Json;
using StringLibrary;

namespace ShowCase
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Hello World! starts with uppper:" + "Hello World!".StartsWithUpper());
            Console.WriteLine("hello World! starts with uppper:" + "hello World!".StartsWithUpper());
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@microsoft.com",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
