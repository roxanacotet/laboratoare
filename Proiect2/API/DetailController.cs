using MyPhotosManagerDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPhotosManagerApi.Controllers
{
    public class DetailController : ApiController, IDisposable
    {
        readonly MyPhotosManagerModelContainer db = new MyPhotosManagerModelContainer();
        public int Create(Details detail)
        {
            if (detail == null)
            {
                throw new ArgumentNullException();
            }
            db.Details.Add(detail);
            db.SaveChanges();
            return detail.Id;
        }

        public void Delete(int detailId)
        {
            var detail = db.Details.FirstOrDefault(x => x.Id == detailId);
            if (detail == null)
            {
                throw new ArgumentNullException();
            }
            db.Details.Remove(detail);
            db.SaveChanges();
        }

        public ICollection<Details> GetDetail()
        {
            return db.Details.ToList();
        }

        public Details GetDetailById(int detailId)
        {
            return db.Details.FirstOrDefault(x => x.Id == detailId);
        }

        public Details GetDetailByPhotoId(int photoId)
        {
            return db.Details.FirstOrDefault(x => x.IdPhoto == photoId);
        }

        public void Update(Details detail)
        {
            if (detail == null)
            {
                throw new ArgumentNullException();
            }
            var result = db.Details.FirstOrDefault(x => x.Id == detail.Id);
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            result.DetailKey = detail.DetailKey;
            result.DetailValue = detail.DetailValue;
            db.SaveChanges();
        }

        public ICollection<Details> SearchByKey(string key)
        {
            return db.Details.Where(x => x.DetailKey.Contains(key)).ToList();
        }

        public ICollection<Details> SearchByValue(string value)
        {
            return db.Details.Where(x => x.DetailValue.Contains(value)).ToList();
        }

        public new void Dispose()
        {
            db?.Dispose();
        }
    }
}
