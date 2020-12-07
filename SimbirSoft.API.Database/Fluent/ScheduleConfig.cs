using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SimbirSoft.API.Database.Domain;

namespace SimbirSoft.API.Database.Fluent
{
	/// <summary>
	/// Конфигурация миграций для <see cref="Schedule"/>
	/// </summary>
	public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
	{
		/// <summary>
		/// Метод для конфигурации миграции для <see cref="Schedule"/>
		/// </summary>
		/// <param name="builder">Билдер</param>
		public void Configure(EntityTypeBuilder<Schedule> builder)
		{
			builder.BaseEntityWithLinksConfig<Schedule, Cinema, Movie>(
				e => e.Schedules,
				e => e.Schedules);
		}
	}
}
