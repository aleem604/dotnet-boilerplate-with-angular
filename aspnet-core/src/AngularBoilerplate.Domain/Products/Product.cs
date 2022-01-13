using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AngularBoilerplate.Products
{
	public class Product: FullAuditedAggregateRoot<int>, IMustHaveTenant
	{
		[Required, MaxLength(100)]
		public string Name { get; set; }
		[Required, Range(10,9000)]
		public double Price { get; set; }
		[Required, Range(0, double.MaxValue)]
		public int Quantity { get; set; }
		[Required]
		public ProductType ProductType { get; set; }
		public int TenantId { get; set; }
	}
}
