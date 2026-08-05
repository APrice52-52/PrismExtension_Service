using System;
using System.Collections.Generic;
using System.Text;
using PpitConfig;

namespace SoCancelFeePlugin;

internal class SoCancelFeePluginConfig : ConfigBase
{
    public override string ApplicationName => "SoCancelFeePlugin";

    public decimal FeePercentage { get; set; } = 0;
    public bool FeeOnTotal { get; set; } = true;
    public int FeeType { get; set; } = 0;

    /// <summary>
    /// Optional dedicated log file name (no extension/path). When set, the host routes
    /// this plugin's log output to "{LogFileName}-.log" instead of the shared host log.
    /// </summary>
    public string? LogFileName { get; set; }
}
