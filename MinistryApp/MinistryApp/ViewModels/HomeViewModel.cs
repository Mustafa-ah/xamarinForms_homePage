using MinistryApp.Extentions;
using MinistryApp.Interfaces;
using MinistryApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinistryApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IServiceRepository serviceRepository;

        private ObservableCollection<Service> _popularServices;

        public ObservableCollection<Service> PopularServices
        {
            get { return _popularServices; }
            set { _popularServices = value; OnPropertyChanged(); }
        }


        public HomeViewModel(IServiceRepository _serviceRepository)
        {
            serviceRepository = _serviceRepository;

            PopularServices = serviceRepository.GetPopularServices().ToObservableCollection();
        }
    }
}
