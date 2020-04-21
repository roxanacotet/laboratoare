using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosManagerApi;
using MyPhotosManagerApi.Controllers;
using MyPhotosManagerDataAccess;
using MyPhotosManagerWCFService.Interfaces;
using MyPhotosManagerWCFService.Models;

namespace MyPhotosManagerWCFService
{
  public class MyPhotosManagerWCF: InterfaceMyPhotoManager
    {
       public int CreatePhoto(PhotoModel photo)
        {
            using (var service = new PhotoController())
            {
                return service.Create(photo.GetData());
            }
        }

        void InterfacePhotoController.DeletePhoto(int id)
        {
            using(var service = new PhotoController())
            {
                service.Delete(id);
            }
        }

        List<PhotoModel> InterfacePhotoController.GetPhotos()
        {
            using(var service = new PhotoController())
            {
                return service.GetPhotos().ToList().Select(a => a.GetModel()).ToList();
            }
        }

        List<PhotoModel> InterfacePhotoController.GetVideos()
        {
            using (var service = new PhotoController())
            {
                return service.GetVideos().ToList().Select(a => a.GetModel()).ToList();
            }
        }

        PhotoModel InterfacePhotoController.GetPhotoByID(int id)
        {
            using(var service = new PhotoController())
            {
                return service.GetPhotoById(id).GetModel();
            }
        }

        public void UpdatePhoto(PhotoModel photo)
        {
            using (var service = new PhotoController())
            {
                service.Update(photo.GetData());
            }
        }

        ICollection<PhotoModel> InterfacePhotoController.SearchPhotoByName(string name)
        {
            using(var service = new PhotoController())
            {
                return service.SearchByName(name).ToList().Select(a => a.GetModel()).ToList();
            }
        }

        ICollection<PhotoModel> InterfacePhotoController.SearchByLocation(string location)
        {
            using (var service = new PhotoController())
            {
                return service.SearchByLocation(location).ToList().Select(a => a.GetModel()).ToList();
            }
        }

        ICollection<PhotoModel> InterfacePhotoController.SearchByCreationDate(string date)
        {
            using (var service = new PhotoController())
            {
                return service.SearchByCreationDate(date).ToList().Select(a => a.GetModel()).ToList();
            }
        }



        public int CreatePeople(PeopleModel people)
        {
            using (var service = new PeopleController())
            {
                return service.Create(people.GetData());
            }
        }

        void InterfacePeopleController.DeletePeople(int id)
        {
            using (var service = new PeopleController())
            {
                service.Delete(id);
            }
        }

        ICollection<PeopleModel> InterfacePeopleController.GetPeoples()
        {
            using (var service = new PeopleController())
            {
                return service.GetPeoples().ToList().Select(a => a.GetModel()).ToList();
            }
        }

        PeopleModel InterfacePeopleController.GetPeopleByID(int id)
        {
            using (var service = new PeopleController())
            {
                return service.GetPeopleById(id).GetModel();
            }
        }

        PeopleModel InterfacePeopleController.GetPeopleByPhotoId(int id)
        {
            using (var service = new PeopleController())
            {
                return service.GetPeopleByPhotoId(id).GetModel();
            }
        }

        public void UpdatePeople(PeopleModel people)
        {
            using (var service = new PeopleController())
            {
                service.Update(people.GetData());
            }
        }

        ICollection<PeopleModel> InterfacePeopleController.SearchPeopleByName(string name)
        {
            using (var service = new PeopleController())
            {
                return service.SearchByName(name).ToList().Select(a => a.GetModel()).ToList();
            }
        }



        public int CreateEvent(EventModel events)
        {
            using (var service = new EventController())
            {
                return service.Create(events.GetData());
            }
        }

        void InterfaceEventController.DeleteEvent(int id)
        {
            using (var service = new EventController())
            {
                service.Delete(id);
            }
        }

        ICollection<EventModel> InterfaceEventController.GetEvents()
        {
            using (var service = new EventController())
            {
                return service.GetEvents().ToList().Select(a => a.GetModel()).ToList();
            }
        }

        EventModel InterfaceEventController.GetEventByID(int id)
        {
            using (var service = new EventController())
            {
                return service.GetEventById(id).GetModel();
            }
        }

        EventModel InterfaceEventController.GetEventByPhotoId(int id)
        {
            using (var service = new EventController())
            {
                return service.GetEventByPhotoId(id).GetModel();
            }
        }

       public void UpdateEvent(EventModel events)
        {
            using (var service = new EventController())
            {
                service.Update(events.GetData());
            }
        }

        ICollection<EventModel> InterfaceEventController.SearchEventByName(string name)
        {
            using (var service = new EventController())
            {
                return service.SearchByName(name).ToList().Select(a => a.GetModel()).ToList();
            }
        }

        public int CreateDetail(DetailModel detail)
        {
            using (var service = new DetailController())
            {
                return service.Create(detail.GetData());
            }
        }

        void InterfaceDetailController.DeleteDetail(int id)
        {
            using (var service = new DetailController())
            {
                service.Delete(id);
            }
        }

        ICollection<DetailModel> InterfaceDetailController.GetDetail()
        {
            using (var service = new DetailController())
            {
                return service.GetDetail().ToList().Select(a => a.GetModel()).ToList();
            }
        }

        DetailModel InterfaceDetailController.GetDetailByID(int id)
        {
            using (var service = new DetailController())
            {
                return service.GetDetailById(id).GetModel();
            }
        }

        DetailModel InterfaceDetailController.GetDetailsByPhotoId(int id)
        {
            using (var service = new DetailController())
            {
                return service.GetDetailByPhotoId(id).GetModel();
            }
        }

        public void UpdateDetail(DetailModel detail)
        {
            using (var service = new DetailController())
            {
                service.Update(detail.GetData());
            }
        }

        ICollection<DetailModel> InterfaceDetailController.SearchByKey(string key)
        {
            using (var service = new DetailController())
            {
                return service.SearchByKey(key).ToList().Select(a => a.GetModel()).ToList();
            }
        }

        ICollection<DetailModel> InterfaceDetailController.SearchByValue(string value)
        {
            using (var service = new DetailController())
            {
                return service.SearchByValue(value).ToList().Select(a => a.GetModel()).ToList();
            }
        }
    }
}
