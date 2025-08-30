using UnityEngine;

public class ChangeScoreByHit : MonoBehaviour
{
    private void OnMouseDown() {
        Debug.Log("Added 1 point");
        Destroy(gameObject);
    }
}
