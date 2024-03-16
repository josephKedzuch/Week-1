using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] GameObject Guy;
    [SerializeField] GameObject Key;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Key.SetActive(false);
        Guy.GetComponent<PlayerControl>().GetKey(true);
    }
}
