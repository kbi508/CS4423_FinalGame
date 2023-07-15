using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoins : MonoBehaviour
{
    public GameObject coinPrefab;
    public float respawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coinWave());
    }

    private void spawnCoin()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject;
        a.transform.position = new Vector2(Random.RandomRange(-5, 6), 6);
        Destroy(a, 10);
    }
    IEnumerator coinWave()
    {
        while (true)
        {
            spawnCoin();
            yield return new WaitForSeconds(respawnTime);
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
