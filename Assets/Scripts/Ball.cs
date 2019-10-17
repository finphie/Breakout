using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;

    [SerializeField]
    int speed = default;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.right * speed, ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        // ボールの移動速度を一定にする。
        rigid.velocity = rigid.velocity.normalized * (speed / 2);

        // ボールがブロックに衝突した場合、ブロックを削除する。
        if (collision.gameObject.name.StartsWith("Block", StringComparison.Ordinal))
            Destroy(collision.gameObject); 
    }
}