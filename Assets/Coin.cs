using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    GameController gc = GameController.gameController;
 

    void Awake()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision occured");

        if (other.GetComponent<Creature>() != null)
        {
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            ScoreManager.instance.AddPoint();

        }
     
    }
}
