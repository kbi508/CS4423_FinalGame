using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController gameController = null;
    // Start is called before the first frame update
    void Awake()
    {
        if(gameController == null)
        {
            gameController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
