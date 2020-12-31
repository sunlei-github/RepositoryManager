using System.Threading.Tasks;
using Abp.Application.Services;
using RepositoryManager.Sessions.Dto;

namespace RepositoryManager.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
