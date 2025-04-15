namespace TreksterIntegrationTests.Helpers
{
    public class AuthenticatedHttpClientHandler : DelegatingHandler
    {
        private readonly string _userId;

        public AuthenticatedHttpClientHandler(string userId)
        {
            _userId = userId;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
