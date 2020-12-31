using Abp.Application.Services;
using RepositoryManager.MultiTenancy.Dto;

namespace RepositoryManager.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

