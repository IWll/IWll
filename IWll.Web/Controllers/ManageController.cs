using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IWll.Web.Models;

namespace IWll.Web.Controllers
{
    public class ManageController : ApiController
    {
        ManagerModels[] managers = new ManagerModels[] 
        { 
            new ManagerModels { id = 1, name = "admin", password = "admin" }, 
            new ManagerModels { id = 2, name = "Yo-yo", password = "Toys" }, 
            new ManagerModels { id = 3, name = "Hammer", password = "Hardware" } 
        };

        public IEnumerable<ManagerModels> GetAllManagers()
        {
            return managers;
        }

        public bool PostLogin(string name, string password) {
            ManagerModels manager;
            return false;
        }
        public ManagerModels GetManagerById(int id)
        {
            var manager = managers.FirstOrDefault((p) => p.id == id);
            if (manager == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return manager;
        }

        public IEnumerable<ManagerModels> GetManagerByName(string name)
        {
            return managers.Where(
                (p) => string.Equals(p.name, name,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}
