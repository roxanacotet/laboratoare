using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosManagerWCFService.Interfaces
{
[ServiceContract]
public interface InterfaceMyPhotoManager: InterfaceDetailController, InterfaceEventController, InterfacePeopleController, InterfacePhotoController { }
}
