namespace LoggerUnity
{
    using UnityEngine;

    public class Logger
    {
        public static void Log(string message)
        {
            if(Application.isEditor)
                Debug.Log(message);
        }
    }
}