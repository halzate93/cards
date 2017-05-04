using UnityEngine;

namespace Utils
{
    public static class LocalStorage
    {
        public static void SetData<T> (string key, T data)
        {
           string json = JsonUtility.ToJson (data);
           Debug.Log (json);
           PlayerPrefs.SetString (key, json); 
        }

        public static T GetData<T> (string key)
        {
            string json = PlayerPrefs.GetString (key);
            if (string.IsNullOrEmpty (json))
                return default (T);
            else
                return JsonUtility.FromJson<T> (json);
        }
    }
}