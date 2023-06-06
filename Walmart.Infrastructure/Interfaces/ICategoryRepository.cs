using Walmart.ApplicationCore.Models;
using Walmart.ApplicationCore.ViewModels;
using Walmart.ApplicationCore.ParamModels;
using Walmart.ApplicationCore.DtoModels;

namespace Walmart.Infrastructure.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<CategoryDto> GetCategories();
        Category CreateCategory();
    }
}