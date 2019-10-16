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
}