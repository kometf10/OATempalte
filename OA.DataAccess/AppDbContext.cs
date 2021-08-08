using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using OA.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OA.Domin;
using OA.Domin.Reporting;
using OA.Domin.Logging;
using OA.Domin.Settings;
using OA.Domin.Notifications;
using OA.Domin.Administration;
using OA.DataAccess.Auditing;
using OA.Domin.Auditing;
using OA.Domin.Reporting.TemplateReporting;


namespace OA.DataAccess
{
    public partial class AppDbContext : IdentityDbContext<User>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            httpContextAccessor = this.GetInfrastructure().GetRequiredService<IHttpContextAccessor>();
        }

        //Reporting
        public DbSet<ReportableTable> ReportableTables { get; set; }
        public DbSet<ReportTemplate> ReportTemplates { get; set; }
        public DbSet<ReportHeader> ReportHeaders { get; set; }
        public DbSet<ReportTextTemplate> ReportTextTemplates { get; set; }

        //Exception Log
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }

        //App Settings
        public DbSet<AppSetting> AppSettings { get; set; }

        //Notification
        public DbSet<Notification> Notifications { get; set; }

        //Administration
        public DbSet<SignupRequest> SignupRequests { get; set; }
        public DbSet<PermissionClaim> PermissionClaims { get; set; }
        public DbSet<VerificationQuestion> VerificationQuestions { get; set; }
        public DbSet<UserVerificationAnswer> UserVerificationAnswers { get; set; }

        //Auditing 
        public DbSet<Audit> Audits { get; set; }

        
        //Testing functionality
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<City> Cities { get; set; }


    }
}
