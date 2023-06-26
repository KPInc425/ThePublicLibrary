namespace Fernweh.Service.SignalR.Hubs;
public class FernwehHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
