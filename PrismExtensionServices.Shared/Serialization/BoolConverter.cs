using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Serialization;
public class BoolConverter : JsonConverter<bool?>
{
    public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? val = null;

        try
        {
            val = reader.GetString();
        }
        catch (Exception)
        {
            val = reader.GetBoolean().ToString();
        }

        if (string.IsNullOrWhiteSpace(val)) return null;
        else
        {
            if (bool.TryParse(val, out bool value)) return value;
            else
            {
                val = val.ToLower();
                if (val == "true" || val == "1" || val == "t") return true;
                else if (val == "false" || val == "0" || val == "f") return false;
                else throw new Exception($"'{val}' is not a valid boolean value.");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
    {
        if (!value.HasValue)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteBooleanValue(value.Value);
        }
    }
}

