using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPhotosManagerWeb.Data;
using MyPhotosManagerWeb.Models;

namespace MyPhotosManagerWeb.Pages.Photo
{
    public class IndexModel : PageModel
    {
        private readonly MyPhotosManagerWeb.Data.MyPhotosManagerWebContext _context;

        public IndexModel(MyPhotosManagerWeb.Data.MyPhotosManagerWebContext context)
        {
            _context = context;
        }

        public IList<PhotoDTO> PhotoDTO { get;set; }
        public SelectList Photos { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> photoQuery = from m in _context.PhotoDTO orderby m.Location select m.Location;
      
            var photoss = from m in _context.PhotoDTO select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                photoss = photoss.Where(s => s.Name.Contains(SearchString ) || s.Location.Contains(SearchString) ||s.Event.Name.Contains(SearchString)
                ||s.CreationDate.Contains(SearchString));
            }

            Photos = new SelectList(await photoQuery.Distinct().ToListAsync());
            PhotoDTO = await photoss.ToListAsync();  
        }
    }
}
