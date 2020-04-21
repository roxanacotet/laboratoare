using MyPhotosManagerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosManagerWCFService.Models
{
	[DataContract]
	public partial class EventModel
	{
		[DataMember] public int Id { get; set; }
		[DataMember] public int IdPhoto { get; set; }
		[DataMember] public string Name { get; set; }
	}

	public static class EventMapper
	{
		public static EventModel GetModel(this Events item)
		{
			return new EventModel()
			{
				Id = item.Id,
				IdPhoto = item.IdPhoto,
				Name = item.Name
			};
		}

		public static Events GetData(this EventModel item)
		{
			return new Events()
			{
				Id = item.Id,
				IdPhoto = item.IdPhoto,
				Name = item.Name
			};
		}
	}
}
