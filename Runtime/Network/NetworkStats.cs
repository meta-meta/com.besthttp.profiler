using Unity.Profiling;

namespace BestHTTP.Profiler.Network
{
    public sealed class NetworkStats
    {
        public static readonly ProfilerCategory Category = new ProfilerCategory("Best HTTP/2 - Network", ProfilerCategoryColor.Scripts);

        public const string SentSinceLastFrameName = "Sent";
        public static readonly ProfilerCounterValue<long> SentSinceLastFrame = new(Category, SentSinceLastFrameName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string SentTotalName = "Sent Total";
        public static readonly ProfilerCounterValue<long> SentTotal = new(Category, SentTotalName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string ReceivedSinceLastFrameName = "Received";
        public static readonly ProfilerCounterValue<long> ReceivedSinceLastFrame = new(Category, ReceivedSinceLastFrameName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string ReceivedTotalName = "Received Total";
        public static readonly ProfilerCounterValue<long> ReceivedTotal = new(Category, ReceivedTotalName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string OpenConnectionsName = "Open Connections";
        public static readonly ProfilerCounterValue<int> OpenConnectionsCounter = new(Category, OpenConnectionsName, ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame);

        public const string TotalConnectionsName = "Total Connections";
        public static readonly ProfilerCounterValue<int> TotalConnectionsCounter = new(Category, TotalConnectionsName, ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame);
    }
}
