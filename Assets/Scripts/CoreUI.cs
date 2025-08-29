using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreUI : MonoBehaviour {
    public void ExitToMeta() {
        SceneManager.LoadScene("MetaScene");
    }
}