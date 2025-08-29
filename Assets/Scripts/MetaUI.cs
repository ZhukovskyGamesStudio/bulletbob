using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaUI : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI _moneyCounter;

    public void Init(int money) {
        _moneyCounter.text = money.ToString();
    }

    public void Play() {
        SceneManager.LoadScene("CoreScene");
    }
}