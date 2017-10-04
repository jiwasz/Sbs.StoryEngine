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

namespace SmallBasketStudios.Audio.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/alexa")]
    public class AlexaController : Controller
    {

        [HttpPost]
        public SkillResponse SampleSession([FromBody] Alexa.NET.Request.SkillRequest request)
        {
            return SmallBasketStudios.Audio.Repository.SkillRequestProcessor.ProcessSkillRequest(request);
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