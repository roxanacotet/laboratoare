using MyPhotosManagerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPhotosManagerApi.Controllers
{
    public class EventController : ApiController, IDisposable
    {
        readonly MyPhotosManagerModelContainer db = new MyPhotosManagerModelContainer();
        public int Create(Events events)
        {
            if(events == null)
            {
                throw new ArgumentNullException();
            }
            db.Events.Add(events);
            db.SaveChanges();
            return events.Id;
        }

        public void Delete(int eventID)
        {
            var events = db.Events.FirstOrDefault(x => x.Id == eventID);
            if(events == null)
            {
                throw new ArgumentNullException();
            }
            db.Events.Remove(events);
            db.SaveChanges();
        }

        public ICollection<Events> GetEvents()
        {
            return db.Events.ToList();
        }

        public Events GetEventById(int eventId)
        {
            return db.Events.FirstOrDefault(x => x.Id == eventId);
        }

        public Events GetEventByPhotoId(int photoID)
        {
            return db.Events.FirstOrDefault(x => x.IdPhoto == photoID);
        }

        public void Update(Events events)
        {
            if (events == null)
            {
                throw new ArgumentNullException();
            }
            var result = db.Events.FirstOrDefault(x => x.Id == events.Id);
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            result.Name = events.Name;
            db.SaveChanges();
        }

        public ICollection<Events> SearchByName(string name)
        {
            return db.Events.Where(x => x.Name.Contains(name)).ToList();
        }

        public new void Dispose()
        {
            db?.Dispose();
        }
    }
}
