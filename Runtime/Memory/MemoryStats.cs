using Unity.Profiling;

namespace BestHTTP.Profiler.Network
{
    public sealed class MemoryStats
    {
        public const string CategoryName = "Best HTTP/2 - Memory";

        public static readonly ProfilerCategory Category = new ProfilerCategory(CategoryName, ProfilerCategoryColor.Scripts);

        public const string BorrowedName = "Borrowed";
        public static readonly ProfilerCounterValue<long> Borrowed = new ProfilerCounterValue<long>(Category, BorrowedName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string PooledName = "Pooled";
        public static readonly ProfilerCounterValue<long> Pooled = new ProfilerCounterValue<long>(Category, PooledName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string ArrayAllocationsName = "Array Allocations";
        public static readonly ProfilerCounterValue<long> ArrayAllocations = new ProfilerCounterValue<long>(Category, ArrayAllocationsName, ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);
    }
}
