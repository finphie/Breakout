using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    void Start()
    {
        // 「Game Clear」または「Game Over」を表示
        GetComponentInChildren<Text>().text = GameManager.Instance.Message;

        var buttons = GetComponentsInChildren<Button>();

        // Continueを選択状態にする。
        buttons.First(x => x.name == "Continue").Select();
    }

    void Update()
    {
        
    }
}