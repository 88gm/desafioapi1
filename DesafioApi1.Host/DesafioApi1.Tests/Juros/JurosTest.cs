using DesafioApi1.Host;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;

namespace DesafioApi1.Tests
{
    public class JurosTest
    {
        private readonly HttpClient _httpClient;

        public JurosTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _httpClient = appFactory.CreateClient();
        }

        [Fact]
        public async void GetTaxa()
        {
            var res = await _httpClient.GetAsync("api/juros/taxa");
            Assert.Equal(System.Net.HttpStatusCode.OK, res.StatusCode);
        }
    }
}
