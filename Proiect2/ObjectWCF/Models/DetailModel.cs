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
	public partial class DetailModel
	{
       [DataMember] public int Id { get; set; }
       [DataMember] public int IdPhoto { get; set; }
       [DataMember] public string DetailKey { get; set; }
       [DataMember] public string DetailValue { get; set; }
    }

    public static class DetailMapper
    {
        public static DetailModel GetModel(this Details item)
        {
            return new DetailModel()
            {
                Id = item.Id,
                IdPhoto = item.IdPhoto,
                DetailKey = item.DetailKey,
                DetailValue = item.DetailValue
            };
        }

        public static Details GetData(this DetailModel item)
        {
            return new Details()
            {
                Id = item.Id,
                IdPhoto = item.IdPhoto,
                DetailKey = item.DetailKey,
                DetailValue = item.DetailValue
            };
        }
    }
}
