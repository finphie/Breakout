using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, ISubmitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
        => EventSystem.current.SetSelectedGameObject(gameObject);

    public void OnPointerClick(PointerEventData eventData)
        => Navigation();

    public void OnSubmit(BaseEventData eventData)
        => Navigation();

    void Navigation()
    {
        switch (gameObject.name)
        {
            case "Top":
                break;
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

    void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
        Application.Quit();
#endif
    }
}