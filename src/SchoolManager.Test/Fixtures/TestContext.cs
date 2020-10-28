using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SchoolManager.API;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace SchoolManager.Test.Fixtures
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public TestContext()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = _server.CreateClient();
        }

        public StringContent GetContent(object dado)
        {
            return new StringContent(
                JsonSerializer.Serialize(dado),
                Encoding.UTF8,
                "application/json");
        }

    }


}
