using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float maxTime;
    public Vector3 dir = Vector3.right;

    private Rigidbody _rb;
    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            currentTime = 0;
        }
        gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
       _rb.velocity = speed * Vector3.right;
    }
}
