using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stations.Services
{
    public class StationsService : IStationsService
    {
        private readonly StationsContext _context;

        public StationsService(StationsContext context)
        {
            _context = context;
        }

        public IEnumerable<Station> GetStations()
        {
            IEnumerable<Station> stations = new List<Station>();

            stations = this._context.Stations
                .Include(s => s.ExpectedLocation)
                 .Include(s => s.LatestLocation)
                .ToList();

            return stations;
        }
    }
}
