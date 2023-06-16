using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace HostGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((services) =>
            services.AddHostedService<HostedService>())
            .Build();

            host.RunAsync();

        }
    }
}