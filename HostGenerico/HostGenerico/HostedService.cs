using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostGenerico
{
    internal class HostedService : IHostedService
    {

            public Task StartAsync(CancellationToken cancellationToken)
            {
                Console.WriteLine("Work in Progress");

                return Task.CompletedTask;
            }

            public Task StopAsync(CancellationToken cancellationToken)
            {

                return Task.CompletedTask;
            }


    }
}
