using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        [BindProperty]
        public Category Category { get; set; }

        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Category = _dbContext.Categories?.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            _dbContext.Categories.Update(Category);
            _dbContext.SaveChanges();
            TempData["success"] = "Category updated successfully.";
            return RedirectToPage("Index");
        }
    }
}
