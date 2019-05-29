using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain
{
	public class Specification : BaseModel
	{
		public string Author { get; set; }

		public int IllustratorId { get; set; }

		public virtual Array Illustrators { get; set; }

		public int GenreId { get; set; }

		public virtual Array Genres { get; set; }
	}
}
