using Aplicacion.Mappers;
using AutoMapper;
using Dominio.Exceptions;
using Dominio.Models.Regla;
using Infraestructura.Data;
using Infraestructura.Filters;
using WebAPI.DependencyInjection;

public class Startup
{
    public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

    public Startup(Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHandlers();
        services.AddContextConfiguration(Configuration);
        services.AddMappers();
        services.AddScoped<UnitOfWordFilter>();
        services.AddAplicacionServices();
        services.AddMemoryCache();
        services.AddDistributedMemoryCache();
        services.AddTokenConfiguration(Configuration);
        services.AddHttpContextAccessor();
        services.AddCorsConfig();
        services.AddSwaggerConf();
        services.AddAutoMapper(typeof(MovieDtoToMovie));
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddControllersWithViews();
        services.AddMvc(option => option.EnableEndpointRouting = false);
        services.Scan(scan => scan.FromAssemblyOf<EntidadGestionado>()
                                .AddClasses(classes => classes.AssignableTo(typeof(IRegla)))
                                .AsImplementedInterfaces()
                                .WithTransientLifetime());
        services.AddControllersWithViews(options =>
        {
            options.Filters.Add(typeof(UnitOfWordFilter));
        }).AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpException();
        app.UseRouting();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/alpha/swagger.json", "Documentacion Movie Challenge");
        });

        app.UseCors("ApiCorsPolicy");
        app.UseMvc();
        using var scope = app.ApplicationServices.CreateScope();
        UpdateDatabase(scope.ServiceProvider);

    }
    private static void UpdateDatabase(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetService<MovieContext>();
        // runner.Rollback(1);
        // runner.MigrateUp();
    }
}