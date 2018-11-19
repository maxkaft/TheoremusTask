using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stations.Controllers
{
    public class StationsContext : DbContext
    {
        public StationsContext (DbContextOptions<StationsContext > options) : base(options)
        {

        }
        
    }
}
