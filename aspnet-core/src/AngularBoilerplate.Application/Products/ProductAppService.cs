using AngularBoilerplate.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AngularBoilerplate.Products
{
	[Authorize(AngularBoilerplatePermissions.CrudProduct)]
	public class ProductAppService : CrudAppService<Product, ProductDto, int, PagedAndSortedResultRequestDto, CreatePrductDto>
	{
		public ProductAppService(IRepository<Product, int> repository) : base(repository)
		{

		}
	}



}
