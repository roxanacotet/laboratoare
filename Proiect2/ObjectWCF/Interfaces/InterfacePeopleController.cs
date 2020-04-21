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
    public interface InterfacePeopleController
    {
        [OperationContract]
        int CreatePeople(PeopleModel people);

        [OperationContract]
        void DeletePeople(int id);

        [OperationContract]
        ICollection<PeopleModel> GetPeoples();

        [OperationContract]
        PeopleModel GetPeopleByID(int id);

        [OperationContract]
        PeopleModel GetPeopleByPhotoId(int id);

        [OperationContract]
        void UpdatePeople(PeopleModel people);

        [OperationContract]
        ICollection<PeopleModel> SearchPeopleByName(string name);
    }
}
