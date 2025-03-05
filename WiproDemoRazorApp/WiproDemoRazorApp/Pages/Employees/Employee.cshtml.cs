using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproDemoRazorApp.Models;

namespace WiproDemoRazorApp.Pages.Employees
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Employee emps { get; set; } = new Employee();
        public void OnGet()
        {
             // this method will be called automatically when the page is loaded
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Page();
        }
}
