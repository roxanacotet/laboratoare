using MyPhotosManagerDataAccess;
using MyPhotosManagerWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosManagerWCFService.Interfaces
{
    [ServiceContract]
    public interface InterfacePhotoController
    {
        [OperationContract]
        int CreatePhoto(PhotoModel photo);

        [OperationContract]
        void DeletePhoto(int id);

        [OperationContract]
        List<PhotoModel> GetPhotos();

        [OperationContract]
        List<PhotoModel> GetVideos();

        [OperationContract]
        PhotoModel GetPhotoByID(int id);

        [OperationContract]
        void UpdatePhoto(PhotoModel photo);

        [OperationContract]
        ICollection<PhotoModel>SearchPhotoByName(string name);

        [OperationContract]
        ICollection<PhotoModel>SearchByLocation(string location);

        [OperationContract]
        ICollection<PhotoModel>SearchByCreationDate(string date);
    }
}
