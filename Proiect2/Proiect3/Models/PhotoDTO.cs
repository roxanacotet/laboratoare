using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosManagerWeb.Models
{
	public class PhotoDTO
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string CreationDate { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVideo { get; set; }
        public EventDTO  Event { get; set; }
    }
}
