using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerS : MonoBehaviour
{
    [SerializeField] GameObject Guy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Guy.GetComponent<PlayerControl>().CheckDoor();
        
    }
}
