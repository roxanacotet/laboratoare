using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ObjectWCF.DTOs;
using PostComment;
namespace ObjectWCF
{
   
    [ServiceContract]
    public interface IPost
    {
        [OperationContract]
        PostDTO GetPostById(int id);
        [OperationContract]
        PostDTO SubmitPost(Post post);
        [OperationContract]
        void UpdatePost(PostDTO newPost);
        [OperationContract]
        void DeletePost(int postId);
        [OperationContract]
        List<PostDTO> GetAllPosts();
    }
    [ServiceContract]
    public interface IComment
    {
        // Insert, Update, Delete Comment
        [OperationContract]
        CommentDTO GetCommentById(int id);
        [OperationContract]
        void UpdateComment(CommentDTO newComment);
      
    }
    [ServiceContract]
    public interface ILoadData
    {
        [OperationContract]
        List<PostDTO> GetAllPostsAndRelatedComments();
    }
    [ServiceContract]
    public interface IPostComment : IPost, IComment, ILoadData
    { }

}