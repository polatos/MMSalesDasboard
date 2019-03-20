using MMSalesBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace MMSalesBoard.Core
{
    public interface IApplicationContext
    {
        DbSet<T> Set<T>() where T : BaseEntity;
        int SaveChanges();
        void Rollback();
    }
}
