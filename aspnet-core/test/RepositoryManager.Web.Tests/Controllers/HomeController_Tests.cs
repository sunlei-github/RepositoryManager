using System.Threading.Tasks;
using RepositoryManager.Models.TokenAuth;
using RepositoryManager.Web.Controllers;
using Shouldly;
using Xunit;

namespace RepositoryManager.Web.Tests.Controllers
{
    public class HomeController_Tests: RepositoryManagerWebTestBase
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