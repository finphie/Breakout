using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody rigid;

    [SerializeField]
    int speed = default;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
    }

    void FixedUpdate()
    {
        rigid.velocity = speed * transform.forward * Input.GetAxisRaw("Horizontal");
    }
}