using System.Runtime.Serialization;

namespace JsonConverterAttributePriority.Models;

public enum MemberEnum
{
    [EnumMember(Value = "Value One")]
    ValueOne = 1,
    [EnumMember(Value = "Value Two")]
    ValueTwo = 2,
}
