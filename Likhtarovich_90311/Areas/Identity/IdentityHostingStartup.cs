using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Likhtarovich_90311.DAL.Data;
using Likhtarovich_90311.DAL.Entities;

[assembly: HostingStartup(typeof(Likhtarovich_90311.Areas.Identity.IdentityHostingStartup))]
namespace Likhtarovich_90311.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}