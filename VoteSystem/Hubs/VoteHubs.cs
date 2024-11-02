using Microsoft.AspNetCore.SignalR;

namespace VoteSystem.Hubs
{
    public class VoteHubs : Hub
    {
        public async Task SendVote(string username, int vote)
        {
            await Clients.All.SendAsync("ReceiveMessage", username, vote);
        }
    }
}
