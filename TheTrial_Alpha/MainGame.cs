using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTrial_Alpha
{
    class MainGame
    {
        Display _display = new Display();
        RoomManager _roomManager = new RoomManager();
        Player _player = new Player();

        TextBox textbox_game = new TextBox();
        DateTime timer = new DateTime();
        

        public MainGame(TextBox game)
        {
            this.textbox_game = game;
            timer = DateTime.Now;

            GenerateGameRooms();
            _player.UpdateLocation(_roomManager.gameRooms[0].id);   // Fix me later
            RenderCurrentRoom();
        }

        public void Update()
        {
            if (TimeElapsed())
            {
                // Update gameplay.
            }
        }

        public void HandleUserInput(string input)
        {
            Render(">" + input);

            string[] words = input.Split(' ');

            if (words.Length > 1)
            {
                if (words[0] == "go" && _roomManager.PortalExists(_player.location_id, words[1]))
                {
                    // Need to match the Portal
                    Portal temp = _roomManager.GetPortal(_player.location_id, words[1]);
                    Render(temp.message);
                    _player.UpdateLocation(temp.connection.destination_id);
                    RenderCurrentRoom();
                }
            }
        }

        public void GenerateGameRooms()
        {
            // Create Rooms
            string name = "Den";
            string desc = "Closed off and cold, the den lacks any kind of comfort one would normally expect.  Decrepit furniture lines the floor; the only remaining structure in tact is a shelf on the wall.";
            Guid rm1 = _roomManager.CreateRoom(name, desc);

            name = "Darkened Room";
            desc = "The room is nearly pitch dark, save for a dim light eminating from the cracks of a large wooden door at the far side of the room.  Tattered and rotting books fill the corners of the room.";
            Guid rm2 = _roomManager.CreateRoom(name, desc);

            // Add Portals
            Portal pt1 = new Portal();
            pt1.name = "opening";
            pt1.message = "You go through the opening.";
            pt1.connection.host_id = rm2;
            pt1.connection.destination_id = rm1;

            Portal pt2 = new Portal();
            pt2.name = "opening";
            pt2.message = "You go back through the opening.";
            pt2.connection.host_id = rm1;
            pt2.connection.destination_id = rm2;

            _roomManager.AddPortal(rm2, pt1);
            _roomManager.AddPortal(rm1, pt2);
        }

        #region Helper Methods

        public void Render(string text)
        {
            _display.RenderText(text, textbox_game);
        }

        public void RenderCurrentRoom()
        {
            Render(System.String.Format("[{0}]", _roomManager.GetRoomName(_player.location_id)));
            Render(_roomManager.GetRoomDescription(_player.location_id));
        }

        private bool TimeElapsed()
        {
            bool update = false;
            TimeSpan elapsed = DateTime.Now - timer;
            if (elapsed.TotalSeconds > 1)
            {
                update = true;
                UpdateTimer();
            }
            return update;
        }

        private void UpdateTimer()
        {
            timer = DateTime.Now;
        }

        #endregion
    }
}
