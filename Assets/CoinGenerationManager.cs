using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerationManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount < 100)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(-3.3f, 3.3f),
                Random.Range(2, 5),
                Random.Range(-4f, 1f));
            Instantiate(coinPrefab, randomPos, Quaternion.identity);
            coinCount++;
        }
    }
}
