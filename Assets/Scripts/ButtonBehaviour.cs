using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject main;
    public GameObject other;
    public GameObject pause, retryButton, exitButton;
    public PauseMenuBehaviour pauseMenu;
    public Scene scene;
    public bool nextLevel;
    public bool retry;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Retry()
    {
        retry = true;
    }
    public void NextLevel()
    {
        nextLevel = true;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Continue()
    {
        pause.SetActive(false);
        retryButton.SetActive(false);
        exitButton.SetActive(false);

        pauseMenu.isPaused = false;
        pauseMenu.touchTimes = 0;

        Time.timeScale = 1;
    }

    public void Credits()
    {
        other.SetActive(true);
        main.SetActive(false);
    }
    //References//
    public void Discord()
    {
        Application.OpenURL("https://discord.com/channels/965640109489799188");
    }
    public void YouTube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCjZNfgqLMHMbjF_pJ8Dq97g");
    }
    /////////////
    
    //Title//
    public void DevYouTube1()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCqr3Qm4FcVP6PB7JFXXP_gA");
    }
    public void DevYouTube2()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCGaxKR5GZriKgG-V_GrJ5Fw");
    }
    ////////
    public void Settings()
    {
        main.SetActive(false);
        other.SetActive(true);
    }
    public void Back()
    {
        main.SetActive(true);
        other.SetActive(false);
    }
    public void CloseApplication()
    {
        Application.Quit();
    }
}
