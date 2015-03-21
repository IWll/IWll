using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IWll.Models;
using IWll.IBLL;
using IWll.BLL;

namespace IWll.Web.Controllers
{
    public class ManagerController : ApiController
    {
        private InterfaceManagerService managerService;
        public ManagerController() { managerService = new ManagerService(); }

        public bool GetManagerLogin(string name, string password)
        {
            return managerService.Login(name, password);
        }

        public bool PostLogin(Manager manager)
        {
            return managerService.Login(manager.name, manager.password);
        }
        
    }
}
