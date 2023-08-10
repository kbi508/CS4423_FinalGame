using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    GameController gc = GameController.gameController;

    public AudioClip audioClip;


    public void PlaySound()
    {
        SFXHandler.singleton.PlaySound(audioClip);
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision occured");

        if (other.GetComponent<Creature>() != null)
        {
            
            //Destroy(this.gameObject);
            ScoreManager.instance.AddPoint();

        }
     
    }
}
