using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyPhotosManagerDataAccess;

namespace MyPhotosManagerApi.Controllers
{
    public class PhotoController : ApiController, IDisposable
    {
        readonly MyPhotosManagerModelContainer db = new MyPhotosManagerModelContainer();
       public int Create(Photos photo)
        {
            if(photo == null)
            {
                throw new ArgumentNullException();
            }
            db.Photos.Add(photo);
            db.SaveChanges();
            return photo.Id;
        }

        public void Delete(int photoId)
        {
            var photo = db.Photos.FirstOrDefault(x => (x.Id == photoId && x.IsDeleted == false));
            if (photo == null)
            {
                throw new ArgumentNullException();
            }
            photo.IsDeleted = true;
            db.SaveChanges();
        }

        public ICollection<Photos> GetPhotos()
        {
            return db.Photos.Where(x=>x.IsVideo == false).ToList();
        }

        public ICollection<Photos> GetVideos()
        {
            return db.Photos.Where(x => x.IsVideo == true).ToList();
        }

        public Photos GetPhotoById(int photoId)
        {
            return db.Photos.FirstOrDefault(x => x.Id == photoId);
        }

        public void Update(Photos photo)
        {
            if(photo == null)
            {
                throw new ArgumentNullException();
            }
            var image = db.Photos.FirstOrDefault(x => x.Id == photo.Id);
            if(image == null)
            {
                throw new ArgumentNullException();
            }
            image.Name = photo.Name;
            image.Location = photo.Location;
            image.Event = photo.Event;
            image.Peoples = photo.Peoples;
            image.Details = photo.Details;
            db.SaveChanges();
        }

        public ICollection<Photos> SearchByName(string name)
        {
            return db.Photos.Where(x => x.Name.Contains(name)).ToList();
        }

        public ICollection<Photos> SearchByLocation(string location)
        {
            return db.Photos.Where(x => x.Location.Contains(location)).ToList();
        }

        public ICollection<Photos> SearchByCreationDate(string date)
        {
            return db.Photos.Where(x => x.CreationDate.Contains(date)).ToList();
        }

        public new void Dispose()
        {
            db?.Dispose();
        }
    }
}
