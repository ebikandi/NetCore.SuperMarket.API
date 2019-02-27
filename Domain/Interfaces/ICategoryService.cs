using System.Collections.Generic;
using System.Threading.Tasks;
using NetCore.SuperMarket.API.Domain.Models;

namespace NetCore.SuperMarket.API.Domain.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}