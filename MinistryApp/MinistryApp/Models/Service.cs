using System;
using System.Collections.Generic;
using System.Text;

namespace MinistryApp.Models
{
    public class Service
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public string ServiceImage { get; set; }
        public DateTime Date { get; set; }
        public int RequstNumber { get; set; }
        public string RequstName { get; set; }
        public int Status { get; set; }
    }
}
