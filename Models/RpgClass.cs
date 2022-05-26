using System.Text.Json.Serialization;

namespace dotnet_rpg_5.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Wizard,
        Cleric
    }
}