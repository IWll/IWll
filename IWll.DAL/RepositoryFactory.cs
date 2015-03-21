using IWll.IDAL;

namespace IWll.DAL
{
    public static class RepositoryFactory
    {
        /// <summary>
        /// 用户仓储
        /// </summary>
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }

        public static InterfaceManagerRepository ManagerRepository { get { return new ManagerRepository(); } }
    }
}
