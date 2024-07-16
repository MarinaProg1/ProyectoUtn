using Microsoft.Extensions.DependencyInjection;
using SistemaGestion.Business;
using SistemaGestion.Data;
using SistemaGestion.Data.Repositories;
using SistemaGestion.Entities.Entities;
using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.ConsoleApp
{
    public class DependencyInjection
    {
        // Registrar los servicios.
        public static void Configure(IServiceCollection services)
        {
            services.AddDbContext<SistemaGestionContext>();

            // Registrar el repositorio genérico
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ProductoBusiness>();
            services.AddTransient<UsuarioBusiness>();
            services.AddTransient<CategoriaBusiness>();
            services.AddTransient<VentaBusiness>();
            services.AddTransient<CompraBusiness>();

        }
        // Obtener el servicio.
        public static ProductoBusiness GetProductoBusiness()
        {
            // Contenedor de servicios.
            var services = new ServiceCollection();
            DependencyInjection.Configure(services);
            var serviceProvider = services.BuildServiceProvider();
            // Obtener un servicio registrado.
            ProductoBusiness productoService = serviceProvider.GetRequiredService<ProductoBusiness>();
            return productoService;
        }
        public static UsuarioBusiness GetUsuarioBusiness()
        {
            var services = new ServiceCollection();
            DependencyInjection.Configure(services);
            var serviceProvider = services.BuildServiceProvider();
            UsuarioBusiness usuarioService = serviceProvider.GetRequiredService<UsuarioBusiness>();
            return usuarioService;
        }
        public static CategoriaBusiness GetCategoriaBusiness()
        {
            var services = new ServiceCollection();
            Configure(services);
            var serviceProvider = services.BuildServiceProvider();
            CategoriaBusiness categoriaService = serviceProvider.GetRequiredService<CategoriaBusiness>();
            return categoriaService;
        }

        public static VentaBusiness GetVentaBusiness()
        {
            var services = new ServiceCollection();
            Configure(services);
            var serviceProvider = services.BuildServiceProvider();
            VentaBusiness ventaService = serviceProvider.GetRequiredService<VentaBusiness>();
            return ventaService;
        }
        public static CompraBusiness GetCompraBusiness()
        {
            var services = new ServiceCollection();
            Configure(services);
            var serviceProvider = services.BuildServiceProvider();
            CompraBusiness compraService = serviceProvider.GetRequiredService<CompraBusiness>();
            return compraService;
        }
    }
}
