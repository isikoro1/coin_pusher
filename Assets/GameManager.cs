using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private Rigidbody rb2;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        startPos = transform.position;
        //InvokeRepeating("ThrowCoin", 1, 1);
    }
    void Update()
    {
        rb2.MovePosition(new Vector3(
            startPos.x + Mathf.Sin(Time.time * 1.2f)*3,
            startPos.y,
            startPos.z
            ));

        if (Input.GetKeyDown(KeyCode.Space)) // スペースキーが押されたら
        {
            ThrowCoin(); // ThrowCoin関数を呼び出す
        }
    }
    private void ThrowCoin()
    {
        //Vector3 randomPos = new Vector3(
        //        Random.Range(-3.3f, 3.3f),
        //        transform.position.y,
        //        transform.position.z);
        //Instantiate(coinPrefab, randomPos, Quaternion.identity);
        float anglex = Random.Range(0f, 360f);
        float angley = Random.Range(0f, 360f);
        float anglez = Random.Range(0f, 360f);
        Quaternion rotation = Quaternion.Euler(anglex, angley, anglez);
        Instantiate(coinPrefab, transform.position, rotation);
    }
    
}
