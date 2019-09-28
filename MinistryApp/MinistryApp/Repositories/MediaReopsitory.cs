using MinistryApp.Interfaces;
using MinistryApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinistryApp.Repositories
{
    public class MediaReopsitory : IMediaReopsitory
    {
        public List<Media> GetTopMedai()
        {
            return new List<Media>()
            {
                new Media(){Image="media1.jpg", Date= DateTime.Now, Description="This means a huge saving on cost of transportation"},
                new Media(){Image="media2.jpg", Date= DateTime.Now, Description="This means a huge saving on cost of transportation"},
                new Media(){Image="media3.jpg", Date= DateTime.Now, Description="This means a huge saving on cost of transportation"}
            };
        }
    }
}
