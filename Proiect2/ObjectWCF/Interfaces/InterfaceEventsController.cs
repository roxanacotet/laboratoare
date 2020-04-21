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
    public interface InterfaceEventController
    {
        [OperationContract]
        int CreateEvent(EventModel events);

        [OperationContract]
        void DeleteEvent(int id);

        [OperationContract]
        ICollection<EventModel> GetEvents();

        [OperationContract]
        EventModel GetEventByID(int id);

        [OperationContract]
        EventModel GetEventByPhotoId(int id);

        [OperationContract]
        void UpdateEvent(EventModel events);

        [OperationContract]
        ICollection<EventModel> SearchEventByName(string name);
    }
}
