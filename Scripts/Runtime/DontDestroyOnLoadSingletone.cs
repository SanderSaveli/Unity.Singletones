using UnityEngine;

namespace Singletones 
{
    public abstract class DontDestroyOnLoadSingletone<T> : Singletone<T> where T : Component
    {
        public virtual void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
    }
}
