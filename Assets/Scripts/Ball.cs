using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    int speed = default;

    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        // ボールがブロックに衝突した場合、ブロックを削除する。
        if (collision.gameObject.name.StartsWith("Block", StringComparison.Ordinal))
            Destroy(collision.gameObject);
    }
}