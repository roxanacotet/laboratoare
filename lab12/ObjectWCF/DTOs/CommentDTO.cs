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
    public partial class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostPostId { get; set; }
        [DataMember]
        public virtual PostDTO Post { get; set; }
    }

    public static class CommentMapper
    {
        public static CommentDTO GetModel(this Comment comment)
        {
            return new CommentDTO()
            {
                CommentId = comment.CommentId,
                Text = comment.Text,
                PostPostId = comment.PostPostId
            };
        }

        public static Comment GetData(this CommentDTO comment)
        {
            return new Comment()
            {
                CommentId = comment.CommentId,
                Text = comment.Text,
                PostPostId = comment.PostPostId
            };
        }
    }
}
