using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosManagerWeb.Data;
using MyPhotosManagerWeb.Models;

namespace MyPhotosManagerWeb.Pages.Event
{
    public class DetailsModel : PageModel
    {
        private readonly MyPhotosManagerWeb.Data.MyPhotosManagerWebContext _context;

        public DetailsModel(MyPhotosManagerWeb.Data.MyPhotosManagerWebContext context)
        {
            _context = context;
        }

        public EventDTO EventDTO{ get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventDTO = await _context.EventDTO.FirstOrDefaultAsync(m => m.Id == id);

            if (EventDTO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
