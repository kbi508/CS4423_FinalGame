using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployHealth : MonoBehaviour
{
    public GameObject healthPrefab;
    public float respawnTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(healthWave());
    }

    private void spawnHealth()
    {
        GameObject a = Instantiate(healthPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5, 6), Random.Range(1, 4));
        Destroy(a, 10);
    }
    IEnumerator healthWave()
    {
        while (true)
        {
            spawnHealth();
            yield return new WaitForSeconds(30);
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
