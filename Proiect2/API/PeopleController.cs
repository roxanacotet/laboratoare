using MyPhotosManagerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPhotosManagerApi.Controllers
{
    public class PeopleController : ApiController, IDisposable
    {
        readonly MyPhotosManagerModelContainer db = new MyPhotosManagerModelContainer();
        public int Create(Peoples people)
        {
            if (people == null)
            {
                throw new ArgumentNullException();
            }
            db.Peoples.Add(people);
            db.SaveChanges();
            return people.Id;
        }

        public void Delete(int peopleId)
        {
            var people = db.Peoples.FirstOrDefault(x => x.Id == peopleId);
            if (people == null)
            {
                throw new ArgumentNullException();
            }
            db.Peoples.Remove(people);
            db.SaveChanges();
        }

        public ICollection<Peoples> GetPeoples()
        {
            return db.Peoples.ToList();
        }

        public Peoples GetPeopleById(int peopleId)
        {
            return db.Peoples.FirstOrDefault(x => x.Id == peopleId);
        }

        public Peoples GetPeopleByPhotoId(int photoId)
        {
            return db.Peoples.FirstOrDefault(x => x.IdPhoto == photoId);
        }

        public void Update(Peoples people)
        {
            if (people == null)
            {
                throw new ArgumentNullException();
            }
            var result = db.Peoples.FirstOrDefault(x => x.Id == people.Id);
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            result.Name = people.Name;
            db.SaveChanges();
        }

        public ICollection<Peoples> SearchByName(string name)
        {
            return db.Peoples.Where(x => x.Name.Contains(name)).ToList();
        }

        public new void Dispose()
        {
            db?.Dispose();
        }
    }
}
