using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface ICategoriesController
    {
        Task<ActionResult<Category>> DeleteCategory(int id);
        Task<ActionResult<IEnumerable<Category>>> GetCategories();
        Task<ActionResult<Category>> GetCategory(int id);
        Task<ActionResult<Category>> PostCategory(Category category);
        Task<IActionResult> PutCategory(int id, Category category);
    }
}