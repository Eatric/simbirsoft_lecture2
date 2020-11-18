using Microsoft.Extensions.DependencyInjection;

namespace SimbirSoft.API.WebApp.Common.Swagger
{
    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Simbirsoft WebApp";
                c.DocumentName = SwaggerGroups.Cinema;
                c.ApiGroupNames = new[] { SwaggerGroups.Cinema };
                c.GenerateXmlObjects = true;
            });
        }
    }
}
