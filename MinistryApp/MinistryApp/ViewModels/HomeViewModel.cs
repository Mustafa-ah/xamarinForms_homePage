using MinistryApp.Extentions;
using MinistryApp.Interfaces;
using MinistryApp.Models;
using MinistryApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinistryApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IServiceRepository serviceRepository;
        private readonly IMediaReopsitory mediaRepository;

        private ObservableCollection<Service> _popularServices;
        public ObservableCollection<Service> PopularServices
        {
            get { return _popularServices; }
            set { _popularServices = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Service> _allServices;
        public ObservableCollection<Service> AllServices
        {
            get { return _allServices; }
            set { _allServices = value; OnPropertyChanged(); }
        }

        private Service _ativeService;
        public Service ActiveService
        {
            get { return _ativeService; }
            set { _ativeService = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Media> _topMedia;
        public ObservableCollection<Media> TopMedia
        {
            get { return _topMedia; }
            set { _topMedia = value; OnPropertyChanged(); }
        }

        public HomeViewModel(IServiceRepository _serviceRepository, IMediaReopsitory _mediaRepository)
        {
            serviceRepository = _serviceRepository;
            mediaRepository = _mediaRepository;

            PopularServices = serviceRepository.GetPopularServices().ToObservableCollection();
            AllServices = serviceRepository.GetAllServices().ToObservableCollection();
            ActiveService = serviceRepository.GetActiveService();


            TopMedia = mediaRepository.GetTopMedai().ToObservableCollection();

        }
    }
}
