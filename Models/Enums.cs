using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.NETCore7.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Enums
    {
        Active = 1,
        InActive = 0
    }
}