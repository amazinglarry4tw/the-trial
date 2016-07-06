using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTrial_Alpha
{
    public class RoomManager
    {
        public List<Room> gameRooms;

        public RoomManager()
        {
            this.gameRooms = new List<Room>();
        }

        public Guid CreateRoom(string name, string description)
        {
            Room temp = new Room();
            temp.name = name;
            temp.description = description;
            temp.id = Guid.NewGuid();

            // Add to the collection
            gameRooms.Add(temp);

            // Return the new RoomID
            return temp.id;
        }

        public Room GetRoom(Guid room_id)
        {
            Room temp = new Room();

            if (RoomsExist())
            {
                foreach (var item in this.gameRooms)
                {
                    if (item.id == room_id)
                        temp = item;
                }
            }

            return temp;
        }

        public string GetRoomName(Guid room_id)
        {
            string temp = string.Empty;

            if (RoomsExist())
            {
                foreach (var item in this.gameRooms)
                {
                    if (item.id == room_id)
                        temp = item.name;
                }
            }
            return temp;
        }

        public string GetRoomDescription(Guid room_id)
        {
            string temp = string.Empty;

            if (RoomsExist())
            {
                foreach (var item in this.gameRooms)
                {
                    if (item.id == room_id)
                        temp = item.description;
                }
            }
            return temp;
        }

        public void AddPortal(Guid room_id, Portal portal)
        {
            if (GetRoom(room_id).id != Guid.Empty)
                GetRoom(room_id).portals.Add(portal);
        }

        public Portal GetPortal(Guid room_id, string name)
        {
            Portal temp = new Portal();
            temp.message = "You cannot go there.";

            Room rm = GetRoom(room_id);

            if (rm.portals.Count > 0)
            {
                for (int i = 0; i < rm.portals.Count; i++)
                {
                    if (rm.portals[i].name == name)
                        temp = rm.portals[i];
                }
            }

            return temp;
        }

        public bool PortalExists(Guid room_id, string name)
        {
            bool temp = false;
            Room rm = GetRoom(room_id);

            if (rm.portals.Count > 0)
            {
                for (int i = 0; i < rm.portals.Count; i++)
                {
                    if (rm.portals[i].name == name)
                        temp = true;
                }
            }
            return temp;
        }

        public List<Portal> GetPortals(Guid room_id)
        {
            List<Portal> temp = new List<Portal>();
            if (GetRoom(room_id).id != Guid.Empty)
                temp = GetRoom(room_id).portals;
            return temp;
        }

        #region Helper Methods

        public bool RoomsExist()
        {
            bool exist = false;

            if (gameRooms.Count > 0)
                exist = true;

            return exist;
        }

        #endregion
    }
}
