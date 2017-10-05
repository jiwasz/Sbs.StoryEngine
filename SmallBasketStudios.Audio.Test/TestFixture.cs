using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Net.Http.Headers;


namespace SmallBasketStudios.Audio.Test
{
    public class TestServerFixture : IDisposable
    {
        private TestServer testServer;

        protected TestServer TestServer
        {
            get
            {
                //if (testServer == null)
                //    testServer = new TestServer(new WebHostBuilder().UseEnvironment("Development")
                //        .UseStartup<SmallBasketStudios.Audio.Api.Startup>());



                if (testServer == null)
                    testServer = new TestServer(new WebHostBuilder()
                        .UseEnvironment("Development")                     
                        .UseStartup<SmallBasketStudios.Audio.Api.Startup>());

                return testServer;
            }
        }

        protected SetCookieHeaderValue Cookie { get; set; }

        public HttpClient Client
        {
            get
            {
               HttpClient testCliet =  TestServer.CreateClient();

                testCliet.BaseAddress = new Uri( "http://localhost");

                return testCliet;
            }
        }

        public async Task<HttpRequestMessage> MyHttpRequestMessage(HttpMethod method, string requestUri)
        {

         //  Cookie = SetCookieHeaderValue.Parse(response.Headers.GetValues("Set-Cookie").First());

            var request = new HttpRequestMessage(method, requestUri);

            request.Headers.Add("Cookie", new CookieHeaderValue(Cookie.Name, Cookie.Value).ToString());
            request.Headers.Accept.ParseAdd("text/xml");
            request.Headers.AcceptCharset.ParseAdd("utf-8");
            return request;
        }

        public void Dispose()
        {
            if (testServer != null)
            {
                testServer.Dispose();
                testServer = null;
            }
        }
    }
}
