using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FlightSearchController
    {
        private readonly FlightService flightService = new FlightService();

        public async Task<IEnumerable<Itinerary>> Search([FromBody] SearchCriteria criteria)
        {
            await Task.Delay(500); // Gotta look busy...
            var result = flightService.ListSearchResult(criteria);
            return result;
        }

        private string RandomAirline()
            => SampleData.Airlines[new Random().Next(SampleData.Airlines.Length)];
    }
}
