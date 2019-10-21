using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody rigid;

    [SerializeField]
    int speed = default;

    void Start()
    {
#if UNITY_ANDROID
        Input.backButtonLeavesApp = false;
#endif

        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 左クリックされた場合、その座標にパドルを移動
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                var position = new Vector3(rigid.position.x, rigid.position.y, hit.point.z);
                rigid.MovePosition(position);
            }
        }
    }

    void FixedUpdate()
        => rigid.velocity = speed * transform.forward * Input.GetAxisRaw("Horizontal");
}