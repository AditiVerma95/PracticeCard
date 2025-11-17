using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public GameObject difficultyPanel;
    public GameObject panel;
    public TextMeshProUGUI difficultyText;

    void Start()
    {
        
        int diff = PlayerPrefs.GetInt("Difficulty", -1); 
        if (diff >= 0 && difficultyText != null)
        {
            difficultyText.SetText(GetDifficultyName(diff));
        }
    }


    void Update()
    {

    }

    public void Play()
    {
        difficultyPanel.SetActive(true);
    }

    
    public void Easy()
    {
    
        PlayerPrefs.SetInt("Difficulty", 0);
        PlayerPrefs.Save();
        difficultyPanel.SetActive(false);
        SceneManager.LoadScene(1);
    }
    public void Medium()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        PlayerPrefs.Save();
        difficultyPanel.SetActive(false);
        SceneManager.LoadScene(1);
        if (difficultyText != null) difficultyText.SetText("Medium");
    }
    public void Hard()
    {
        PlayerPrefs.SetInt("Difficulty", 2);
        PlayerPrefs.Save();
        difficultyPanel.SetActive(false);
        SceneManager.LoadScene(1);
        if (difficultyText != null) difficultyText.SetText("Hard");
    }

    public void Exit()
    {
        Application.Quit();
    }

    
    private string GetDifficultyName(int val)
    {
        switch (val)
        {
            case 0: return "Easy";
            case 1: return "Medium";
            case 2: return "Hard";
            default: return "Unknown";
        }
    }
}