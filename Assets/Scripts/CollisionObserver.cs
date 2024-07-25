using UnityEngine;
using UnityEngine.UI;

public class CollisionObserver : MonoBehaviour
{
    [SerializeField]
    private Text winText;

    private void OnCollisionEnter(Collision other)
    {
        var tag = other.gameObject.tag;

        if (tag == "Player")
            winText.text = "Победа";

        else if (tag == "Enemy")
            winText.text = "Поражение";
    }
}