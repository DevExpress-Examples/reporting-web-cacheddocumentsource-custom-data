using System;
using System.Collections.Generic;
using CustomCachedDocumentSourceSerialization.Data;
using CustomCachedDocumentSourceSerialization.Services;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CustomCachedDocumentSourceSerialization {
    public class Startup {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDevExpressControls();

            services.AddSingleton<WebDocumentViewerOperationLogger, CustomWebDocumentViewerOperationLogger>();
            services.AddSingleton<CustomPageDataProviderRegistry, CustomPageDataProviderRegistry>();
            services.AddScoped<IReportProvider, CustomReportProvider>();

            DevExpress.Xpf.Printing.ServiceKnownTypeProvider.Register(typeof(Dictionary<string, Dictionary<int, CustomPageData>>));
            DevExpress.Xpf.Printing.ServiceKnownTypeProvider.Register(typeof(Dictionary<int, CustomPageData>));

            services
                .AddMvc()
                .AddNewtonsoftJson();
            services.ConfigureReportingServices(configurator => {
                configurator.ConfigureReportDesigner(designerConfigurator => {
                });
                configurator.ConfigureWebDocumentViewer(viewerConfigurator => {
                    //viewerConfigurator.UseCachedReportSourceBuilder();
                    viewerConfigurator.UseFileDocumentStorage("PreviewedDocuments");
                });
                //configurator.UseAsyncEngine();
            });
            TimeSpan fifteenSeconds = TimeSpan.FromSeconds(15);
            var cacheCleanerSettings = new CacheCleanerSettings(fifteenSeconds, fifteenSeconds, fifteenSeconds, fifteenSeconds);
            services.AddSingleton(cacheCleanerSettings);
            services.AddDbContext<ReportDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("ReportsDataConnectionString")));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, ReportDbContext db) {
            db.InitializeDatabase();
            app.UseDevExpressControls();
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
