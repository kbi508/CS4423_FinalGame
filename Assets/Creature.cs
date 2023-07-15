using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public int healthPoint = 10;
    public float speed = 3.0f;
    public float rotationSpeed = 5f;
    public string creatureName = "Dudeman";

    //Transform myTransform;

    [Header("Projectiles")]
    public GameObject projectilePrefab;
    [Header("References")]

    SpriteRenderer sr;
    Rigidbody2D rb;

 
    //always called before Start();
    void Awake()
    {
        Debug.Log("Awake called");

        //myTransform = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        

        
       
    }
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
        GameController gc = GameController.gameController;  

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update called");
        //transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
        //sr.color = Color.red;
    }

    public void Move(Vector3 direction)
    {
        //transform.position += direction * speed * Time.deltaTime;
        rb.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));

        //rb.velocity = direction * speed;  //If you want the player to push anything

        //rb.AddForce(direction * speed); //If you want the weight of things to matter
    }
    public void Rotate(float horizontalInput)
    {
        //transform.position += direction * speed * Time.deltaTime;
        Debug.Log("Rotate Called");
        //rb.MoveRotation(rb.rotation + (-horizontalInput * rotationSpeed));
        rb.transform.Rotate(new Vector3(0, 0, horizontalInput) * Time.deltaTime, Space.World);

        //rb.velocity = direction * speed;  //If you want the player to push anything

        //rb.AddForce(direction * speed); //If you want the weight of things to matter
    }

    public void RandomizeColor()
    {
        sr.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
        
    }


    public void LaunchProjectile(Vector3 position)
    {
        GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        newProjectile.GetComponent<Projectile>().Launch(position);
    }

}