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
    public interface InterfaceEventController
    {
        [OperationContract]
        int Create(Events events);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        ICollection<Events> GetEvents();

        [OperationContract]
        Events GetEventByID(int id);

        [OperationContract]
        Events GetEvntByPhotoId(int id);

        [OperationContract]
        void Update(Events events);

        [OperationContract]
        ICollection<Events> SearchByName(string name);

        [OperationContract]
        void Dispose();
    }
}
