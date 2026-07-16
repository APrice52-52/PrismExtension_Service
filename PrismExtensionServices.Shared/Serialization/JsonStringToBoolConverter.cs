using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Serialization
{
    public class JsonStringToBoolConverter : JsonConverter<string?>
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
                    sVal = reader.GetBoolean().ToString();
                }
                catch
                {
                    try
                    {
                        sVal = reader.GetInt32().ToString();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return sVal;
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            if (string.IsNullOrWhiteSpace(value)) 
                writer.WriteNullValue();
            else
            {
                bool? val = value.ToBoolean();
                if (val != null)
                    writer.WriteBooleanValue(val.Value);
                else
                    writer.WriteNullValue();
            }
        }
    }
}
