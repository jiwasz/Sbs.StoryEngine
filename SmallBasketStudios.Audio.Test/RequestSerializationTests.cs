using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Xunit;
using Xunit.Extensions;
//using SmallBasketStudios.Audio.Repository.Alexa;
using Alexa.NET.Request;
using SmallBasketStudios.Audio.Repository;
using Alexa.NET.Response;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace SmallBasketStudios.Audio.Test
{
    public class RequestSerializationTests : IClassFixture<TestServerFixture>
    {
        public RequestSerializationTests(TestServerFixture fixture)
        {
            Fixture = fixture;
        }

        protected TestServerFixture Fixture { get; private set; }



        [Fact(DisplayName ="Sample Intent")]
     
        public void RequestStartIntent()
        {
            const string TestDataFile = @"RequestSamples\StartRequestIntent.json";

            string jsonRawText = File.ReadAllText(TestDataFile);

            SkillRequest req = JsonConvert.DeserializeObject<Alexa.NET.Request.SkillRequest>(jsonRawText);

        }

        [Fact(DisplayName ="Launch Request Test")]
        public async void RequestLaunchIntent()
        {

         //  var lastVal = Configuration.GetValue<string>("MySettings:ApplicationName");

            const string TestDataFile = @"RequestSamples\LaunchSkillRequest.json";

            string jsonRawText = File.ReadAllText(TestDataFile);

            SkillRequest req = JsonConvert.DeserializeObject<Alexa.NET.Request.SkillRequest>(jsonRawText);

        //   SkillResponse resp =    SkillRequestProcessor.ProcessSkillRequest(req);

            using (var client = Fixture.Client)
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/alexa");

                request.Content = new StringContent(jsonRawText, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();

                string obj = await response.Content.ReadAsStringAsync();
             //   SkillResponse resp = JsonConvert.DeserializeObject<SkillResponse>(obj);
              //  Assert.NotNull(resp);
      
            }




        }

    }
}
