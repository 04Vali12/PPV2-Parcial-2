using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem Instance;
    public GameObject data;
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
    private
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
    public T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T Dato = new T();
        string path = Application.DataPath + "Resources/JSONS" + _fileName + ".json";
        string JSONData = "";
        if (File.Exists(path))
        {
            JSONData = File.ReadAllText(path);
            Debu.Log("JSON STRING:" + JSONData);
            if (JSONData.Lenght != 0)
            {
                JsonUtility.FROMjsonOverwrite(JSONData, Dato);

            }
            else
            {
                Debug.LogWarning("ERROR - FILESYSTEM: JSONData is empty, check for local variable[string JSONData]");
            }
            return Dato;
        }
    }
} 
