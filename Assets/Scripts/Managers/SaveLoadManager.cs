using System;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour {
    public static SaveLoadManager Instance;

    public static SaveData SaveData;

    private static string _saveKey = "saveData";

    private void Awake() {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Save() {
        string json = JsonUtility.ToJson(SaveData);
        PlayerPrefs.SetString(_saveKey, json);
    }

    public void Load() {
        string json = PlayerPrefs.GetString(_saveKey);
        SaveData = JsonUtility.FromJson<SaveData>(json);
    }

    public bool HasSave() {
        return PlayerPrefs.HasKey(_saveKey);
    }

    public void CreateNewSave() {
        SaveData = new SaveData() {
            Money = 150,
        };
        Save();
    }
}