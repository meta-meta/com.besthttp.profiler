using UnityEngine;

namespace BestHTTP.Profiler
{
    /// <summary>
    /// Component that can be added to a GameObject on the scene.
    /// </summary>
    /// <remarks>It marks the GameObject with DontDestroyOnLoad, as a best practice place it on an empty one!</remarks>
    public sealed class DataCollector : MonoBehaviour
    {
        private void Awake()
        {
            ProfilerUpdater.Attach();
            GameObject.DontDestroyOnLoad(this.gameObject);
        }

        private void OnDestroy()
        {
            ProfilerUpdater.Detach();
        }
    }
}
