using UnityEngine;

public class ScatterItem : MonoBehaviour
{
    public GameObject item;
    void Start()
    {
        item.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        item.SetActive(false);
    }
}
