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
   public interface InterfaceDetailController
    {
        [OperationContract]
        int Create(Details detail);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        ICollection<Details> GetDetail();

        [OperationContract]
        Details GetDetailByID(int id);

        [OperationContract]
        Details GetDetailsByPhotoId(int id);

        [OperationContract]
        void Update(Details detail);

        [OperationContract]
        ICollection<Details> SearchByKey(string key);

        [OperationContract]
        ICollection<Details> SearchByValue(string value);

        [OperationContract]
        void Dispose();
    }
}
