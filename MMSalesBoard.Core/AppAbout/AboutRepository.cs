using System;
using System.Collections.Generic;
using System.Text;
using MMSalesBoard.Core.GenericRepo;
using MMSalesBoard.DataAccess.EntityFrameworkCore;

namespace MMSalesBoard.Core.AppAbout
{
    public class AboutRepository : AppRepository<Models.AppAbout>, IAboutRepository
    {
        public AboutRepository(ApplicationContext applicationContext) : base(applicationContext)
        {

        }
    }
}
