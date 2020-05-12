using PostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF.DTOs
{
    [DataContract]
    public partial class PostDTO
    {
        public PostDTO()
        {
            this.Comments = new List<CommentDTO>(); //new HashSet<Comment>();
        }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Domain { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public virtual List<CommentDTO> Comments { get; set; }
    }

    public static class PostMapper
    {
        public static PostDTO GetModel(this Post post)
        {
            return new PostDTO()
            {
                PostId = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = post.Date
            };
        }

        public static Post GetData(this PostDTO post)
        {
            return new Post()
            {
                PostId = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = post.Date
            };
        }
    }
}
