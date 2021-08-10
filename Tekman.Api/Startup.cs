using AutoMapper;
using FrancoRecreativo.Infrastructure.Filters;
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
using Tekman.Repository;
using Tekman.Service.Interface;
using Tekman.Service.Mapping;
using Tekman.Service.Services;

namespace Tekman.Api
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
            services.AddControllers(options =>
              options.Filters.Add(new ApiExceptionFilterAttribute())
            );

            //Inyecci�n de dependencias servicios
            services.AddTransient<IPreguntasService, PreguntasService>();
            services.AddTransient<IActividadService, ActividadService>();
            services.AddTransient<IEjercicioService, EjercicioService>();
            services.AddTransient<ICompetenciaService, CompetenciaService>();

            //Automapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //inyeccion de la base de datos en memoria
            services.AddDbContext<TekmanDBContext>(options => options.UseInMemoryDatabase(databaseName: "TekmanDB"));
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
