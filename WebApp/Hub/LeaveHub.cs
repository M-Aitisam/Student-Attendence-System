using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hub
{
    public class LeaveHub : Microsoft.AspNetCore.SignalR.Hub
    {
        // You can send messages to all clients from here, using 'Clients'
        private readonly IHubContext<LeaveHub> _hubContext;

        // Constructor to inject the IHubContext
        public LeaveHub(IHubContext<LeaveHub> hubContext)
        {
            _hubContext = hubContext;
        }

        // A method to send a message to all clients (using the 'Clients' property of the injected IHubContext)
        public async Task SendLeaveUpdate(string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
