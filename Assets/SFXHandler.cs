using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXHandler : MonoBehaviour
{

    public static SFXHandler singleton;


    private void Awake()
    {
        if(singleton != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            singleton = this;
        }
    }


    // Start is called before the first frame update
    public void PlaySound(AudioClip ac)
    {
        GetComponent<AudioSource>().PlayOneShot(ac);
    }
}
