using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Service
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
