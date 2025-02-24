using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(true);
            Time.timeScale=0;

        }
        
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale=0;
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Options()
    {

    }

}
