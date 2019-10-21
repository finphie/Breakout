using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    ScrollRect scroll;

    void Start()
    {
        scroll = GetComponentInChildren<ScrollRect>();

        // スクロール位置を一番上にする。
        scroll.verticalNormalizedPosition = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            scroll.verticalNormalizedPosition = Mathf.Clamp(scroll.verticalNormalizedPosition + 0.05F, 0, 1);
            return;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            scroll.verticalNormalizedPosition = Mathf.Clamp(scroll.verticalNormalizedPosition - 0.05F, 0, 1);
            return;
        }

        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Title");
    }
}