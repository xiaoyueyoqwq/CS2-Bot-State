using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace BotState;

public sealed class IdleRepathSettings
{
    /// <summary>Seconds of low movement before the plugin requests a native repath.</summary>
    [JsonPropertyName("Seconds")]
    public float Seconds { get; set; } = 2.5f;
}

public sealed class ReactionDelaySettings
{
    /// <summary>Inclusive lower bound of the per-round assigned reaction, in milliseconds.</summary>
    [JsonPropertyName("MinMilliseconds")]
    public int MinMilliseconds { get; set; } = 180;

    /// <summary>Inclusive upper bound of the per-round assigned reaction, in milliseconds.</summary>
    [JsonPropertyName("MaxMilliseconds")]
    public int MaxMilliseconds { get; set; } = 300;

    /// <summary>
    /// Extra per-shot jitter as a percent of the assigned value.
    /// 5 with an assigned 200ms waits 190-210ms.
    /// </summary>
    [JsonPropertyName("JitterPercent")]
    public float JitterPercent { get; set; } = 5f;
}

public sealed class BotStateConfig : BasePluginConfig
{
    [JsonPropertyName("ConfigVersion")]
    public override int Version { get; set; } = 2;

    /// <summary>
    /// When false, preserve the native five-second idle-repath threshold.
    /// When true, use IdleRepath.Seconds.
    /// </summary>
    [JsonPropertyName("EnableCustomIdleRepath")]
    public bool EnableCustomIdleRepath { get; set; } = false;

    [JsonPropertyName("IdleRepath")]
    public IdleRepathSettings IdleRepath { get; set; } = new();

    /// <summary>
    /// When true, each bot gets a unique per-round reaction delay applied
    /// to the first shot after gaining visibility.
    /// </summary>
    [JsonPropertyName("EnableReactionDelay")]
    public bool EnableReactionDelay { get; set; } = true;

    [JsonPropertyName("ReactionDelay")]
    public ReactionDelaySettings ReactionDelay { get; set; } = new();
}
