using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stations.Services
{
    public interface IStationsService
    {
        IEnumerable<Station> GetStations();
    }
}
