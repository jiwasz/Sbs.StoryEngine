using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using SmallBasketStudios.Audio.Data;
using SmallBasketStudios.Audio.Models;
using SmallBasketStudios.Audio.Models.Configuration;

namespace SmallBasketStudios.Audio.Repository
{
    public static class SkillRequestProcessor
    {
        public static async Task<SkillResponse> ProcessSkillRequest(DbConnections config, SkillRequest rootRequest)
        {
          SkillResponse rootResp = null;
            try
            {
                string skillId = rootRequest.Session.Application.ApplicationId;

                ITitleRepository titleRep = RepositoryFactory.GetTitleRepository(config);

                AudioTitle foundTitle = await titleRep.GetBySkillId(skillId);


                var requestType = rootRequest.GetRequestType();

                if (requestType == typeof(IntentRequest))
                {
                    // do some intent-based stuff
                }
                else if (requestType == typeof(Alexa.NET.Request.Type.LaunchRequest))
                {
                    rootResp = await ProcessLaunchRequest(config, foundTitle);
                }
                else if (requestType == typeof(AudioPlayerRequest))
                {
                    // do some audio response stuff
                }

                // Do som

            }
            catch(Exception ex)
            {
                // TODO Log this somewhere
                Debug.WriteLine(ex);

            }

      //     AudioTitle title = rep.Single<AudioTitle>(x => x.SkillId.Equals(skillId, StringComparison.InvariantCultureIgnoreCase));


            return rootResp;
        }

        private static async Task<SkillResponse> ProcessLaunchRequest(DbConnections config, AudioTitle foundTitle)
        {
            var speech = new Alexa.NET.Response.SsmlOutputSpeech();
            speech.Ssml = string.Format("<speak>Starting app {0}.<break strength=\"x-strong\"/>Look at my butt.</speak>", foundTitle.Title);

            // create the response using the ResponseBuilder
            var finalResponse = ResponseBuilder.Tell(speech);
            return finalResponse;
        }
    }
}
