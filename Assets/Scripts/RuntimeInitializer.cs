using UnityEngine;

public static class RuntimeInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void InitializeGameManager()
    {
        var gameObject = new GameObject("Game Manager", typeof(GameManager));
        Object.DontDestroyOnLoad(gameObject);
    }
}