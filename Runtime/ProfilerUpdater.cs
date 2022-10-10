using System;

using BestHTTP.Connections;
using BestHTTP.Extensions;
using BestHTTP.Profiler.Network;

namespace BestHTTP.Profiler
{
    [PlatformSupport.IL2CPP.Il2CppEagerStaticClassConstruction]
    public sealed class ProfilerUpdater : IHeartbeat
    {
        /// <summary>
        /// Static ctor
        /// </summary>
        static ProfilerUpdater() => _instance = new ProfilerUpdater();

        private static ProfilerUpdater _instance;
        private static bool _isAttached;

        private static long _lastNetworkBytesSent = 0;
        private static long _lastNetworkBytesReceived = 0;

        /// <summary>
        /// Call Attach() to start recording profiler values
        /// </summary>
        public static void Attach()
        {
            if (_isAttached)
                return;
            _isAttached = true;

            HTTPManager.Heartbeats.Subscribe(_instance);
        }

        /// <summary>
        /// Call Detach() to stop recording
        /// </summary>
        public static void Detach()
        {
            if (!_isAttached)
                return;
            _isAttached = false;

            HTTPManager.Heartbeats.Unsubscribe(_instance);
        }

        void IHeartbeat.OnHeartbeatUpdate(TimeSpan dif)
        {
            // Sent
            {
                long newNetworkBytesSent = BufferedReadNetworkStream.TotalNetworkBytesSent;
                var diff = newNetworkBytesSent - _lastNetworkBytesSent;
                _lastNetworkBytesSent = newNetworkBytesSent;

                NetworkStats.SentSinceLastFrame.Value = diff;
                NetworkStats.SentTotal.Value = newNetworkBytesSent;
            }            

            // Received
            {
                long newNetworkBytesReceived = BufferedReadNetworkStream.TotalNetworkBytesReceived;
                var diff = newNetworkBytesReceived - _lastNetworkBytesReceived;
                _lastNetworkBytesReceived = newNetworkBytesReceived;

                NetworkStats.ReceivedSinceLastFrame.Value = diff;
                NetworkStats.ReceivedTotal.Value = newNetworkBytesReceived;
            }            

            NetworkStats.OpenConnectionsCounter.Value = BufferedReadNetworkStream.OpenConnections;
            NetworkStats.TotalConnectionsCounter.Value = BufferedReadNetworkStream.TotalConnections;
        }
    }
}
