using System;
using UnityEngine;

public class LoadingEntryPoint : MonoBehaviour {
    [SerializeField]
    private LoadingManager _loadingManager;

    private void Start() {
        if (SaveLoadManager.Instance.HasSave()) {
            SaveLoadManager.Instance.Load();
        } else {
            SaveLoadManager.Instance.CreateNewSave();
        }

        _loadingManager.LoadNextScene();
    }
}