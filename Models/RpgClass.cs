using System.Text.Json.Serialization;

namespace dotnet_core_notes.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Wizard,
        Cleric
    }
}