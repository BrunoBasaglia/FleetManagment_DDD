using GestaoDeFrota.Application;
using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;
using GestaoDeFrota.Domain.Services;
using GestaoDeFrota.Infra.Contexto;
using GestaoDeFrota.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeFrota.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<GestaoDeFrotasContexto>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddScoped<IVeiculoAppService, VeiculoAppService>();
            services.AddScoped<ICambioAppService, CambioAppService>();
            services.AddScoped<ICategoriaAppService, CategoriaAppService>();
            services.AddScoped<IClasseAppService, ClasseAppService>();
            services.AddScoped<ICombustivelAppService, CombustivelAppService>();
            services.AddScoped<IFabricanteAppService, FabricanteAppService>();
            services.AddScoped<IImagemAppService, ImagemAppService>();
            services.AddScoped<IModeloAppService, ModeloAppService>();
            services.AddScoped<IMotorAppService, MotorAppService>();
            services.AddScoped<IOrigemAppService, OrigemAppService>();
            services.AddScoped<IQuilometragemAppService, QuilometragemAppService>();

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<ICambioService, CambioService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IClasseService, ClasseService>();
            services.AddScoped<ICombustivelService, CombustivelService>();
            services.AddScoped<IFabricanteService, FabricanteService>();
            services.AddScoped<IImagemService, ImagemService>();
            services.AddScoped<IModeloService, ModeloService>();
            services.AddScoped<IMotorService, MotorService>();
            services.AddScoped<IOrigemService, OrigemService>();
            services.AddScoped<IQuilometragemService, QuilometragemService>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<ICambioRepository, CambioRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IClasseRepository, ClasseRepository>();
            services.AddScoped<ICombustivelRepository, CombustivelRepository>();
            services.AddScoped<IFabricanteRepository, FabricanteRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();
            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IMotorRepository, MotorRepository>();
            services.AddScoped<IOrigemRepository, OrigemRepository>();
            services.AddScoped<IQuilometragemRepository, QuilometragemRepository>();
        }
    }
}
