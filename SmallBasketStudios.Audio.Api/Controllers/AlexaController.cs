using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmallBasketStudios.Audio.WebLibrary;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmallBasketStudios.Audio.Repository;

namespace SmallBasketStudios.Audio.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/alexa")]
    public class AlexaController : Controller
    {
       private Models.Configuration.DbConnections _config;

       // private IConfiguration _config;


        public AlexaController(IOptions<Models.Configuration.DbConnections> config)
        {
           _config = config.Value;

        }

        [HttpPost]
        public async Task<SkillResponse> SampleSession([FromBody] Alexa.NET.Request.SkillRequest request)
        { 
            return await SkillRequestProcessor.ProcessSkillRequest(_config, request);
        }


        //https://sbsazure.eastus.cloudapp.azure.com/SmallBasketStudios.Audio.Api/api/audio
        [HttpGet]
       // public async Task<HttpResponseMessage> GetAudio()
        public  int GetAudio()
        {
           // return await new Task<HttpResponseMessage>(() => return new HttpResponseMessage(System.Net.HttpStatusCode.OK));

            return 5;

        }

    }
}