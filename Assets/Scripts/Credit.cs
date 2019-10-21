using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    ScrollRect scroll;

    void Start()
    {
#if UNITY_ANDROID
        Input.backButtonLeavesApp = false;
#endif

        scroll = GetComponentInChildren<ScrollRect>();

        // スクロール位置を一番左上にする。
        scroll.verticalNormalizedPosition = 1;
        scroll.horizontalNormalizedPosition = 0;
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

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            scroll.horizontalNormalizedPosition = Mathf.Clamp(scroll.horizontalNormalizedPosition - 0.05F, 0, 1);
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            scroll.horizontalNormalizedPosition = Mathf.Clamp(scroll.horizontalNormalizedPosition + 0.05F, 0, 1);
            return;
        }

#if UNITY_STANDALONE
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape))
#elif UNITY_ANDROID
        if (Input.GetKeyDown(KeyCode.Escape))
#else
        if (Input.GetKeyDown(KeyCode.Return))
#endif
            SceneManager.LoadScene("Title");
    }
}