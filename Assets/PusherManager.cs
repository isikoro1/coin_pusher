using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherManager : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(new Vector3(
            startPos.x,
            startPos.y,
            startPos.z + Mathf.Sin(Time.time * 0.7f)
            ));
    }
}
