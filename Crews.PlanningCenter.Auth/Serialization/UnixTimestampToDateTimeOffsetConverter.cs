using System.Text.Json;
using System.Text.Json.Serialization;

namespace Crews.PlanningCenter.Auth.Serialization;
internal class UnixTimestampToDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) 
        => DateTimeOffset.FromUnixTimeSeconds(reader.GetInt32());

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) 
        => writer.WriteNumberValue(value.ToUnixTimeSeconds());
}
