
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using Services.Classes;

namespace Notify.Hubs
{
    public class DmsHub : Hub
    {
        public void GetLabels()
        {
            var service = new LabelService();
            var labels= service.GetAllLabels();
            var context = Context.ConnectionId;
            var data = JsonConvert.SerializeObject(labels);
            Clients.All.setLables(data);
        }
    }
}