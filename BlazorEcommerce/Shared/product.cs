using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
	public class Product
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;//Set String empty as default
		public string Description { get; set; } = string.Empty;

		public string? ImageUrl { get; set; } = string.Empty;
		[Column(TypeName="decimal(18,2)")]//define digits for model

		public decimal Price { get; set; }
	}
}
