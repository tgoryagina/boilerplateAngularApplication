using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleInvoiceSystem.People.Dtos;

namespace SimpleInvoiceSystem.People
{
    public interface IPersonAppService : IApplicationService
    {
        Task<GetAllPeopleOutput> GetAllPeople();
    }
}
