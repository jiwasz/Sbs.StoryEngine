//using System;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration.Json;

//namespace SmallBasketStudios.Audio.Test
//{
//    public class Program
//    {
//        public IConfigurationRoot Configuration { get; }

//        public static void Main(string[] args)
//        {

            
//           var configuration = new ConfigurationBuilder()
//                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//                   .Build();


//            // .SetBasePath(env.ContentRootPath)

//            //.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
//            //.AddEnvironmentVariables()

//        }

  

//        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
//        //{
//        //    // Setup logging
//        //    // Configure app

//        //}

//        //public void ConfigureServices(IServiceCollection services)
//        //{
//        //    // Configure services
//        //    services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSettings"));
//        //    services.AddOptions();
//        //}
//    }

//}
