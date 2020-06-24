using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA_KTLT_1988010.BLL.Repositoties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DA_KTLT_1988010.Pages
{
    public class DeleteProductModel : PageModel
    {
        public void OnGet(int id)
        {
            var productRepo = new ProductRepo();
            bool success = productRepo.Delete(id);
            if (success)
                ViewData["DeleteProduct"] = "Delete product successfully.";
            else ViewData["DeleteProduct"] = $"Error! There's no product with ID = {id}.";
        }
    }
}