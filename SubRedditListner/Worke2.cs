using System.Threading;

namespace SubRedditListner
{
    public class Worker2 : BackgroundService
    {
        private readonly ILogger<Worker2> _logger;

        public Worker2(ILogger<Worker2> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

    //            while (true)
    //            {
    //                await FooAsync();
    //                await Task.Delay(interval, cancellationToken)
    //}
    //            _logger.LogError("Worker 2 running at: {time}", DateTimeOffset.Now);
    //            await Task.Delay(200, stoppingToken);
            }
        }
    }
}
