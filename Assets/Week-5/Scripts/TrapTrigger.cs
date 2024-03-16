using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] GameObject Guy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Guy.GetComponent<PlayerControl>().RemoveHealth(5);
    }

}
