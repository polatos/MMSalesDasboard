using MMSalesBoard.Core.AppAbout;
using MMSalesBoard.DataAccess;
using MMSalesBoard.DataAccess.EntityFrameworkCore;

namespace MMSalesBoard.Core.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationContext _applicationContext;
        private IAboutRepository _appAbout;

        public RepositoryWrapper(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IAboutRepository AppAbout => _appAbout ?? (_appAbout = new AboutRepository(_applicationContext));
    }
}
