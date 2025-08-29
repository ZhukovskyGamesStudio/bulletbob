using System;
using UnityEngine;

public class LoadingEntryPoint : MonoBehaviour {
    [SerializeField]
    private LoadingManager _loadingManager;

    private void Start() {
        _loadingManager.LoadNextScene();
    }
}