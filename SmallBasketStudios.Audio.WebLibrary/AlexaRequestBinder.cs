using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SmallBasketStudios.Audio.WebLibrary
{
    public class AlexaRequestBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {

            Stream bodyStream = bindingContext.ActionContext.HttpContext.Request.Body;
            string bodyText = null;

         //   bodyStream.Position = 0;
            using (StreamReader reader = new StreamReader(bodyStream, Encoding.UTF8))
            {
                bodyText = reader.ReadToEnd();
            }

            Trace.TraceInformation("In Alexa Binder");

            return null;
        }
    }
}
