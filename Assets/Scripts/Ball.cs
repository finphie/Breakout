using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;
    GameManager manager;

    [SerializeField]
    int speed = default;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.right * speed, ForceMode.VelocityChange);
        manager = GameManager.Instance;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        // ボールの移動速度を一定にする。
        rigid.velocity = rigid.velocity.normalized * (speed / 2);

        // ボールがブロックに衝突した場合
        if (collision.gameObject.name.StartsWith("Block", StringComparison.Ordinal))
        {
            // ブロックを削除
            Destroy(collision.gameObject);
            GameManager.Instance.BlockCount--;

            // クリアした場合
            if (manager.IsClear())
                manager.EndGame("Game Clear!");

            return;
        }

        // ゲームオーバーの場合
        if (manager.IsGameOver())
            manager.EndGame("Game Over!");
    }
}