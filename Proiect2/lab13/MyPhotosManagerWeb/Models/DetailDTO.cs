using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosManagerWeb.Models
{
	public class DetailDTO
	{
		public int Id { get; set; }
		public int IdPhoto { get; set; }
		public string DetailKey { get; set; }
		public string DetailValue { get; set; }
	}
}
