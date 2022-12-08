using Unity.Profiling.Editor;

using BestHTTP.Profiler.Network;

namespace BestHTTP.Editor.Profiler.Network
{
    [System.Serializable]
    [ProfilerModuleMetadata(MemoryStats.CategoryName)]
    public sealed class MemoryStatsProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters =
        {
            new(MemoryStats.BorrowedName, MemoryStats.Category),
            new(MemoryStats.PooledName, MemoryStats.Category),
            new(MemoryStats.ArrayAllocationsName, MemoryStats.Category)
        };

        public MemoryStatsProfilerModule() : base(k_Counters)
        {
        }
    }
}
