using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Owin.Security.Providers.LinkedIn;
using Owin;
using System;
using AmoghSystems.Models;

namespace AmoghSystems
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
            
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            //Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "000000004C120DFD",
            //    clientSecret: "qx8T21RHytSahFrdCsPtegp10J0JM12D");

            //app.UseTwitterAuthentication(
            //   consumerKey: "X12AkMa6jbfMMr6C4SlqiY0qk",
            //   consumerSecret: "vKOxAS4w7lhRLZFxHbnpyEvBP8lYPKAX0mxkWoe1JEtlmtd2Iy");

            app.UseFacebookAuthentication(
               appId: "610003729113634",
               appSecret: "75fb9aabbcf0fd0d3315f404b3dc7012");

            app.UseGoogleAuthentication(
                clientId: "47246977016-ttkejegk920l8kmv1lqlq27ufk0jrjve.apps.googleusercontent.com",
                clientSecret: "ArSFkw0Xsi5CPdUzwDrKTmDj");

            app.UseLinkedInAuthentication("75wl4l5f72iooo", "ffFnay7WISpGxnWf");
        }
    }
}