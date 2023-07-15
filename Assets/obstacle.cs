using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        //GetComponent<AudioSource>().Play();
        Debug.Log("Collision occured");


        if (other.GetComponent<Creature>() != null)
        {

            SceneManager.LoadScene("MainMenu");
        }
        else if (other.GetComponent<Projectile>() != null)
        {
            
            Destroy(this.gameObject);
            
            
        }

    }
}
