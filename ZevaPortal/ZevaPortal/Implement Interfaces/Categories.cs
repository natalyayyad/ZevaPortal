using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class Categories : ICategoriesController
    {
        public Task<ActionResult<Category>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Category>> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Category>> PostCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutCategory(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
