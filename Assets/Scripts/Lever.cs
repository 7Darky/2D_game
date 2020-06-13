using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Door;
    public GameObject DoorOpened;
    public GameObject LeverUsed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Door.SetActive(false);
            this.gameObject.SetActive(false);
            LeverUsed.SetActive(true);
            if (DoorOpened != null)
                DoorOpened.SetActive(true);
        }
    }
}
