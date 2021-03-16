using System.Text.Json.Serialization;

namespace Horse.WebSocket.Models.Internal
{
    internal class PayloadFrame<TModel>
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("payload")]
        public TModel Payload { get; set; }
    }
}