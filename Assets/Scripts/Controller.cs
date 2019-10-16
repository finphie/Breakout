using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rigid.AddForce(transform.forward * Input.GetAxisRaw("Horizontal"), ForceMode.VelocityChange);
    }
}