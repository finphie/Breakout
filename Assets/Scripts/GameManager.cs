using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int BlockCount { get; set; }

    public string Message { get; set; }

    GameObject bar;
    GameObject ball;

    GameManager()
    {
    }

    void Awake()
    {
        if (!(Instance is null))
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        bar = GameObject.FindGameObjectWithTag("Bar");
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void Update()
    {
        
    }

    public void EndGame(string message)
    {
        Message = message;
        SceneManager.LoadScene("Result");
    }

    public bool IsClear()
        => BlockCount == 0;

    public bool IsGameOver()
    {
        if (ball == null || bar == null)
            Start();

        return ball.transform.position.x > bar.transform.position.x;
    }
}