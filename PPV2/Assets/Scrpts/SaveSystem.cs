using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_fileName"></param>
    /// <param name="_data"></param>
    public void SaveToJSON(string _fileName, object _data)
    {
        if (_data != null)
        {
            string JSONData = JsonUtility.ToJson(_data);

            if (JSONData.Length != 0)
            {
                Debug.Log("JSON String: " + JSONData);
                string fileName = _fileName + "json";
                string filePath = Path.Combine(Application.dataPath + "/Resources/JSONS/", fileName);
            }
            else
            {
                Debug.LogWarning("ERROR - FileSystem: JSONData is empty");
            }
        }
        
        else
        {
            Debug.LogWarning("ERROR - FileSystem: _data is null, check for param [object _data]");
        }
    }
}
