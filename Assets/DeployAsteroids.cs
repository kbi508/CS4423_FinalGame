using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 10f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(asteroidWave());
    }

    private void spawnAsteroid()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(Random.RandomRange(-6, 4),7);
        Destroy(a, 10);
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            spawnAsteroid();
            yield return new WaitForSeconds(respawnTime);
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
