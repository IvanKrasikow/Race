using UnityEngine;
using UnityEngine.UI;

public class CollectiblePizza : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip clip;

    public Text scoreText;
    private int _money=0;


    private void OnTriggerEnter(Collider other)
    {
        var tag = other.gameObject.tag;

        if (tag == "Money")
        {
            _money++;
            scoreText.text = "Score: " + _money.ToString();
            Destroy(other.gameObject);
            aS.PlayOneShot(clip);
        }
      
    }
}