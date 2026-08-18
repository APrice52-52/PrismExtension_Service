using System.ComponentModel;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using PpitConfig;

namespace CycleCount.Configuration;

public class CycleCountConfig : ConfigBase
{
    public override string ApplicationName => "PrismCycleCount";

    [Browsable(false)]

    public string DbServer { get; set; } = "localhost";
    public int DbPort { get; set; } = 3306;

    public string? DbUsername { get; set; } = "reportuser";

    private string? _dbPassword = "report";

    public long DefaultStoreSid { get; set; } = 719839606000135005;
    public int ServicePort { get; set; } = 5103;
    public List<long> ExemptStores { get; set; } = [];

    [JsonConverter(typeof(PpitConfig.EncryptedStringConverter))]
    public string? DbPassword { get => _dbPassword; set => _dbPassword = value; }

    public int LogExpiryDays { get; set; } = 400;

    public static CycleCountConfig Load()
    {
        return LoadInstance<CycleCountConfig>();
    }
}
