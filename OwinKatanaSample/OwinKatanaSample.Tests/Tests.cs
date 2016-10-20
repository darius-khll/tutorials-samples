using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OwinKatanaSample.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public async Task TestWebApi()
        {
            using (TestServer server = TestServer.Create<OwinAppStartup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("/api/products/1");
                response.EnsureSuccessStatusCode();
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
