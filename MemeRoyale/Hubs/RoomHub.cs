using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Hubs
{
    public class RoomHub : Hub
    {
        public RoomHub()
        {

        }

        public async Task JoinRoom(Guid roomId, int userId)
        {
            // Verify room exists

            // Retrieve or add the user to the database

            // Alert others in the room that a user joined
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
            await Clients.OthersInGroup(roomId.ToString()).SendAsync("OnUserJoin");
        }

        public async Task LeaveRoom(Guid roomId, int userId)
        {

        }

        // Only called by the person who created the room can start the game
        public async Task StartGame(Guid roomId, int userId)
        {

        }

        public async Task EndGame(Guid roomId)
        {

        }

        public async Task StartRound()
        {

        }

        public async Task EndRound()
        {

        }

        public async Task AddSubmission()
        {

        }

        public async Task Vote()
        {

        }


    }
}
