﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StripeFundamentals.Web.Startup))]
namespace StripeFundamentals.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
