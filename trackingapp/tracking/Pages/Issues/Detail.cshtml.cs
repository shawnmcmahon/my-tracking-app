using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tracking.Data;
using tracking.Models;

namespace tracking.Pages.Issues
{
    public class DetailModel : PageModel
    {
        private readonly IssueDbContext _context;

        public DetailModel(IssueDbContext context) => _context = context;


        public async Task OnGet(int id) => Issue = await _context.Issues.FindAsync(id);

        public async Task OnGetResolve(int id)
        {
            var issueToUpdate = _context.Issues.SingleOrDefault(i => i.Id == id);
            if (issueToUpdate == null) return;

            issueToUpdate.Completed = DateTime.Now;
            _context.Update(issueToUpdate);
            await _context.SaveChangesAsync();  

        }
  
        public Issue? Issue { get; private set; }
    }
}
