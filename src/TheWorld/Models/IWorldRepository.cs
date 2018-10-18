using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips ();
        IEnumerable<Trip> GetTripsByUsername (string username);
        Trip GetTripByName (string tripName);
        Trip GetUserTripByName (string tripName, string username);

        void AddTrip (Trip trip);
        void AddStop (string tripName, Stop newStop, string username);

        Task<bool> SaveChangesAsync ();
    }
}