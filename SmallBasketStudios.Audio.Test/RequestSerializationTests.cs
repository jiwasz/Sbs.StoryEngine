using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Xunit;
//using SmallBasketStudios.Audio.Repository.Alexa;
using Alexa.NET.Request;
using SmallBasketStudios.Audio.Repository;
using Alexa.NET.Response;

namespace SmallBasketStudios.Audio.Test
{
    public class RequestSerializationTests
    {


        [Fact]
        public void RequestStartIntent()
        {
            const string TestDataFile = @"RequestSamples\StartRequestIntent.json";

            string jsonRawText = File.ReadAllText(TestDataFile);

            SkillRequest req = JsonConvert.DeserializeObject<Alexa.NET.Request.SkillRequest>(jsonRawText);

        }

        [Fact]
        public void RequestLaunchIntent()
        {
            const string TestDataFile = @"RequestSamples\LaunchSkillRequest.json";

            string jsonRawText = File.ReadAllText(TestDataFile);

            SkillRequest req = JsonConvert.DeserializeObject<Alexa.NET.Request.SkillRequest>(jsonRawText);

           SkillResponse resp =    SkillRequestProcessor.ProcessSkillRequest(req);

        }

    }
}
