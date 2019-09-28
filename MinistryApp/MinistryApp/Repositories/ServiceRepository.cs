using MinistryApp.Interfaces;
using MinistryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinistryApp.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private List<Service> services = new List<Service>()
            {
                new Service{Name = "General Education" , RequstNumber= 38432, Status =1, RequstName ="Perfect for guests who’re looking for that little bit of extra luxury", Date = DateTime.Now, ServiceImage = "ic_school.jpg", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "Higher Education" , ServiceImage = "ic_bus.jpg", Details = "Besides sanitary facilities our Comfotels contain two boxspring beds, two chairs and a table, a heater in the bathroom, "},
                new Service{Name = "Certificates" , ServiceImage = "ic_grad.jpg", Details = "The Comfotel is the first foldable hotelroom in the world. It can be set-up within minutes by hand. The rooms "},
                new Service{Name = "service" , ServiceImage = "ic_school.jpg", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "service" , ServiceImage = "ic_bus.jpg", Details = "Surprise your guests with a unique glamping experience! The modern and colourful foldable Comfotels are equipped with a shower, toilet and sink and provided with all comfort. Perfect for guests who’re looking for that little bit of extra luxury and privacy. Or even crew that needs to stay on site for a longer period."},
                  new Service{Name = "service" , ServiceImage = "", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "service" , ServiceImage = "", Details = "Besides sanitary facilities our Comfotels contain two boxspring beds, two chairs and a table, a heater in the bathroom, storage space and electricity. They are rented with made beds and towels. No need to bring your own! So your guests or crew can relax as soon as they open the door"},
                new Service{Name = "service" , ServiceImage = "", Details = "The Comfotel is the first foldable hotelroom in the world. It can be set-up within minutes by hand. The rooms are equipped with an easy supply and drainage connection. Because of the foldability we managed to get 8 Comfotels on one transport. This means a huge saving on cost of transportation"},
                new Service{Name = "service" , ServiceImage = "", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "service" , ServiceImage = "", Details = "Surprise your guests with a unique glamping experience! The modern and colourful foldable Comfotels are equipped with a shower, toilet and sink and provided with all comfort. Perfect for guests who’re looking for that little bit of extra luxury and privacy. Or even crew that needs to stay on site for a longer period."},
                  new Service{Name = "service" , ServiceImage = "", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "service" , ServiceImage = "", Details = "Besides sanitary facilities our Comfotels contain two boxspring beds, two chairs and a table, a heater in the bathroom, storage space and electricity. They are rented with made beds and towels. No need to bring your own! So your guests or crew can relax as soon as they open the door"},
                new Service{Name = "service" , ServiceImage = "", Details = "The Comfotel is the first foldable hotelroom in the world. It can be set-up within minutes by hand. The rooms are equipped with an easy supply and drainage connection. Because of the foldability we managed to get 8 Comfotels on one transport. This means a huge saving on cost of transportation"},
                new Service{Name = "service" , ServiceImage = "", Details = "The page you requested could not be found. Try refining your search, or use the navigation above to locate the post."},
                new Service{Name = "service" , ServiceImage = "", Details = "Surprise your guests with a unique glamping experience! The modern and colourful foldable Comfotels are equipped with a shower, toilet and sink and provided with all comfort. Perfect for guests who’re looking for that little bit of extra luxury and privacy. Or even crew that needs to stay on site for a longer period."}
            };

        public Service GetActiveService()
        {
            return services.FirstOrDefault();
        }

        public List<Service> GetAllServices()
        {
            return services;
        }

        public List<Service> GetPopularServices()
        {
            return services.Take(3).ToList();
        }
    }
}
