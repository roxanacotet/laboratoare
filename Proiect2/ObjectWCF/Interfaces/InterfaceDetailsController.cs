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
   public interface InterfaceDetailController
    {
        [OperationContract]
        int CreateDetail(DetailModel detail);

        [OperationContract]
        void DeleteDetail(int id);

        [OperationContract]
        ICollection<DetailModel> GetDetail();

        [OperationContract]
        DetailModel GetDetailByID(int id);

        [OperationContract]
        DetailModel GetDetailsByPhotoId(int id);

        [OperationContract]
        void UpdateDetail(DetailModel detail);

        [OperationContract]
        ICollection<DetailModel> SearchByKey(string key);

        [OperationContract]
        ICollection<DetailModel> SearchByValue(string value);
    }
}
