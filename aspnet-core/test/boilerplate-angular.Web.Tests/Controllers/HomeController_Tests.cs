using System.Threading.Tasks;
using boilerplate-angular.Models.TokenAuth;
using boilerplate-angular.Web.Controllers;
using Shouldly;
using Xunit;

namespace boilerplate-angular.Web.Tests.Controllers
{
    public class HomeController_Tests: boilerplate-angularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}