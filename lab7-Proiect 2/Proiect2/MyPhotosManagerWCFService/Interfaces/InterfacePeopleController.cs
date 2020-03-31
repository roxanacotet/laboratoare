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
    public interface InterfacePeopleController
    {
        [OperationContract]
        int Create(Peoples people);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        ICollection<Peoples> GetPeoples();

        [OperationContract]
        Peoples GetPeoplelByID(int id);

        [OperationContract]
        Peoples GetPeopleByPhotoId(int id);

        [OperationContract]
        void Update(Peoples people);

        [OperationContract]
        ICollection<Peoples> SearchByName(string name);

        [OperationContract]
        void Dispose();
    }
}
