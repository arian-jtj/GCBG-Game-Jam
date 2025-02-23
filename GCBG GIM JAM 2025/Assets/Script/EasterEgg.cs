using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.I) && Input.GetKeyDown(KeyCode.N))
        {
            Application.OpenURL("https://genshin.hoyoverse.com/en/");
        }
    }
}
