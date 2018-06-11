using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public int NumberWinner;
    public static Pause s_Singleton;
    private List<int> Scores = new List<int>();
    public bool IsActive = false;
    public static int P1Score = 0;
    public static int P2Score = 0;
    public static int P3Score = 0;
    public static int P4Score = 0;
    public string PauseButton;
    public string BackButton;
    [SerializeField] private GameObject pausePanel;

    private void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        NumberWinner = 0;
        pausePanel.SetActive(false);
        for (var i = 0; i < 4; i++)
        {
            Scores.Add(0);
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "PlayerNumber")
        {
            Destroy(this.gameObject);
        }
            if (Input.GetButtonDown(PauseButton))
        {
            if (!pausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            else
            {
                if (pausePanel.activeInHierarchy)
                {
                    ContinueGame();
                }
            }
        }
        if (Input.GetButtonDown(BackButton)&&pausePanel.activeInHierarchy == true)
        {
            Time.timeScale = 1;
            Winner();
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void AddScore(int indxJ)
    {
        Scores[indxJ] +=1;
    }
    void Winner()
    {
        Scores.Sort();
        Scores.Reverse();
        if (Scores[0] == Scores[1])
        {
            SceneManager.LoadScene("Egalité");
        }
        else
        {
            if (P1Score > P2Score && P1Score > P3Score && P1Score > P4Score)
            {
                NumberWinner = 1;
            }
            if (P2Score > P1Score && P2Score > P3Score && P2Score > P4Score)
            {
                NumberWinner = 2;
            }
            if (P3Score > P2Score && P3Score > P1Score && P3Score > P4Score)
            {
                NumberWinner = 3;
            }
            if (P4Score > P2Score && P4Score > P3Score && P4Score > P1Score)
            {
                NumberWinner = 4;
            }
            SceneManager.LoadScene("WinnerScene");
        }

    }
}