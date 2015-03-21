using IWll.DAL;
using IWll.IBLL;
using IWll.Models;
using System.Linq;

namespace IWll.BLL
{
    public class ManagerService : BaseService<Manager>, InterfaceManagerService
    {
        public ManagerService() : base(RepositoryFactory.ManagerRepository) { }

        public bool Login(string name, string password)
        {
            return CurrentRepository.Exist(u => u.name == name && u.password == password);
        }

    }
}
