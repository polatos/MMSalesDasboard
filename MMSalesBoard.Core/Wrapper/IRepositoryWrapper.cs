using System;
using System.Collections.Generic;
using System.Text;
using MMSalesBoard.Core.AppAbout;

namespace MMSalesBoard.Core.Wrapper
{
    public interface IRepositoryWrapper
    {
        IAboutRepository AppAbout { get; }
    }
}
