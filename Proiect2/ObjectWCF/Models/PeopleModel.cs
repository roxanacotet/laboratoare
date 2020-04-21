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
	public partial class PeopleModel
	{
		[DataMember] public int Id { get; set; }
		[DataMember] public int IdPhoto { get; set; }
		[DataMember] public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public static class PeopleMapper
	{
		public static PeopleModel GetModel(this Peoples item)
		{
			return new PeopleModel()
			{
				Id = item.Id,
				IdPhoto = item.IdPhoto,
				Name = item.Name
			};
		}
		
		public static Peoples GetData(this PeopleModel item)
		{
			return new Peoples()
			{
				Id = item.Id,
				IdPhoto = item.IdPhoto,
				Name = item.Name
			};
		}
	}
}
