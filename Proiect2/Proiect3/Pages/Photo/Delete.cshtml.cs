using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosManagerWeb.Data;
using MyPhotosManagerWeb.Models;

namespace MyPhotosManagerWeb.Pages.Photo
{
    public class DeleteModel : PageModel
    {
        private readonly MyPhotosManagerWeb.Data.MyPhotosManagerWebContext _context;

        public DeleteModel(MyPhotosManagerWeb.Data.MyPhotosManagerWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PhotoDTO = await _context.PhotoDTO.FirstOrDefaultAsync(m => m.Id == id);

            if (PhotoDTO == null)
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

            PhotoDTO = await _context.PhotoDTO.FindAsync(id);

            if (PhotoDTO != null)
            {
                _context.PhotoDTO.Remove(PhotoDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
