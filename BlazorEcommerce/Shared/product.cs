using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
	public class product
	{
		public int id { get; set; }
		public string Title { get; set; } = string.Empty;//Set String empty as default
		public string Description { get; set; } = string.Empty;

		public string ImageUrl { get; set; }

		public decimal price { get; set; }
	}
}
