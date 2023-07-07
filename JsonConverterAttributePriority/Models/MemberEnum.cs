using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JsonConverterAttributePriority.Models;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum MemberEnum
{
    [EnumMember(Value = "Value One")]
    ValueOne = 1,
    [EnumMember(Value = "Value Two")]
    ValueTwo = 2,
}
