using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Diretors
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Diretor Diretor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diretor = await _context.Diretor.FirstOrDefaultAsync(m => m.ID == id);

            if (Diretor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diretor = await _context.Diretor.FindAsync(id);

            if (Diretor != null)
            {
                _context.Diretor.Remove(Diretor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
