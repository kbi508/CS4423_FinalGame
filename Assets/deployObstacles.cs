using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleWave());
    }

    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(Random.RandomRange(-6, 4), 6);
        Destroy(a, 10);
    }
    IEnumerator obstacleWave()
    {
        while(true){
            spawnObstacle();
            yield return new WaitForSeconds(respawnTime);
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
