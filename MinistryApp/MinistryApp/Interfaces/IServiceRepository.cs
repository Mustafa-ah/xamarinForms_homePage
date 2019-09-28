using MinistryApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinistryApp.Interfaces
{
    public interface IServiceRepository
    {
        List<Service> GetPopularServices();
        List<Service> GetAllServices();
        Service GetActiveService();
    }
}
