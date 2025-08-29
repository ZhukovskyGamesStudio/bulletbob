using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour {
    
    
    public void LoadNextScene() {
        SceneManager.LoadScene("MetaScene");
    }
}