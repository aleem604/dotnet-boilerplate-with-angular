using Abp.AutoMapper;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
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

	[AutoMapFrom(typeof(Product))]
	[AutoMapTo(typeof(Product))]
	public class ProductDto : EntityDto<int>, IMustHaveTenant
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }
		public ProductType ProductType { get; set; }
		public int TenantId { get; set; }
	}
}
