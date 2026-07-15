using System.Text.Json.Serialization;

namespace SoCancelFeePlugin;

public class CancellationResponse
{
    public long SoSid { get; set; }
    public long CancellationDocSid { get; set; }
    public decimal FeeAmount { get; set; } = 0;
    public bool Success { get; set; } = false;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Message { get; set; }
}