using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class asteroid : MonoBehaviour
{
    public int healthPoint = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //GetComponent<AudioSource>().Play();
        Debug.Log("Collision occured");
        if (other.GetComponent<Projectile>() != null)
        {
            healthPoint = healthPoint - 1;
            if (healthPoint <= 0)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
