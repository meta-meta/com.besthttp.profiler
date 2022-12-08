using Unity.Profiling.Editor;

using BestHTTP.Profiler.Network;

namespace BestHTTP.Editor.Profiler.Network
{
    [System.Serializable]
    [ProfilerModuleMetadata(NetworkStats.CategoryName)]
    public sealed class NetworkStatsProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters =
        {
            new(NetworkStats.SentSinceLastFrameName, NetworkStats.Category),
            new(NetworkStats.SentTotalName, NetworkStats.Category),
            new(NetworkStats.ReceivedSinceLastFrameName, NetworkStats.Category),
            new(NetworkStats.ReceivedTotalName, NetworkStats.Category),
            new(NetworkStats.OpenConnectionsName, NetworkStats.Category),
            new(NetworkStats.TotalConnectionsName, NetworkStats.Category),
        };

        public NetworkStatsProfilerModule() : base(k_Counters)
        {
        }
    }
}
