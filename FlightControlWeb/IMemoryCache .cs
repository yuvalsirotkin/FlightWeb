using FlightControlWeb.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb
{
    public interface IMemoryCache : IDisposable
    {
        //bool TryGetValue(object key, out object value);
        //ICacheEntry CreateEntry(object key);
        void Remove(object key);
        void AddFlight(Flight flight);
        void UpdateFlight(object key);
        List<Flight> GetAllFlight();
        Flight GetFlightById(object key);
    }

}
