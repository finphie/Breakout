using UnityEngine;

public class TableCamera : MonoBehaviour
{
#if UNITY_ANDROID
    void Awake()
        => Camera.main.fieldOfView = 87;
#endif
}