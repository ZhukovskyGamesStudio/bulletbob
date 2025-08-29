using System;
using UnityEngine;

public class MetaEntryPoint : MonoBehaviour {
    [SerializeField]
    private MetaUI _metaUI;

    private void Start() {
        _metaUI.Init(SaveLoadManager.SaveData.Money);
    }
}