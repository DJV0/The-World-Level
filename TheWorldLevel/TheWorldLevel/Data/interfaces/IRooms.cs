using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorldLevel.Models;

namespace TheWorldLevel.Data.interfaces
{
    interface IRooms
    {
        IEnumerable<Room> Rooms { get; }
        Room GetRoom(int carId);
    }
}
