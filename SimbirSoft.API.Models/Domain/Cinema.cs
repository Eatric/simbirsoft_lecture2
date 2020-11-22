namespace SimbirSoft.API.Models.Domain
{
	/// <summary>
	/// Кинотеатр
	/// </summary>
	public class Cinema
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Название кинотеатра
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		public byte NumberOfHalls { get; set; }

		/// <summary>
		/// Список фильмов к показу
		/// </summary>
		public Movie[] Movies { get; set; }
	}
}
