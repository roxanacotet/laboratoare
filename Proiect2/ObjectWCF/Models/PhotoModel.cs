using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MyPhotosManagerDataAccess;

namespace MyPhotosManagerWCFService.Models
{
	[DataContract]
	public partial class PhotoModel
	{
		[DataMember] public int Id { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public string Path { get; set; }
        [DataMember] public string CreationDate { get; set; }
        [DataMember] public string Location { get; set; }
        [DataMember] public bool IsDeleted { get; set; }
        [DataMember] public bool IsVideo { get; set; }
        [DataMember] public virtual EventModel Event { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }

    public static class PhotoMapper
    {
        public static PhotoModel GetModel(this Photos item)
        {
            return new PhotoModel()
            {
                Id = item.Id,
                Name = item.Name,
                Path = item.Path,
                CreationDate = item.CreationDate,
                Location = item.Location,
                IsVideo = item.IsVideo,
                IsDeleted = item.IsDeleted,
                Event = item.Event.GetModel()
            };
        }

        public static Photos GetData(this PhotoModel item)
        {
            return new Photos()
            {
                Id = item.Id,
                Name = item.Name,
                Path = item.Path,
                CreationDate = item.CreationDate,
                Location = item.Location,
                IsVideo = item.IsVideo,
                IsDeleted = item.IsDeleted
            };
        }
    }
}
