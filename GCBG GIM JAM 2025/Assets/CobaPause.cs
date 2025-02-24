using UnityEngine;

public class CobaPause : MonoBehaviour
{

    public GameObject PanelPause;

    public void Pause()
    {
        PanelPause.SetActive(true);
        Time.timeScale = 0;

    }

    public void Continue()
    {
        PanelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
