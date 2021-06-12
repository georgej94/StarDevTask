using System;
namespace StarDev.Models
{
    public class Location
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Geo Geo { get; set; }
        public bool HeadOffice { get; set; }
    }
}
