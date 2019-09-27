using MinistryApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinistryApp.Interfaces
{
    public interface IServiceRepository
    {
        List<Service> GetPopularServices();
    }
}
