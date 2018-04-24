﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SensorApi.Helpers;
using ZNetCS.AspNetCore.Authentication.Basic;
using ZNetCS.AspNetCore.Authentication.Basic.Events;

namespace SensorWebApi
{
    public class Startup
    {
        public static string ConnectionString { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = configuration.GetSection("Data").GetSection("ConnectionString").Value;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services
         .AddAuthentication(BasicAuthenticationDefaults.AuthenticationScheme)
         .AddBasicAuthentication(
             options =>
             {
                 options.Realm = "My Application";
                 options.Events = new BasicAuthenticationEvents
                 {
                     OnValidatePrincipal = context =>
                     {
                         if ((context.UserName == "userName") && (context.Password == "password"))
                         {
                             var claims = new List<Claim>
                             {
                                new Claim(ClaimTypes.Name, context.UserName, context.Options.ClaimsIssuer)
                             };

                             var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, BasicAuthenticationDefaults.AuthenticationScheme));
                             context.Principal = principal;
                         }
                         else
                         {
                             // optional with following default.
                             context.AuthenticationFailMessage = "Authentication failed.";
                         }

                         return Task.CompletedTask;
                     }
                 };
             });


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });


            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            

        }
    }
}
