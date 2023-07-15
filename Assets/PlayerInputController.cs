using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    Creature creature;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        creature = GetComponent<Creature>();
      
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            creature.RandomizeColor();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            creature.LaunchProjectile(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            GetComponent<AudioSource>().Play();
            //creature.LaunchProjectile(transform.up);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = 0f;

        if (Input.GetKey(KeyCode.D))
        { 
            horizontalInput = -110f;
            Debug.Log("D Pressed");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            horizontalInput = 110f;
            Debug.Log("A Pressed");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            //creature.Move(new Vector3(0, 1, 0));
            creature.Move(transform.up);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            creature.Move(new Vector3(0, -1, 0));
            creature.Move(-transform.up);
        }
        creature.Rotate(horizontalInput);





    }
}
