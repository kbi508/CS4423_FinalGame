using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int count = 0;
    GameController gc = GameController.gameController;
    Text text;

    void Awake()
    {
        text = gc.GetComponent<Text>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Collision occured");
        
        

        if (other.GetComponent<Creature>() != null)
        {
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            count += 1;
            text.text = count.ToString();
        }
     
    }
}
