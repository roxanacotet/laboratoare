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

namespace MyPhotosManagerWCFService
{
  public class MyPhotosManagerWCF: InterfaceMyPhotoManager
    {
       public int Create(Photos photo)
        {
            using (var service = new PhotoController())
            {
                return service.Create(photo);
            }
        }

        void InterfacePhotoController.Delete(int id)
        {
            using(var service = new PhotoController())
            {
                service.Delete(id);
            }
        }

    }
}
