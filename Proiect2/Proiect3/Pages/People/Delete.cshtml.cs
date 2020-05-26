using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosManagerWeb.Data;
using MyPhotosManagerWeb.Models;

namespace MyPhotosManagerWeb.Pages.People
{
    public class DeleteModel : PageModel
    {
        private readonly MyPhotosManagerWeb.Data.MyPhotosManagerWebContext _context;

        public DeleteModel(MyPhotosManagerWeb.Data.MyPhotosManagerWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PeopleDTO PeopleDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PeopleDTO = await _context.PeopleDTO.FirstOrDefaultAsync(m => m.Id == id);

            if (PeopleDTO == null)
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

            PeopleDTO = await _context.PeopleDTO.FindAsync(id);

            if (PeopleDTO != null)
            {
                _context.PeopleDTO.Remove(PeopleDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
