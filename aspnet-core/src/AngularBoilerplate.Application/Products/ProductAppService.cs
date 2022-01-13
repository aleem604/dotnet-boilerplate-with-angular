using AngularBoilerplate.Permissions;
using Microsoft.AspNetCore.Authorization;
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
