using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace ConsoleApplication
{

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
           {
               return context.Response.WriteAsync("hello, charlie... and goodnight :)");
           }
        );
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Build();

                host.Run();



                /*
                Console.WriteLine("Hello World!");
                var name = Console.ReadLine();

                //Console.WriteLine($"Hey, {0} welcome to C#", name); //the old way
                Console.WriteLine($"Hey, {name}! Welcome to C#");
                Console.ReadLine();
                */
            }
        }
    }
}
