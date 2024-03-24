using System.Text.Json.Serialization;
using System.Text.Json;

namespace TipMexico.DigitalYard.WebAPI.Configuration
{
    public class ConfigureJsonStringConvert : JsonConverter<string?>

    {

        public override string? Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            return reader.GetString().Trim();
        }


        public override void Write(

            Utf8JsonWriter writer,
            string? value,
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
