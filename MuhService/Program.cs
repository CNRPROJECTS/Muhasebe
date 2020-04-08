using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace MuhService.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostAddress = "http://127.0.0.1:4567/";
            var appHost = new AppHost().Init().Start(hostAddress);

            Console.WriteLine("Host is running at {0}", hostAddress);
            Console.ReadLine();

        }
    }
    public class AppHost
        : AppSelfHostBase
    {
        public AppHost()
            : base("HttpListener Self-Host", typeof(Services).Assembly)
        {
        }
        public override void Configure(Funq.Container container)
        {
        }
    }

    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public string Password { get; set; }
    }

    public Users class AllUsers
    {
      
    }

    public class Services : Service
    {
        public static List<User> Users = new List<User>
        {
            new User {Id = 1, Username = "caner", Password = "123456"},
            new User {Id = 2, Username = "hasan", Password = "654321"}
        };
        public object Get()
        {
            return Users;
        }

    }

}