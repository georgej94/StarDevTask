using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using StarDev.Models;

namespace StarDev.Interfaces
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocations();
    }
}
