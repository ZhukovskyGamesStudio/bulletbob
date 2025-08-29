using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreUI : MonoBehaviour {
    public void EarnMoney() {
        SaveLoadManager.SaveData.Money += 100;
        SaveLoadManager.Instance.Save();
    }

    public void ExitToMeta() {
        SceneManager.LoadScene("MetaScene");
    }
}