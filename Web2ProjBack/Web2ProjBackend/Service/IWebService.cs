using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web2ProjBackend.Models;

namespace web2projMig2.Service
{
    public interface IWebService
    {
        bool addEntity(object entity);
        List<object> getEntities(TipEntiteta tip);
        bool updateEntity(object entity);
        bool deleteEntity(object entity);
        object getEntity(TipEntiteta tip, string id);
    }
}
