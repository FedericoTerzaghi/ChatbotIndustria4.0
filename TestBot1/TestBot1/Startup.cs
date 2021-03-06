﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.3.0

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Bot.Connector.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TestBot1.Bots;

namespace TestBot1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(
                options => options.AddPolicy("AllowCors",
                    builder =>
                    {
                        builder
                            .WithOrigins("http://localhost:4200")
                            .AllowCredentials()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    })
            );
            services.AddSingleton<IStorage, MemoryStorage>();
            services.AddSingleton<UserState>();
            services.AddSignalR();


            services.AddBot<EchoBot>(options =>

            {
                var appId = Configuration.GetSection("MicrosoftAppId").Value;
                var appPassword = Configuration.GetSection("MicrosoftAppPassword").Value;

                options.CredentialProvider = new SimpleCredentialProvider(appId, appPassword);
                //options.CredentialProvider = new ConfigurationCredentialProvider(Configuration);



                //var middleware = options.Middleware;

                //var personalityChatOptions = new EchoBot(botPersona: Core.PersonalityChatPersona.Humorous, respondOnlyIfChat: true, scoreThreshold: 0.5F);



                //middleware.Add(new EchoBot(personalityChatOptions));

            });








            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Create the credential provider to be used with the Bot Framework Adapter.
            services.AddSingleton<ICredentialProvider, ConfigurationCredentialProvider>();

            // Create the Bot Framework Adapter.
            services.AddSingleton<IBotFrameworkHttpAdapter, BotFrameworkHttpAdapter>();

            // Create the bot as a transient. In this case the ASP Controller is expecting an IBot.
            services.AddTransient<IBot, EchoBot>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {


            //app.UseCors("CorsPolicy");
            app.UseCors("AllowCors");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSignalR(routes =>
            {
                routes.MapHub<Models.ChatHub>("/chat");
            });
            //app.Use(options =>
            //{
            //    
            //});

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
