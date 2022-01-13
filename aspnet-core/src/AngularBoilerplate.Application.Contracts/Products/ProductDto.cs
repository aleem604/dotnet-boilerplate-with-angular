using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AngularBoilerplate.Products
{
	public class CreatePrductDto
	{
		[Required, MaxLength(100)]
		public string Name { get; set; }
		[Required, Range(10, 9000)]
		public double Price { get; set; }
		[Required, Range(0, double.MaxValue)]
		public int Quantity { get; set; }
		[Required]
		public ProductType ProductType { get; set; }

	}

	public class ProductDto : EntityDto<int>
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }
		public ProductType ProductType { get; set; }
	}
}
