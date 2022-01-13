using System.Threading.Tasks;
using BoilerplateAngular.Models.TokenAuth;
using BoilerplateAngular.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerplateAngular.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateAngularWebTestBase
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