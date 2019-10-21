using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID
        Input.backButtonLeavesApp = true;
#endif

        // 「Game Clear」または「Game Over」を表示
        GetComponentInChildren<Text>().text = GameManager.Instance.Message;
    }
}