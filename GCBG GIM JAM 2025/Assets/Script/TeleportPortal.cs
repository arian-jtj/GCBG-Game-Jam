using System.Collections.Generic;
using UnityEngine;

public class TeleportPortal : MonoBehaviour
{
    private HashSet<GameObject> portalObjects = new HashSet<GameObject>();
    [SerializeField] private Transform destination;
    private bool teleportConfirm;

    public Vector3 offset;
    public GameObject sign;
    private void Start()
    {
        sign.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            teleportConfirm = true;
            //Debug.Log("X is pressed");
        }
        else teleportConfirm = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sign.SetActive(true);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       //Debug.Log("chara stay");
        if (portalObjects.Contains(collision.gameObject))
        {
            return;
        }

        if (destination.TryGetComponent(out TeleportPortal destinationPortal))
        {
            destinationPortal.portalObjects.Add(collision.gameObject);
        }

        //Debug.Log("cek tombol X");
        if (teleportConfirm == true)
        {
            collision.transform.position = destination.position + offset;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        portalObjects.Remove(collision.gameObject);
        sign.SetActive(false);
    }
}
