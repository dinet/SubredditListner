﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SubRedditListner.Services
{

    public class RateLimitedHttpClient : IRateLimitedHttpClient
    {
        private readonly IRedditPostClient _redditPostClient;

        public RateLimitedHttpClient(IRedditPostClient redditPostClient)
        {
            _redditPostClient = redditPostClient;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            CancellationToken cancellationToken = default;
            int interval = 100;
            while (true)
            {
                var response = await _redditPostClient.PostAsync();
                await Task.Delay(interval, cancellationToken);
            }
        }
    }
}
