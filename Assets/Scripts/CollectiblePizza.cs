using UnityEngine;
using UnityEngine.UI;

public class CollectiblePizza : MonoBehaviour
{
    public Text scoreText;
    private int _money=0;

    private void OnTriggerEnter(Collider other)
    {
        var tag = other.gameObject.tag;

        if (tag == "Money")
        {
            _money++;
            scoreText.text = _money.ToString();
            Destroy(other.gameObject);
        }
      
    }
}