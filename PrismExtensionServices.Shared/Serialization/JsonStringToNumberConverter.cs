using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Serialization
{
    public class JsonStringToNumberConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? sVal = null;
            try
            {
                sVal = reader.GetString();
            }
            catch
            {
                try
                {
                    sVal = reader.GetDecimal().ToString();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return sVal;
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            if (string.IsNullOrEmpty(value))
            {
                writer.WriteNullValue();
            }
            else
            {
                if (decimal.TryParse(value, out var val))
                {
                    writer.WriteNumberValue(val);
                }
                else
                {
                    throw new Exception($"'{value}' is not a valid number.");
                }
            }
        }
    }
}
