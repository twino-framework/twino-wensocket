using System;
using System.Threading.Tasks;
using Sample.ModelServer.Models;
using Twino.Protocols.WebSocket;
using Twino.WebSocket.Models;

namespace Sample.ModelServer.Handlers
{
    public class ModelAHandler : IWebSocketMessageHandler<ModelA>
    {
        public Task Handle(ModelA model, WebSocketMessage message, ITwinoWebSocket client)
        {
            Console.WriteLine("Model A received: " + model.Value);
            return Task.CompletedTask;
        }

        public async Task OnError(Exception exception, ModelA model, WebSocketMessage message, ITwinoWebSocket client)
        {
            throw new NotImplementedException();
        }
    }
}