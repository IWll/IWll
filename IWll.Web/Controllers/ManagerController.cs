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
        //public IEnumerable<Manager> GetAllProducts()
        //{
        //    return products;
        //}
        //public IEnumerable<Manager> GetAllManagers()
        //{

        //    return managers;
        //}
        //public bool GetManager()
        //{
        //    return true;
        //}

        public bool GetManagerLogin(Manager manager)
        {
            return managerService.Login(manager.ManagerName, manager.ManagerPassword);
        }
        
    }
}
