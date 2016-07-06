using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTrial_Alpha
{
    public class Player
    {
        public Guid location_id;

        public Player()
        {
            location_id = Guid.NewGuid();
        }

        public void UpdateLocation(Guid room_id)
        {
            this.location_id = room_id;
        }
    }
}
