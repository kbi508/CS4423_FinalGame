using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 20;

    public GameObject target;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 3);
    }



    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(transform.forward, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
       // rb.velocity = transform.up * speed;


    }

    public void Launch(Vector3 position)
    {
        transform.rotation = Quaternion.LookRotation(transform.forward, position - transform.position);
        rb.velocity = transform.up * speed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //GetComponent<AudioSource>().Play();
        Debug.Log("Collision occured");
        if (other.GetComponent<asteroid>() != null)
        { 
            Destroy(this.gameObject);
        }

    }
}
