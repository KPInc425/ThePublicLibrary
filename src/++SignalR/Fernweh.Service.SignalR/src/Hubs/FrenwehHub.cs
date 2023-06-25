namespace Frenweh.Service.SignalR.Hubs;
public class FrenwehHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
