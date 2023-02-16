using AdventureWorks.Application;
using AdventureWorks.Application.Interfaces;
using AdventureWorks.Application.Interfaces.Mappers;
using AdventureWorks.Application.Mappers;
using AdventureWorks.Data.Config;
using AdventureWorks.Data.Repository;
using AdventureWorks.Domain.Interfaces.Repositories;
using AdventureWorks.Domain.Interfaces.Services;
using AdventureWorks.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QyonAdventureWorks
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
            var connection = Configuration["Connection:ConnectionString"];
            services.AddDbContext<ContextBase>(options => options.UseNpgsql(connection));
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddScoped<ICompetitorRepository, CompetitorRepository>();
            services.AddScoped<IRaceHistoryRepository, RaceHistoryRepository>();
            services.AddScoped<IRaceTrackRepository, RaceTrackRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IApplicationServiceCompetitor, ApplicationServiceCompetitor>();
            services.AddScoped<IApplicationServiceRaceHistory, ApplicationServiceRaceHistory>();
            services.AddScoped<ICompetitorService, CompetitorService>();
            services.AddScoped<IRaceHistoryService, RaceHistoryService>();

            services.AddScoped<ICompetitorMapper, CompetitorMapper>();
            services.AddScoped<IRaceHistoryMapper, RaceHistoryMapper>();
            services.AddScoped<IApplicationValidations, ApplicationValidations>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
