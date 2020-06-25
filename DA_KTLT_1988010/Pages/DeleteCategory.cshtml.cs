using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA_KTLT_1988010.BLL.Repositoties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DA_KTLT_1988010.Pages
{
    public class DeleteCategoryModel : PageModel
    {
        public void OnGet(int id)
        {
            var categoryRepo = new CategoryRepo();
            bool success = categoryRepo.Delete(id);
            if (success)
                ViewData["DeleteCategory"] = "Delete category successfully.";
            else ViewData["DeleteCategory"] = $"Error! There's no product with ID = {id}.";
        }
    }
}