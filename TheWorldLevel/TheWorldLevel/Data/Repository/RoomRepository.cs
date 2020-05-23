using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorldLevel.Data.interfaces;
using TheWorldLevel.Models;

namespace TheWorldLevel.Data.Repository
{
    public class RoomRepository : IRooms
    {
        private readonly ApplicationDbContext _dbcontext;

        public RoomRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<Room> Rooms => _dbcontext.Room.Include(r => r.Image);

        public Room GetRoom(int roomId) => _dbcontext.Room.FirstOrDefault(r => r.Id == roomId);
    }
}
