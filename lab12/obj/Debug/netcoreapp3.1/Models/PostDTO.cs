using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RazorPagesMovies.Models
{
    [DataContract]
    public class PostDTO
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
}