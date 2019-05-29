using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
	public class Product : BaseModel
	{
		public double price { get; set; }
		public string Name { get; set; }
		public int SpecificationId { get; set; }
		
		public virtual Array Specifications { get; set; }
	}
}
