using MyPhotosManagerDataAccess;
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
        int Create(Photos photo);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        ICollection<Photos> GetPhotos();

        [OperationContract]
        ICollection<Photos> GetVideos();

        [OperationContract]
        Photos GetPhotoByID(int id);

        [OperationContract]
        void Update(Photos photo);

        [OperationContract]
        ICollection<Photos> SearchByName(string name);

        [OperationContract]
        ICollection<Photos> SearchByLocation(string location);

        [OperationContract]
        ICollection<Photos> SearchByCreationDate(string date);

        [OperationContract]
        void Dispose();
    }
}
