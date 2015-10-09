namespace LoggerUnity
{
    using UnityEngine;

    public class Logger
    {
        public static void Log(string message)
        {
            #if UNITY_EDITOR
                Debug.Log(message);
            #endif            
        }
    }
}