using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, ISubmitHandler
{
    const int Width = 640;
    const int Height = 480;

    public void OnPointerEnter(PointerEventData eventData)
        => EventSystem.current.SetSelectedGameObject(gameObject);

    public void OnPointerClick(PointerEventData eventData)
        => Navigation();

    public void OnSubmit(BaseEventData eventData)
        => Navigation();

    static void Exit() =>
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        Application.Quit();
#endif

    void Navigation()
    {
        switch (gameObject.name)
        {
            case "Title":
                SceneManager.LoadScene("Title");
                break;
            case "Credit":
                SceneManager.LoadScene("Credit");
                break;
            case "Start":
            case "Continue":
                SceneManager.LoadScene("Main");
                break;
            case "Exit":
                Exit();
                break;
            default:
                throw new ArgumentException($"GameObject: {gameObject.name}は存在しません。");
        }
    }

    void Update()
    {
        if (gameObject.scene.name == "Title" && Input.GetKeyDown(KeyCode.F11))
        {
            // 全画面表示からウインドウ表示に切り替え
            if (Screen.fullScreen)
            {
                Screen.SetResolution(Width, Height, false);
                return;
            }

            // ウインドウ表示から全画面表示に切り替え
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        }
    }
}