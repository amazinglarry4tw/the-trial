using System;
using System.Collections.Generic;

namespace TheTrial_Alpha
{
    public class Room
    {
        public string name;
        public string description;
        public Guid id;
        public List<Portal> portals;

        public Room()
        {
            this.name = string.Empty;
            this.description = string.Empty;
            this.id = Guid.Empty;
            this.portals = new List<Portal>();
        }
    }
}
