﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPhotosManagerWeb.Data;
using MyPhotosManagerWeb.Models;
using ServiceReferenceMyPhotosManagerWeb;

namespace MyPhotosManagerWeb.Pages.Detail
{
    public class CreateModel : PageModel
    {
        private readonly MyPhotosManagerWeb.Data.MyPhotosManagerWebContext _context;

        public CreateModel(MyPhotosManagerWeb.Data.MyPhotosManagerWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DetailDTO DetailDTO { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DetailDTO.Add(DetailDTO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
